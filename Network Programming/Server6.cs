using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace Server
{
    class Server6
    {
        static int clientNo = 1;
        static Socket accp;
        static void Main(string[] args)
        {
            Console.WriteLine("..Sever..");
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ed = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2048);
            sck.Bind(ed);
            Console.WriteLine("Server is waiting..");
            

            while(true)
            {
                sck.Listen(10);

                accp = sck.Accept();

                Thread client1 = new Thread(() => Operation());
                client1.Start();
                Thread client2 = new Thread(() => Operation());
                client2.Start();
                clientNo++;
            }
        }
        static void Operation()
        {
            byte[] buffer = new byte[accp.SendBufferSize];
            int l;
            string sData = "", rData = "";
            do
            {
                l = accp.Receive(buffer);
                Array.Resize(ref buffer, l);
                rData = Encoding.Default.GetString(buffer);
                Console.WriteLine("Client {0}: {1}",Thread.CurrentThread.ManagedThreadId, rData);

                Console.WriteLine("Server : ");
                 sData = Console.ReadLine();
                byte[] sD = Encoding.Default.GetBytes(sData);
                accp.Send(sD);
            } while (!sData.Equals("stop"));
            Console.WriteLine("Client Disconnected");
            Console.ReadKey();
        }
    }
}
