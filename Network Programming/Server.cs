using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;

namespace Server
{
    class Server
    {
        public static void ServerUp()
        {
           // IPAddress ipAdd = IPAddress.Parse("127.0.0.1");
            TcpListener myListener = new TcpListener(IPAddress.Any, 8001);
            myListener.Start();
            Console.WriteLine("The server running at port: " + myListener.LocalEndpoint);
       
        }
        static void Main(string[] args)
        {
            ServerUp();
            Console.Read();
        }
    }
}
