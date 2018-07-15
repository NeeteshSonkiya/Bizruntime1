using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileEx5
    {
        static void Main(string[] args)
        {
           string loc = "F:\\Bizruntime\\Workspace\\File IO\\mydata.txt";
           if (File.Exists(loc))
           {
                File.Delete(loc);
                Console.WriteLine("File deleted successfully ");
           }
           else
           {
                Console.WriteLine("File not Found ");
           }
            Console.Read();
        }
    }
}
