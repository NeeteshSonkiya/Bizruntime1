using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server10
    {
        static string name;
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Any, 9090);
            socket.Bind(iPEnd);
            socket.Listen(10);
            Console.WriteLine("Welcome to Chat Server");
            Dictionary<string, Socket> buffers = new Dictionary<string, Socket>();

            while (true)
            {
                Socket acc = socket.Accept();


                byte[] bt = new byte[255];
                int l = acc.Receive(bt, 0, bt.Length, 0);
                Array.Resize(ref bt, l);
                name = Encoding.Default.GetString(bt);
                Console.Write(Encoding.Default.GetString(bt) + " : ");
                Console.WriteLine("Connected...");

                byte[] con = Encoding.Default.GetBytes("Connection Successfull");
                acc.Send(con, 0, con.Length, 0);
                byte[] buffer = new byte[acc.SendBufferSize];
                buffers.Add(name, acc);

                Task t1 = new Task(() => SendToClient(buffers));
                t1.Start();
                Task t2 = new Task(() => RecieveFromClient(acc, buffer));
                t2.Start();
            }
        }
        public static void RecieveFromClient(Socket acc, byte[] buffer)
        {
            string str = "";
            int length;
            do
            {
                length = acc.Receive(buffer);
                byte[] br = new byte[length];
                Array.Copy(buffer, br, length);
                str = Encoding.ASCII.GetString(br);
                Console.WriteLine(str);


            } while (length > 0);
        }
        public static void SendToClient(Dictionary<string, Socket> buffers)
        {
            Console.Write("Enter the client Name : ");
            string str1 = Console.ReadLine();
            if (str1.ToUpper().Equals("ALL"))
            {
                string s1 = Console.ReadLine();
                while (!s1.ToUpper().Equals("STOP"))
                {
                    foreach (KeyValuePair<string, Socket> kvp in buffers)
                    {
                        Socket socket = kvp.Value;
                        byte[] sendData = Encoding.ASCII.GetBytes(s1);
                        socket.Send(sendData);
                    }
                    s1 = Console.ReadLine();
                }
            }
            else
            {
                string s1 = Console.ReadLine();
                while (!s1.ToUpper().Equals("STOP"))
                {
                    foreach (KeyValuePair<string, Socket> kvp in buffers)
                    {
                        Socket socket = kvp.Value;
                        string client = kvp.Key;
                        if (str1.Equals(client))
                        {
                            byte[] sendData = Encoding.ASCII.GetBytes(s1);
                            socket.Send(sendData);
                        }
                    }
                    s1 = Console.ReadLine();
                }
            }
            //while (true)
            //{
            //    string s1 = Console.ReadLine();

            //    foreach (KeyValuePair<string, Socket> kvp in buffers)
            //    {
            //        Socket socket = kvp.Value;
            //        byte[] sendData = Encoding.ASCII.GetBytes(s1);
            //        socket.Send(sendData);
            //    }
            //}
        }
    }
}