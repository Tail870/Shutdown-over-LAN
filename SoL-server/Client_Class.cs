using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace SoL_server
{
    class Client_Class
    {
        public string Name  { get; set; }  
        public string IP { get; set; }
        public TcpClient CLIENT;

    }
}