using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileInfoEx1
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "F:\\Bizruntime\\Workspace\\File IO\\fileInfo.txt";
                FileInfo fl = new FileInfo(str);
                //fl.Create();
                StreamWriter sw = fl.CreateText();
                sw.WriteLine("welcome to india guys");
                sw.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("File created successfully ");
            Console.Read();
        }
    }
}
