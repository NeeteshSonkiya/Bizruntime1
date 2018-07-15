using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_IO
{
    class UsingBlockEx
    {
        static void Main(string[] args)
        {
         
                FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\File IO\\UsingBlock.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //using (StreamWriter sw = new StreamWriter(fs))
                //{
                //    sw.Write("DirectoryInfo class is a part of System.IO namespace. It is used to create, delete and move directory." +
                //                                  " It provides methods to perform operations related to directory and subdirectory. " +
                //                               " It is a sealed class so, we cannot inherit it.");
                //}
            string data;
                using (StreamReader sr = new StreamReader(fs))
                {
                    data = sr.ReadToEnd();
                    
                }
            Console.WriteLine(data);
            
            fs.Close();         
            Console.Read();
        }
    }
}
