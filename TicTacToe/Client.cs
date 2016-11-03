using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Client
    {
        private Stream stream;

        public delegate void infoUpdater(string text);

        //public MessagesUpdated MessageNotifier;
        public Client()
        {
            Thread findServer = new Thread(new ThreadStart(lookForConnection));
            findServer.Start();
        }

        public void lookForConnection()
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");


                //localhost
                //tcpclnt.Connect("127.0.0.1", 8001);
                //justin IP
                tcpclnt.Connect("145.102.70.175", 8001);
                //jairo IP
                //tcpclnt.Connect("145.48.119.239", 8001);
                stream = tcpclnt.GetStream();
                Console.WriteLine("Connected");
                // use the ipaddress as in the server program

                String str = Console.ReadLine();
                
                while (true)
                {                    
                    if (tcpclnt.Connected)
                    {
                        receiveData();
                    }
                    
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
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
                if(o is Play)
                {
                    Play p = (Play)o;
                    return o.ToString();
                }
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
