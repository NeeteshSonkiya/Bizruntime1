using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server5
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endP = new IPEndPoint(IPAddress.Any, 9090);
            sck.Bind(endP);
            sck.Listen(12);
            Console.WriteLine("Waiting for connection....");
            Socket acc = sck.Accept();
            Console.WriteLine("Connection Successfull");
            byte[] buffer = new byte[acc.SendBufferSize];
            int length;
            do
            {
                length = acc.Receive(buffer);
                byte[] formt = new byte[length];
                Array.Copy(buffer, formt, length);
                Console.WriteLine("We recieve : " + Encoding.ASCII.GetString(formt));
            } while (length > 0);
            Console.WriteLine("Connection disconnected");
            Console.ReadKey();

        }
    }
}
