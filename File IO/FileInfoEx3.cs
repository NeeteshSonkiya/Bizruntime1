using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileInfoEx3
    {
        static void Main(string[] args)
        {
            string loc = "F:\\Bizruntime\\Workspace\\File IO\\fileInfo1.txt";
            FileInfo fl = new FileInfo(loc);
            //fl.Create();
            string str = "S_id = 101 " +
                        "S_name = ansh  " +
                        "S_address = btm ";
            StreamWriter sw = fl.CreateText();
            sw.WriteLine("student detail...");
            sw.WriteLine(str);
            sw.Close();
            StreamReader sr = fl.OpenText();
            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            Console.Read();
        }
    }
}
