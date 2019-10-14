using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SoL_server

{
    public partial class FormMain : Form
    {
        public FormMain() { InitializeComponent(); }

        private BindingList<Client_Class> listPC = new BindingList<Client_Class>(); // List of connected clients.
        /*********************************************************************
         * In FormMain_Load event
         * bind list of objects "listPC" and
         * start to listen for clients.
         */
        private Thread ClientListenerThread; // Thread for listener.
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = listPC;
            // Create connection listener thread.
            ClientListenerThread = new Thread(new ThreadStart(ClientListener))
            {
                IsBackground = true
            };
            ClientListenerThread.Start();
        }
        /*********************************************************************
         * 
         */
        private int PORT_NO = 870; // Server port.  Will be changable via configs in future.
        private bool ServerEnabled = true; // Server flag.
        private void ClientListener()
        {
            // Listen at all IPs and specified port.
            TcpListener listener = new TcpListener(IPAddress.Any, PORT_NO);
            // While server flag rised.
            while (ServerEnabled)
            {
                listener.Start();
                // When incoming client connected try to serve him.
                TcpClient client;
                try
                {
                    // Create TCPClient object from listener.
                    client = listener.AcceptTcpClient();
                    // Start serving a client.
                    Thread threadHandleClient = new Thread(new ParameterizedThreadStart(HandleClient))
                    {
                        IsBackground = true
                    };
                    threadHandleClient.Start(client);
                }
                catch (System.Net.Sockets.SocketException)
                {
                    break;
                }
                listener.Stop();
                Thread.Sleep(10);
            }
            listener = null;
        }
        /*********************************************************************
         * Method for serving corect  clients and dropping incorect ones.
         */
        const int SUPPORTED_PROTOCOL_VERSION = 0;
        public void HandleClient(Object arg)
        {
            Client_Class temp = new Client_Class
            {
                CLIENT = (TcpClient)arg
            };
            {
                // Get the incoming client info through a network stream.
                NetworkStream nwStream = temp.CLIENT.GetStream();
                try
                {
                    StreamReader streamReader = new StreamReader(nwStream);
                    {
                        String ProtocolNameVersion = streamReader.ReadLine();
                        if (!ProtocolNameVersion.StartsWith("MOL:"))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        if (!int.TryParse(ProtocolNameVersion.Substring(4), out int ProtocolVersion))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        if (SUPPORTED_PROTOCOL_VERSION > ProtocolVersion)
                        {
                            //TODO: Disable unsupported features for this client
                        }
                    }
                    {
                        String ASKline = streamReader.ReadLine();
                        if (!ASKline.StartsWith("ASK:"))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        if (ASKline.Substring(4) != "connect")
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                    }
                    {
                        String NAMEline = streamReader.ReadLine();
                        if (!(NAMEline.StartsWith("NAME:") || NAMEline.Length > 5))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        temp.Name = NAMEline.Substring(5);
                    }
                    {
                        String OSline = streamReader.ReadLine();
                        if (!OSline.StartsWith("OS:"))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        temp.OS = OSline.Substring(3);
                    }
                    {
                        if (streamReader.Peek() >= 0)
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    temp.CLIENT.Close();
                    return;
                }
                catch (System.IO.IOException)
                {
                    temp.CLIENT.Close();
                    return;
                }
                // Get the incoming client's IP.
                temp.IP = temp.CLIENT.Client.RemoteEndPoint.ToString();
                string ServerConnectResponse = "MOL:0\n" +
                                               "STAT:ok\n";
                byte[] buffer = Encoding.UTF8.GetBytes(ServerConnectResponse);
                nwStream.Write(buffer, 0, ServerConnectResponse.Length);
                // Add client to ListPC (this will add new element to dataGridViewClients).

                if (temp.CLIENT.Client.Poll(1, SelectMode.SelectRead))
                {
                    temp.CLIENT.Close();
                    return;
                }

                int index = listPC.Count();
                Invoke((MethodInvoker)(() => listPC.Add(temp)));
                Thread threadListenClientStream = new Thread(new ParameterizedThreadStart(ListenClientStream))
                {
                    IsBackground = true
                };
                //threadListenClientStream.Start(index);
                threadListenClientStream.Start(temp);
            }
        }
        public void ListenClientStream(Object arg)
        {

            //Client_Class singleClient = listPC[(int)arg];
            Client_Class singleClient = (Client_Class)arg;
            while (true)
            {
                byte[] buffer;
                int bytesRead;
                try
                {
                    if (singleClient.CLIENT.Client.Poll(1, SelectMode.SelectRead))
                    {
                        singleClient.CLIENT.Close();
                        Invoke((MethodInvoker)(() => listPC.Remove(singleClient)));
                        Invoke((MethodInvoker)(() => dataGridViewClients.Refresh()));
                        return;
                    }
                    // Get the incoming data through a network stream.
                    NetworkStream nwStream = singleClient.CLIENT.GetStream();
                    buffer = new byte[singleClient.CLIENT.ReceiveBufferSize];
                    // Try to read incoming stream.
                    bytesRead = nwStream.Read(buffer, 0, singleClient.CLIENT.ReceiveBufferSize);
                    if (bytesRead < 1)
                    {
                        singleClient.CLIENT.Close();
                        Invoke((MethodInvoker)(() => listPC.Remove(singleClient)));
                        Invoke((MethodInvoker)(() => dataGridViewClients.Refresh()));
                        return;
                    }
                    else
                    {
                        nwStream.Write(new byte[0], 0, 0);
                        StreamReader streamReader = new StreamReader(nwStream);
                        {
                            String ProtocolNameVersion = streamReader.ReadLine();
                            if (ProtocolNameVersion.StartsWith("MOL:") && int.TryParse(ProtocolNameVersion.Substring(4), out int ProtocolVersion))
                            {
                                String ASKline = streamReader.ReadLine();
                                if (ASKline.StartsWith("ASK:"))
                                    if (ASKline.Substring(4) == "disconnect")
                                    {
                                        nwStream.Close();
                                        singleClient.CLIENT.Close();
                                        Invoke((MethodInvoker)(() => listPC.Remove(singleClient)));
                                        Invoke((MethodInvoker)(() => dataGridViewClients.Refresh()));
                                        return;
                                    }
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    // In case of failure stop thread.
                    singleClient.CLIENT.Close();
                    Invoke((MethodInvoker)(() => listPC.Remove(singleClient)));
                    Invoke((MethodInvoker)(() => dataGridViewClients.Refresh()));
                    return;
                }
                catch (System.ObjectDisposedException)
                {
                    // In case of failure stop thread.
                    singleClient.CLIENT.Close();
                    Invoke((MethodInvoker)(() => listPC.Remove(singleClient)));
                    Invoke((MethodInvoker)(() => dataGridViewClients.Refresh()));
                    return;
                }
                // Convert the data received into a string.
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Invoke((MethodInvoker)(() => richTextBox1.Text = dataReceived));
            }
        }
        /*********************************************************************
         * Methode, when button in
         * DataGridViewClients was clicked.
         */
        private void DataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs ClickedCell)
        {
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[ClickedCell.ColumnIndex] is DataGridViewButtonColumn && ClickedCell.RowIndex >= 0)
                {
                    switch (ClickedCell.ColumnIndex)
                    {
                        case 0:
                            {
                                listPC[dataGridViewClients.CurrentCell.RowIndex].Cmd("mkdir C:\\test\\");
                                break;
                            }
                        case 1:
                            {
                                listPC[dataGridViewClients.CurrentCell.RowIndex].Shutdown(true, 0);
                                break;
                            }
                    }
                }
            }
        }
        /*********************************************************************
         * Method when MainForm are closing.
         * Used to perform normal application' termination.
         */
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerEnabled = false;
            for (int i = 0; i < listPC.Count; i++)
            {
                listPC[i].CLIENT.GetStream().Close();
                listPC[i].CLIENT.Close();
            }
        }

        private void ButtonShutdownSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPC.Count; i++)
            {
                if (listPC[i].IsSelected)
                    listPC[i].Shutdown(true, 0);
            }
        }

        private void ButtonShutdownAllClients_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPC.Count; i++)
            {
                listPC[i].Shutdown(true, 0);
            }
        }
    }
}