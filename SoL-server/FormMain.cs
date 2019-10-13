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
        public FormMain()
        {
            InitializeComponent();
        }
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
            ClientListenerThread = new Thread(new ThreadStart(ClientListener));
            ClientListenerThread.Start();
        }
        /*********************************************************************
         * 
         */
        private int PORT_NO = 870; // Server port.  Will be changable via configs in future.
        private TcpListener listener; // Listener object.
        private bool ServerEnabled = true; // Server flag.
        private void ClientListener()
        {
            // Listen at all IPs and specified port.
            listener = new TcpListener(IPAddress.Any, PORT_NO);
            listener.Start();
            // While server flag rised.
            while (ServerEnabled)
            {
                // When incoming client connected try to serve him.
                TcpClient client;
                try
                {
                    // Create TCPClient object from listener.
                    client = listener.AcceptTcpClient();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    break;
                }
                // Start serving a client.
                Thread threadHandleClient = new Thread(new ParameterizedThreadStart(HandleClient));
                threadHandleClient.IsBackground = true;
                threadHandleClient.Start(client);
            }
        }
        /*********************************************************************
         * Method for addint elements in ListPC
         * from another threads.
         */
        void addElement(Client_Class value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Client_Class>(addElement), new object[] { value });
                return;
            }
            listPC.Add(value);
        }
        /*********************************************************************
         * Method for serving clients.
         */
        const int SUPPORTEDPROTOCOLVERSION = 0;
        public void HandleClient(Object arg)
        {
            Client_Class temp = new Client_Class();
            temp.CLIENT = (TcpClient)arg;
            {
                // Get the incoming client info through a network stream.
                NetworkStream nwStream = temp.CLIENT.GetStream();
                StreamReader streamReader = new StreamReader(nwStream);
                try
                {
                    {
                        String ProtocolNameVersion = streamReader.ReadLine();
                        int ProtocolVersion;
                        if (!ProtocolNameVersion.StartsWith("MOL:"))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        if (!int.TryParse(ProtocolNameVersion.Substring(4), out ProtocolVersion))
                        {
                            nwStream.Close();
                            temp.CLIENT.Close();
                            return;
                        }
                        if (SUPPORTEDPROTOCOLVERSION > ProtocolVersion)
                        {
                            // Disable unsupported features for this client
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

                // Get the incoming client's IP.
                temp.IP = temp.CLIENT.Client.RemoteEndPoint.ToString();

                string ServerConnectResponse = "MOL:0\n" + "STAT:ok\n";
                byte[] buffer = Encoding.UTF8.GetBytes(ServerConnectResponse);
                nwStream.Write(buffer, 0, ServerConnectResponse.Length);
                // Add client to ListPC (this will add new element to dataGridViewClients).
                addElement(temp);
            }
            // Since this code expected to be run in separate thread define client's number
            // in ListPC and rise connected flag.
            int index = listPC.Count() - 1;
            bool Connected = true;
            while (Connected)
            {
                // Get the incoming data through a network stream.
                NetworkStream nwStream = listPC[index].CLIENT.GetStream();
                byte[] buffer = new byte[listPC[index].CLIENT.ReceiveBufferSize];
                // Try to read incoming stream.
                int bytesRead;
                try
                {
                    bytesRead = nwStream.Read(buffer, 0, listPC[index].CLIENT.ReceiveBufferSize);
                }
                catch (System.IO.IOException)
                {
                    // In case of failure change connected status.
                    Connected = false;
                    return;
                }
                // Convert the data received into a string.
                //TODO This method puts received data in name field.
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listPC[index].Name = dataReceived;
                dataGridViewClients.Invoke((MethodInvoker)delegate
                {
                    dataGridViewClients.Refresh();
                });
                // Send back received data to the client.
                nwStream.Write(buffer, 0, bytesRead);
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
                        case 1:
                            {
                                string textToSend = "MOL:0\n" +
                                                    "ACT:cmd\n" +
                                                    "OPT:" + "mkdir C:\\test\n";
                                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                                NetworkStream nwStream = listPC[dataGridViewClients.CurrentCell.RowIndex].CLIENT.GetStream();
                                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                                break;
                            }
                        case 2:
                            {
                                string textToSend = "MOL:0\n" +
                                                    "ACT:shutdown\n" +
                                                    "OPT:" + "force=y," + "timer=0\n";
                                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                                NetworkStream nwStream = listPC[dataGridViewClients.CurrentCell.RowIndex].CLIENT.GetStream();
                                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
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
            listener.Stop();
            for (int i = 0; i < listPC.Count; i++)
            {
                listPC[i].CLIENT.GetStream().Close();
                listPC[i].CLIENT.Close();
            }
        }

        private void buttonShutdownSelected_Click(object sender, EventArgs e)
        {

        }
    }
}