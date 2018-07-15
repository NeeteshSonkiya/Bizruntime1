using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
     
namespace File_IO
{
    class TextReaderEx
    {
        static void Main(string[] args)
        {
            string file = "F:\\Bizruntime\\Workspace\\File IO\\f3.txt";
            TextReader tr = File.OpenText(file);
            Console.WriteLine(tr.ReadToEnd());
            tr.Close();
            Console.Read();
        }
    }
}
