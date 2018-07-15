using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class StreamReaderEx1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            sr.Close();
            fs.Close();
            Console.Read();
        }
    }
}
