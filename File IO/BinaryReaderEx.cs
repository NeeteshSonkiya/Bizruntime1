using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class BinaryReaderEx
    {
        static void Main(string[] args)
        {
            string fname = "F:\\Bizruntime\\Workspace\\File IO\\f4.txt";
            BinaryReader br = new BinaryReader(File.Open(fname, FileMode.OpenOrCreate, FileAccess.Read));
            Console.WriteLine(br.Read());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadBoolean());
            br.Close();
            Console.Read();
        }
    }
}
