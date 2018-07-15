using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class StringWriterEx
    {
        static void Main(string[] args)
        {
            //  FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\hello.txt", FileMode.Open, FileAccess.ReadWrite);
            string str = "hello to all " +
                        "welcome to india ";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.Write(" welcome to bangalore ");
            sw.Write(str);
            sw.Close();
            StringReader sr = new StringReader(sb.ToString());
            while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.Read();
        }
    }
}
