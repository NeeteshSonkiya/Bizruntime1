using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server4
    {
        static Byte[] Buffer { get; set; }
        static Socket sck;
        static Socket accepted;

        static void Connection()
        {
            Console.WriteLine("--*--Server--*--");
            Console.WriteLine();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 1234);
            sck.Bind(ep);

            sck.Listen(100);
            Console.WriteLine("The Server is running at port 1234");
            Console.WriteLine("Waiting for connection......");

            accepted = sck.Accept();
            Console.WriteLine("Connection accepted from " + accepted.RemoteEndPoint);

            byte[] con = Encoding.Default.GetBytes("Connection Successfull");
            accepted.Send(con, 0, con.Length, 0);

        }
        static void Operation()
        {
            String str1 = "", str2 = "";
            while (!str1.Equals("stop"))
            {
                Buffer = new byte[accepted.SendBufferSize];
                int length = accepted.Receive(Buffer);
                Byte[] formatted = new Byte[length];
                for (int i = 0; i < length; i++)
                {
                    formatted[i] = Buffer[i];
                }

                str1 = Encoding.Default.GetString(formatted);
                Console.WriteLine("Client : " + str1);

                Console.WriteLine("Enter Text : ");
                str2 = Console.ReadLine();
                Byte[] buf = Encoding.Default.GetBytes(str2);
                accepted.Send(buf, 0, buf.Length, 0);
                Console.WriteLine("Send Successfull");
            }
        }
        static void Main(string[] args)
        {
            Connection();
            Operation();
            Console.ReadKey();
            sck.Close();
            accepted.Close();
        }
    }
}
