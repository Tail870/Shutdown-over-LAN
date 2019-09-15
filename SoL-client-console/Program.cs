using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SoL_client_service;

namespace SoL_client_console
{
    class Program
    {
        static SoL_client_service.NetworkClient networkClient;
        static string address;
        static int port;
        static void Main(string[] args)
        {
            Console.WriteLine("Type in server's address (IP or domain). //Default: localhost");
            address = Console.ReadLine();
            Console.WriteLine("Type in server's listening port. //Default: 870");
            while (true)
            {
                try
                {
                    string tempport = Console.ReadLine();
                    if (tempport.Length == 0)
                        port = 870;
                    else
                        port = int.Parse(tempport);
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Type in a VALID server's listening port. //Default: 870");
                }
            }
            if (address.Length != 0)
                networkClient = new NetworkClient(address, port);
            else
                networkClient = new NetworkClient(port);
            Console.WriteLine("Starting client...");
            // Create thread for servicing and start it.
            Thread startThread = new Thread(new ThreadStart(networkClient.StartSoLService));
            startThread.Start();
            while (true)
            {
                Console.WriteLine("Thread status: " + startThread.ThreadState.ToString());
                Thread.Sleep(2000);
            }
        }
    }
}