using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SoL_server
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Thread ClientListenerThread;
        private BindingList<Client_Class> listPC = new BindingList<Client_Class>();
        private int PORT_NO = 870;
        private IPAddress localAdd = IPAddress.Any;
        private TcpListener listener;
        private bool ServerEnabled = true;

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClientListenerThread = new Thread(new ThreadStart(ClientListener));
            ClientListenerThread.Start();
            dataGridViewClients.DataSource = listPC;
        }
        private void ClientListener()
        {
            //---listen at the specified IP and port no.---
            listener = new TcpListener(localAdd, PORT_NO);
            listener.Start();
            while (ServerEnabled)
            {
                //---incoming client connected---
                Thread threadHandleClient = new Thread(new ParameterizedThreadStart(HandleClient));
                TcpClient client;
                try
                {
                    client = listener.AcceptTcpClient();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    break;
                }
                threadHandleClient.Start(client);
            }
        }
        void addElement(Client_Class value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Client_Class>(addElement), new object[] { value });
                return;
            }
            listPC.Add(value);
        }
        public void HandleClient(Object arg)
        {
            Client_Class temp = new Client_Class();
            temp.CLIENT = (TcpClient)arg;
            {
                //---get the incoming client name through a network stream---
                NetworkStream nwStream = temp.CLIENT.GetStream();
                byte[] buffer = new byte[temp.CLIENT.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, temp.CLIENT.ReceiveBufferSize);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                temp.Name = dataReceived;
                nwStream.Write(buffer, 0, bytesRead);
                nwStream.Flush();

                temp.IP = temp.CLIENT.Client.RemoteEndPoint.ToString();
                addElement(temp);
            }

            int index = listPC.Count() - 1;
            bool Connected = true;
            while (Connected)
            {
                //---get the incoming data through a network stream---
                NetworkStream nwStream = listPC[index].CLIENT.GetStream();
                byte[] buffer = new byte[listPC[index].CLIENT.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead;
                try
                {
                    bytesRead = nwStream.Read(buffer, 0, listPC[index].CLIENT.ReceiveBufferSize);
                }
                catch (System.IO.IOException)
                {
                    Connected = false;
                    return;
                }
                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listPC[index].Name = dataReceived;
                dataGridViewClients.Invoke((MethodInvoker)delegate
                {
                    dataGridViewClients.Refresh();
                });
                //---write back the text to the client---
                nwStream.Write(buffer, 0, bytesRead);
            }
        }

        private void DataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string textToSend = "mkdir C:\\test";
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                    NetworkStream nwStream = listPC[dataGridViewClients.CurrentCell.RowIndex].CLIENT.GetStream();
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerEnabled = false;
            listener.Stop();
            for (int i = 0; i < listPC.Count; i++)
            {
                listPC[i].CLIENT.GetStream().Close();
                listPC[i].CLIENT.Close();
            }
        }
    }
}