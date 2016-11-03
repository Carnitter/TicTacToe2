using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
           public class Server
        {
            public TcpListener m_Socket;
            private TcpClient m_Client;
            private Stream stream;
            int count = 0;
            public Server()
            {
                Thread acceptClients = new Thread(new ThreadStart(acceptConnections));
                acceptClients.Start();
            }

            private void acceptConnections()
            {
                try
                {
                    IPAddress ipConfig = IPAddress.Parse("127.0.0.1");
                    //IPAddress ipConfig = IPAddress.Parse("145.102.70.175");
                    m_Socket = new TcpListener(ipConfig, 8001);
                    m_Socket.Start();
                    while (true)
                    {
                        m_Client = m_Socket.AcceptTcpClient();
                        stream = m_Client.GetStream();
                        sendData("xxaxaxa");
                        sendData(new Play());
                    }
                }
                catch (Exception error)
                {
                error.ToString();
                }
            }

        public void sendData(object data)
        {
            var formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public object receiveData()
        {
            var formatter = new BinaryFormatter();
            try
            {
                var o = formatter.Deserialize(stream);
                Console.WriteLine(o);
                return o;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public String readTextMessage(TcpClient client)
        {
            StreamReader streamR = new StreamReader(client.GetStream(), Encoding.ASCII);
            String line = streamR.ReadLine();
            return line;
        }

        public void writeTextMessage(TcpClient client, string message)
        {
            StreamWriter streamW = new StreamWriter(client.GetStream(), Encoding.ASCII);
            streamW.WriteLine(message);
            streamW.Flush();
        }

    }

}


/* public void updInfo(String textLog)
         {
             if (InvokeRequired)
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

         }*/


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
