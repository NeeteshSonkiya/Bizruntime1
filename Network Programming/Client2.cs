using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client2
    {
        static Socket socket;
        static void Main(string[] args)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            
            try
            {
                socket.Connect(ipep);
                Console.WriteLine("Connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connetion is not established.");
            }
            byte[] bt = new byte[255];
            int l = socket.Receive(bt, 0, bt.Length, 0);
            Array.Resize(ref bt, l);
            Console.WriteLine(Encoding.Default.GetString(bt));

            Console.WriteLine("Enter the msg..");
            string str = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(str);
            socket.Send(data);

            Console.WriteLine("Data sent");
            Console.WriteLine("Press Enter to exit");
            socket.Close();
            Console.Read();
        }
    }
}