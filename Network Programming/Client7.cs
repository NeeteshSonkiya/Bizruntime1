using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
    public class Client7
    {
        static public void Main(string[] Args)
        {
            TcpClient socketFServer;
            try
            {
                socketFServer = new TcpClient("127.0.0.1", 8989);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect with server");
                return;
            }
            NetworkStream nStream = socketFServer.GetStream();
            StreamReader sReader = new StreamReader(nStream);
            StreamWriter sWriter = new StreamWriter(nStream);
            Console.WriteLine("_*_*This is cleint program *_*_");
            try
            {
                string outString;
                Console.WriteLine("type:");
                string str = Console.ReadLine();
                while (str != "exit")
                {
                    sWriter.WriteLine(str);
                    sWriter.Flush();
                    Console.WriteLine("type:");
                    str = Console.ReadLine();
                }
                if (str == "exit")
                {
                    sWriter.WriteLine(str);
                    sWriter.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            nStream.Close();
            Console.WriteLine("Press any key to exit from client");
            Console.ReadKey();
        }
        static string Getdata()
        {
            return "ack";
        }
    }
}
