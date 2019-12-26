using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SoL_client_service
{
    public class NetworkClient
    {
        const int SUPPORTED_PROTOCOL_VERSION = 0;
        /*********************************************************************
         * Main constructor.
         * When called receves
         * server's address and port.
         */
        private string ServerAddress; // Server's address (IP, domain).
        private int Port;             // Server's port.
        public NetworkClient(string ServerAddress, int Port)
        {
            //Set server's address. Will be changable via configs in future.
            this.ServerAddress = ServerAddress;
            //Set server's port. Will be changable via configs in future.
            this.Port = Port;
        }
        /*********************************************************************
         * Constructor for 
         * debugging purposes.
         * Will not be used in release.
         */
        public NetworkClient()
        {
            // Set address to localhost.
            ServerAddress = "127.0.0.1";
            // Default port - 870.
            Port = 870;
        }
        /*********************************************************************
         * Constructor for 
         * debugging purposes.
         * Will not be used in release.
         */
        public NetworkClient(string ServerAddress)
        {
            //Set server's address. Will be changable via configs in future.
            this.ServerAddress = ServerAddress;
            // Default port - 870.
            Port = 870;
        }
        /*********************************************************************
         * Constructor for 
         * debugging purposes.
         * Will not be used in release.
         */
        public NetworkClient(int Port)
        {
            // Set address to localhost.
            ServerAddress = "127.0.0.1";
            //Set server's port. Will be changable via configs in future.
            this.Port = Port;
        }
        /*********************************************************************
         * Method for connecting 
         * to server. Should be running
         * in separate thread 
         * otherwise main will be blocked
         * until successful connection.
         */
        public bool Connected = false;  // Connection status.
        private int RetryCooldown = 500; // Connection retry cooldown in ms. Will be changable via configs in future.
        private TcpClient client;        // TCP-socket.
        private NetworkStream nwStream;  // Network stream for exchanging data with server.
        public void Connect()
        {
            // Clear nwStream object if reconnecting.
            if (nwStream != null)
                nwStream = null;
            string name = Environment.MachineName;
            var os = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\", "ProductName", "");
            if (Environment.Is64BitOperatingSystem)
                os += " 64 bit";
            else
                os += " 32 bit";
            string SendData = "MOL:" + SUPPORTED_PROTOCOL_VERSION.ToString() + "\n" +
                              "ASK:connect\n" +
                              "NMAE:" + name + "\n" +
                              "OS:" + os + "\n";
            while (!Connected)
            {
                try
                {
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(SendData);
                    // Create socket and establish connection.
                    client = new TcpClient(ServerAddress, Port);
                    nwStream = client.GetStream();
                    // Send client's name to server.
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    // Read answer.
                    StreamReader streamReader = new StreamReader(nwStream);
                    {
                        String ProtocolNameVersion = streamReader.ReadLine();
                        if (!ProtocolNameVersion.StartsWith("MOL:"))
                        {
                            nwStream.Close();
                            client.Close();
                        }
                        if (!int.TryParse(ProtocolNameVersion.Substring(4), out int ProtocolVersion))
                        {
                            nwStream.Close();
                            client.Close();
                        }
                    }
                    {
                        String Stat = streamReader.ReadLine();
                        if (!Stat.StartsWith("STAT:"))
                        {
                            nwStream.Close();
                            client.Close();
                        }
                        if (!(Stat.Substring(5) == "ok"))
                        {
                            nwStream.Close();
                            client.Close();
                        }
                    }

                    // Rise connected flag.
                    Connected = true;
                }
                // If connection failed clear terminate TCP connection 
                // and wait before next attempt.
                catch (System.NullReferenceException)
                {
                    client.Close();
                    Thread.Sleep(RetryCooldown);
                }
                catch (System.IO.IOException)
                {
                    client.Close();
                    Thread.Sleep(RetryCooldown);
                }
                catch (System.Net.Sockets.SocketException)
                {
                    Thread.Sleep(RetryCooldown);
                }
            }
        }
        /*********************************************************************
         * Method for waiting
         * server's instructions.
         */
        private void HandleServer()
        {
            while (ServiceEnabled)
            {
                try
                {
                    // Prepare to receive data.
                    if (client.Client.Poll(1, SelectMode.SelectRead))
                    {
                        throw new Exception();
                    }
                    StreamReader streamReader = new StreamReader(nwStream);
                    String ProtocolNameVersion = streamReader.ReadLine();
                    Console.WriteLine("     " + ProtocolNameVersion);
                    String ACT = streamReader.ReadLine();
                    Console.WriteLine("     " + ACT);
                    String OPTsLine = streamReader.ReadLine();
                    Console.WriteLine("     " + OPTsLine);

                    switch (ACT.Substring(4))
                    {
                        case ("shutdown"):
                            {
                                Console.WriteLine("shutdown");
                                string[] OPTs = OPTsLine.Split(',');
                                String force = "";
                                String timer = "0";
                                foreach (string singleOPT in OPTs)
                                {
                                    if (singleOPT.StartsWith("force="))
                                    {
                                        if (singleOPT.Substring(6) == "y")
                                            force = "-f ";
                                        else
                                        if (singleOPT.Substring(6) == "n")
                                            force = "";

                                    }
                                    else
                                    if (singleOPT.StartsWith("timer="))
                                    {
                                        if (int.TryParse(singleOPT.Substring(6), out int temp))
                                            timer = temp.ToString();
                                    }
                                }
                                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(
                                    "MOL:" + SUPPORTED_PROTOCOL_VERSION + "\n" +
                                    "ASK:disconnect\n");
                                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                                Process process = new Process();
                                process.StartInfo = new ProcessStartInfo
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    FileName = "cmd.exe",
                                    Arguments = "/c " + "shutdown -s " + force + "-t " + timer
                                };
                                process.Start();
                                break;
                            }
                        case ("cmd"):
                            {
                                Console.WriteLine("cmd");
                                Console.WriteLine(OPTsLine.Substring(4));
                                Process process = new Process();
                                process.StartInfo = new ProcessStartInfo
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    FileName = "cmd.exe",
                                    Arguments = "/c " + OPTsLine.Substring(4)
                                };
                                process.Start();
                                break;
                            }
                    }
                }
                catch
                {
                    // ...Check, if service enabled.
                    if (ServiceEnabled)
                    {
                        // Start attempting to reconnect.
                        Connected = false;
                        Connect();
                    }
                    else
                    {
                        // Otherwise abort loop in case of disabled service.
                        return;
                    }
                }
            }
        }
        /*********************************************************************
         * Process the incoming command.
         */
        private bool ProcessAsk(string arg)
        {

            return true;
        }
        /*********************************************************************
         * Start service thread.
         */
        Thread Service;              // Thread for service.
        bool ServiceEnabled = false; // Service flag.
        public void StartSoLService()
        {
            // Establish connection.
            Connect();
            // Rise service flag.
            ServiceEnabled = true;
            // Create and start thread for listening server's commands.
            Service = new Thread(new ThreadStart(HandleServer));
            Service.Start();
        }

        /*********************************************************************
         * Stop service thread.
         */
        public void StopSoLService()
        {
            // Abort service thread.
            while (Service.ThreadState == System.Threading.ThreadState.Running)
            {
                // Abort service thread.
                Service.Abort();
                // Close connection via disposing network stream to unlock service thread from reading data.
                nwStream.Dispose();
                Thread.Sleep(500);
            }
            ServiceEnabled = false;
        }
    }
}