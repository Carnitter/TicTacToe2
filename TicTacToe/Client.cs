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
        public TcpClient tcpclnt;
        public delegate void infoUpdater(string text);
        public delegate void receivedData(List<Play> plays);
        public receivedData receiver;
        public delegate void chatData(String chat);
        public chatData chatReceiver;
        public String name;

        //public MessagesUpdated MessageNotifier;
        public Client(String name)
        {
            this.name = name;
            Thread findServer = new Thread(new ThreadStart(lookForConnection));
            findServer.Start();
        }

        public void lookForConnection()
        {
            try
            {
                tcpclnt = new TcpClient();
                //localhost
                //tcpclnt.Connect("127.0.0.1", 8001);
                //thuis PC
                tcpclnt.Connect("192.168.1.35", 8001);
                //justin IP
                //tcpclnt.Connect("145.102.70.175", 8001);
                //jairo IP
                //tcpclnt.Connect("145.48.119.239", 8001);
                stream = tcpclnt.GetStream();


                // use the ipaddress as in the server program

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
                String oString;
                if (data is String)
                {
                    oString = (String)data;
                    oString = $"{name}: {oString}";
                    chatReceiver.Invoke(oString);
                    formatter.Serialize(stream, oString);
                }else
                {
                    formatter.Serialize(stream, data);
                }
                
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
                if(o is Play)
                {
                    Play p = (Play)o;
                    return o.ToString();
                }
                if(o is List<Play>)
                {
                    List<Play> pl = (List<Play>)o;
                    receiver.Invoke(pl);
                    return pl;
                }
                if (o is String)
                {
                    String oString = (String)o;
                    chatReceiver.Invoke(oString);
                    return oString;
                }
                return o;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
