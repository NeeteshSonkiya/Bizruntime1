using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace File_IO
{
    class StreamWriterEx1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("i m using stream writer");
            sw.WriteLine("this is file handeling ");
            sw.WriteLine(12);
            sw.Close();
            fs.Close();
            Console.WriteLine("data write successfully");
            Console.Read();
        }
    }
}
