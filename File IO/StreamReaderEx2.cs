using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class StreamReaderEx2
    {
        static void Main(string[] args)
        {
            string fileName = "F:\\Bizruntime\\Workspace\\File IO\\f4.txt";
            StreamReader sr = new StreamReader(fileName);
            string data = "";
            while ((data = sr.ReadLine()) != null)
            {
                Console.WriteLine(data);
            }
            Console.Read();
        }
    }
}
