using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace File_IO
{
    class FileInfoEx2
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "F:\\Bizruntime\\Workspace\\File IO\\fileInfo.txt";
                FileInfo fl = new FileInfo(loc);
                StreamWriter sw = fl.CreateText();
                sw.WriteLine(" you are in bangalore city today");
                sw.Close();
                StreamReader sr = fl.OpenText();
                string data = "";
                while((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
