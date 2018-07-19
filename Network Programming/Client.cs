using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;


namespace Client
{
    class Client
    {
        public static void ConnectToServer()
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting.....");
            IPAddress ipAdd = IPAddress.Parse("127.0.0.1");

            tcpclnt.Connect(ipAdd, 8001);
            Console.WriteLine("Connected");
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
        static void Main(string[] args)
        {
            ConnectToServer();
            Console.Read();
        }
    }
}
