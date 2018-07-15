using System;
using System.IO;

namespace File_IO
{
    class FileEx1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\f1.txt", FileMode.OpenOrCreate);
            //for (int i = 65; i < 90; i++)
            //{
            //    fs.WriteByte((byte)i);
            //}
            //fs.Close();
            int i = 0;
            
            for (i = 0; (i = fs.ReadByte()) != -1; )
            {
                Console.WriteLine((char)i);
            }
            Console.Read();
        }
    }
}
