using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileEx3
    {
        static void Main(string[] args)
        {
            string data;
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f2.txt", FileMode.Open, FileAccess.ReadWrite);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.Write("hello to all");
            sw.WriteAsync("hello mitsian");
            using (StreamReader sr = new StreamReader(fs)) 
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            sw.Close();
            fs.Close();            
            Console.Read();
        }
    }
}
