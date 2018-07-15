using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class DinfoEx1
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("F:\\Bizruntime\\Workspace\\File IO\\Directory2");
            if (dir.Exists)
            {
                dir.MoveTo("F:\\Bizruntime\\Workspace\\File IO\\Directory5");
                Console.WriteLine("directory is already exists..");
            }
            else
            {
                dir.Create();
                Console.WriteLine("directory created successfully ..");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
