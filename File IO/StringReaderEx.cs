using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class StringReaderEx
    {
        static void Main(string[] args)
        {
            StringWriter sw = new StringWriter();
            sw.Write("goodmorning guys.. welcome to indida");
            sw.Close();
            StringReader sr = new StringReader(sw.ToString());
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
