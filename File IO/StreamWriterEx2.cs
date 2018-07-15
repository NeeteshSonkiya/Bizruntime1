using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class StreamWriterEx2
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            int a = 10;
            int b = 20;
            int result = a + b;
            sw.WriteLine("the addition of {0} and {1} is : {2}", a, b, result);
            sw.Close();
            fs.Close();
            Console.WriteLine("addtion is complete");
            Console.Read();
        }
    }
}
