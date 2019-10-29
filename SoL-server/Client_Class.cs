using System;
using System.Net.Sockets;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace SoL_server
{
    class Client_Class
    {
        // Client's selection.
        public bool IsSelected { get; set; }
        // Client's name.
        public string Name { get; set; }
        // Client's OS.
        public string OS { get; set; }
        // Client's IP.
        public string IP { get; set; }
        // Client's TCPClient object. that holds connection.
        public TcpClient CLIENT;

        const int SUPPORTED_PROTOCOL_VERSION = 0;
        public void Cmd(String opt)  
        {
            string textToSend = "MOL:" + SUPPORTED_PROTOCOL_VERSION + "\n" +
                                "ACT:cmd\n" +
                                "OPT:" + opt + "\n";
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            NetworkStream nwStream;
            try
            {
                nwStream = CLIENT.GetStream();
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
            catch (System.ObjectDisposedException)
            {
                return;
            }
            catch (System.IO.IOException)
            {
                return;
            }
        }
        public void Shutdown(bool force, decimal timer)
        {
            char forceChar;
            if (force)
                forceChar = 'y';
            else
                forceChar = 'n';
            string textToSend = "MOL:" + SUPPORTED_PROTOCOL_VERSION + "\n" +
                                "ACT:shutdown\n" +
                                "OPT:" + "force=" + forceChar + "," + "timer=" + timer.ToString() + "\n";
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            NetworkStream nwStream;
            try
            {
                nwStream = CLIENT.GetStream();
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
            catch (System.ObjectDisposedException)
            {
                return;
            }
            catch (System.IO.IOException)
            {
                return;
            }
        }
    }
}