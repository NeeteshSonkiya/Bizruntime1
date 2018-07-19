using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client4
    {
        static Socket socket;
        static string ip;
        static int port;

        static void GetData()
        {
            Console.WriteLine("--*--Client--*--");
            Console.WriteLine();
            Console.WriteLine("Enter Ip address");
            ip = Console.ReadLine();
            Console.WriteLine("Enter Port number ");
            port = int.Parse(Console.ReadLine());
        }
        static void Connection()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            try
            {
                socket.Connect(ep);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connetion is not established.");
            }
        }
        static void Operation()
        {
            Byte[] brr = new byte[255];
            int l = socket.Receive(brr, 0, brr.Length, 0);
            Array.Resize(ref brr, l);
            Console.WriteLine(Encoding.Default.GetString(brr));

            String str1 = "", str2 = "";
            while (!str1.Equals("stop"))
            {
                Console.WriteLine("Enter message : ");
                str1 = Console.ReadLine();
                Byte[] data1 = Encoding.ASCII.GetBytes(str1);
                socket.Send(data1);
                Console.WriteLine("Send Successful");

                int r = socket.Receive(brr, 0, brr.Length, 0);
                Array.Resize(ref brr, r);
                str2 = Encoding.Default.GetString(brr);
                Console.WriteLine("Server Says : " + str2);
            }
        }
        static void Main(string[] args)
        {
            GetData();
            Connection();
            Operation();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            socket.Close();
        }
    }
}
