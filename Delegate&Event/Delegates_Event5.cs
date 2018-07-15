using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelegatesAndEvents
{
    public class MyClass
    {
        public delegate void LogHandler(string message);
        public event LogHandler Log;

        public void Process()
        {
            OnLog("Process() begin");
            OnLog("Process() end");
        }
        
        public void OnLog(string message)
        {
            if (Log != null)
            {
                Log(message);
            }
        }
    }

    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }

    public class Delegates_Event5
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger(@"F:\Bizruntime\Workspace\Delegates & Events\myFile.log");
            MyClass myClass = new MyClass();

            myClass.Log += new MyClass.LogHandler(Logger);
            myClass.Log += new MyClass.LogHandler(fl.Logger);

            myClass.Process();

            fl.Close();
            Console.Read();
        }
    }
}
