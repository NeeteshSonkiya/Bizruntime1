using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Client5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Ip Address : ");
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endP = new IPEndPoint(IPAddress.Parse(Console.ReadLine()), 9090);
            sck.Connect(endP);
            string str = "";
            do
            {
                Console.WriteLine("Enter Text : ");
                str = Console.ReadLine();
                byte[] br = Encoding.ASCII.GetBytes(str);
                sck.Send(br);
                Console.WriteLine("Data sent");
            } while (!str.Equals("stop"));
            Console.WriteLine("Press enter key to exit");
            sck.Close();
            Console.Read();
        }
    }
}
