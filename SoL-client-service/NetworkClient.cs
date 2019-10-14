using Microsoft.Win32;
using System;
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
         * 
         */

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
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    // Receive data.
                    int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                    // If received NOTHING (in case lost connection)...
                    if (bytesRead < 1)
                        throw new Exception();
                    // Convert from binary to ASCII string.
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    // Perform received command.
                    Console.Write(dataReceived);
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
            while (Service.ThreadState == ThreadState.Running)
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