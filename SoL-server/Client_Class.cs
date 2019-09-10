using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace SoL_server
{
    class Client_Class
    {
        // Client's name.
        public string Name  { get; set; }
        // Client's IP.
        public string IP { get; set; }
        // Client's TCPClient object. that holds connection.
        public TcpClient CLIENT;

    }
}