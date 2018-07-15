using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class TextWriterEx
    {
        static void Main(string[] args)
        {
            string fileName = "F:\\Bizruntime\\Workspace\\File IO\\f3.txt";
            TextWriter tw = File.CreateText(fileName);
            tw.WriteLine("hello to all");
            tw.WriteLine("hello guys");
            tw.Write("welcome to virtual world");
            tw.Flush();
            tw.Close();
            Console.WriteLine("Data write successfully.");
            Console.Read();
        }
    }
}
