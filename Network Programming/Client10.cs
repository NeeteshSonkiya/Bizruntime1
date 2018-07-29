using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client10
    {

        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Console.Write("Enter IP address : ");
            IPEndPoint iPe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            Console.Write("Enter your name : ");
            string str = Console.ReadLine();
            try
            {
                socket.Connect(iPe);
                Parallel.Invoke(() => RecieveFromServer(socket), () => send(socket, str));
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection are not established...");
            }


        }
        public static void send(Socket socket, string str)
        {
            byte[] data = Encoding.ASCII.GetBytes(str);
            socket.Send(data);
            byte[] bt = new byte[255];

           
            while (true)
            {
                string s1 = str + (" : " + Console.ReadLine());
                byte[] br = Encoding.ASCII.GetBytes(s1);
                socket.Send(br);
            }
        }
        public static void RecieveFromServer(Socket socket)
        {
            byte[] buffer = new byte[socket.SendBufferSize];
            while (true)
            {
                int length = socket.Receive(buffer);
                byte[] br1 = new byte[length];
                Array.Copy(buffer, br1, length);
                Console.WriteLine("Server : " + Encoding.ASCII.GetString(br1));
            }

        }
    }
}