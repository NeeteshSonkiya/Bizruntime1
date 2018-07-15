using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileEx2
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f2.txt", FileMode.OpenOrCreate);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.WriteLine("Welcome to My World");
            sw.Close();
            fs.Close();
            Console.Read();
        }
    }
}
