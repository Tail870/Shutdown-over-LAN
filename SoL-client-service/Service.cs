using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace SoL_client_service
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        NetworkClient networkClient;

        protected override void OnStart(string[] args)
        {
            networkClient = new NetworkClient();
            Thread startThread = new Thread(new ThreadStart(networkClient.StartSoLService));
            startThread.Start();
        }

        protected override void OnStop()
        {
            networkClient.StopSoLService();
        }
    }
}
