using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Server2
    {
        static byte[] buffer;
        static Socket socket;

        static void Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            socket.Bind(ipep);
            Console.WriteLine("Server started");
            socket.Listen(1000);
            Console.WriteLine("Waiting for client...");

            Socket accepted = socket.Accept();
            Console.WriteLine("Connection eshtablished from  :: " + accepted.RemoteEndPoint);

            byte[] con = Encoding.Default.GetBytes("Connection Successfull");
            accepted.Send(con, 0, con.Length, 0);

            buffer = new byte[accepted.SendBufferSize];
            int byteRead = accepted.Receive(buffer);

            byte[] formatted = new byte[byteRead];
            for (int i = 0; i < byteRead; i++)
            {
                formatted[i] = buffer[i];
            }
            string str = Encoding.ASCII.GetString(formatted);
            Console.WriteLine(str);
            byte[] rcv = Encoding.ASCII.GetBytes("Message Recieve");

            accepted.Send(rcv, 0, rcv.Length, 0);
            socket.Close();
            accepted.Close();
        }
        static void Main(string[] args)
        {
            //creating a socket instance.
            Server();
            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}