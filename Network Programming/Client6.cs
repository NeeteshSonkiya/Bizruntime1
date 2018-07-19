using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Client6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..Client..");
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ed = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2048);
            Console.WriteLine("Connecting...");
            sck.Connect(ed);
            String sData = "";
            do
            {
                
                sData = Console.ReadLine();
                byte[] br = Encoding.Default.GetBytes(sData);
                sck.Send(br, 0, br.Length, 0);

                byte[] rData = new byte[1024];
                int length = sck.Receive(rData);
                Array.Resize(ref rData, length);
                string str = Encoding.Default.GetString(rData);
                Console.WriteLine("Server : " + str);
            } while (!sData.Equals("stop"));
            Console.WriteLine("Press enter to exit");
            sck.Close();
            Console.ReadKey();
        }
    }
}