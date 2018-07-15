using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class BinaryWriterEx
    {
        static void Main(string[] args)
        {
            String fName = "F:\\Bizruntime\\Workspace\\File IO\\f4.txt";
            BinaryWriter bw = new BinaryWriter(File.Open(fName, FileMode.OpenOrCreate));
            bw.Write(12.5);
            bw.Write("hello guys how r u ..?");
            bw.Write(true);
            bw.Flush();
            bw.Close();
            Console.Read();
        }
    }
}
