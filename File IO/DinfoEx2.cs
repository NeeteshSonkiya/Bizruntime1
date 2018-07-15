using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class DinfoEx2
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("F:\\Bizruntime\\Workspace\\File IO\\Directory");
            if (dir.Exists)
            {
                dir.Delete();
                Console.WriteLine("dir deleted sucessfully..");
            }
            else
            {
                Console.WriteLine("Directory not found ..");
            }
            Console.Read();
        }
    }
}
