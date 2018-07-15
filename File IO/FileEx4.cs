using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class FileEx4
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f1.jpg", FileMode.OpenOrCreate);
            FileStream fs1 = new FileStream("F:\\a1.jpg", FileMode.Open);
            fs1.CopyTo(fs);
            //BinaryReader br = new BinaryReader(fs);
            //var data = br.ReadByte(); ;
            //while ((data = br.ReadByte()) != -1)
            //{
            //    Console.WriteLine(data);
            //}
            
            Console.Read();
        }
    }
}
