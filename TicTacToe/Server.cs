using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
           public class server
        {
            public TcpListener m_Socket;
            private TcpClient[] m_Client;
            int count = 0;

        public server()
        {


        }


        //public Form1()
            //{
            //    InitializeComponent();
            //}

            //private void btnStart_Click(object sender, EventArgs e)
            //{
            //    Thread acceptClients = new Thread(new ThreadStart(acceptConnections));
            //    acceptClients.IsBackground = true;
            //    acceptClients.Start();
            //}


            private void acceptConnections()
            {
                try
                {
                    IPAddress ipConfig = IPAddress.Parse("145.102.71.253");
                    m_Socket = new TcpListener(ipConfig, 1025);
                    m_Socket.Start();
                    updInfo("listening");

                    while (true)
                    {
                        m_Client[count] = m_Socket.AcceptTcpClient();
                         Thread thread = new Thread(HandleClientThread);
                         thread.Start(client);

                    count++;
                    }
                }
                catch (Exception error)
                {
                    updInfo(error.Message);
                }
            }

            public void updInfo(String textLog)
            {
                if (this.txtStatus.InvokeRequired)
                {
                    txtStatus.Invoke(new MethodInvoker(delegate { txtStatus.Text += textLog + "\n"; }));
                }
                else
                {
                    this.txtStatus.Text = textLog;
                }
            }

            private void sendData(TcpClient soc, String strData)
            {
                try
                {

                    if (soc.Connected && soc.Client.Poll(3000, SelectMode.SelectWrite))
                    {
                        {
                            char c = (char)0;
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(strData + c);
                            int i = soc.Client.Send(msg, 0, msg.Length, SocketFlags.None);
                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

    }





//namespace TicTacToe
//{
//    class Server
//    {
//        public Server()
//        {
//            try
//            {
//                IPAddress ipAd = IPAddress.Parse("145.102.71.253");
//                // use local m/c IP address, and 
//                // use the same in the client

//                /* Initializes the Listener */
//                TcpListener myList = new TcpListener(ipAd, 8001);

//                /* Start Listeneting at the specified port */
//                myList.Start();

//                Console.WriteLine("The server is running at port 8001...");
//                Console.WriteLine("The local End point is  :" +
//                                  myList.LocalEndpoint);
//                Console.WriteLine("Waiting for a connection.....");

//                Socket s = myList.AcceptSocket();
//                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

//                byte[] b = new byte[100];
//                int k = s.Receive(b);
//                Console.WriteLine("Recieved...");
//                for (int i = 0; i < k; i++)
//                    Console.Write(Convert.ToChar(b[i]));

//                ASCIIEncoding asen = new ASCIIEncoding();
//                s.Send(asen.GetBytes("The string was recieved by the server."));
//                Console.WriteLine("\nSent Acknowledgement");
//                /* clean up */
//                s.Close();
//                myList.Stop();

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Error..... " + e.StackTrace);
//            }
//        }
//    }
//}




static void HandleClientThread(object obj)
{
    TcpClient client = obj as TcpClient;

    bool done = false;
    while (!done)
    {
        
    }
    client.Close();
    Console.WriteLine("Connection closed");
}
