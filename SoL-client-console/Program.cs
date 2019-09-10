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
        static void Main(string[] args)
        {
                // Create client service object. 
            networkClient = new NetworkClient();
                // Create thread for servicing and start it.
            Thread startThread = new Thread(new ThreadStart(networkClient.StartSoLService));
            startThread.Start();
        }
    }
}
