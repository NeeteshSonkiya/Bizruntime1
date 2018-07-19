using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class Server7
    {
        static TcpListener tcpListener = new TcpListener(8989);
        static void Listeners()
        {
            Socket socketFClient = tcpListener.AcceptSocket();
            if (socketFClient.Connected)
            {
                Console.WriteLine("Client : " + socketFClient.RemoteEndPoint + " now connected to the server");
                NetworkStream nStream = new NetworkStream(socketFClient);
                StreamWriter sWriter = new StreamWriter(nStream);
                StreamReader sReader = new StreamReader(nStream);

                while (true)
                {
                    string theString = sReader.ReadLine();
                    Console.WriteLine("Message recieved by client " + theString);
                    if (theString == "exit")
                    {
                        break;
                    }
                }
                sReader.Close();
                sWriter.Close();
                nStream.Close();
                socketFClient.Close();
                Console.WriteLine("Press any key to exit from server");
                Console.ReadKey();
            }
        }
        public static void Main(string[] args)
        {
            tcpListener.Start();
            Console.WriteLine("This is Server program ");
            Console.WriteLine("How many clients are going to connected");
            int numberOfClient = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfClient; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
        }
    }
}
