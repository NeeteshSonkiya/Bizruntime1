using log4net.Config;
using System;
using System.IO;
using System.Xml.Serialization;


namespace log4netAndNunitTest
{

    public class StudentRecord
    {


       // [XmlIgnore]
       
        public string SName { get; set; }

       
        public string Add { get; set; }

    }


  
    public class XmlDocumentation
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(XmlDocumentation));
       
        public void CallSerialization(StudentRecord sObject)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentRecord));
            TextWriter writer = new StreamWriter(@"StudentRecord.xml");
            xmlSerializer.Serialize(writer, sObject);
            Console.WriteLine("Serilization Successful");
            writer.Close();

        }

       
        public StudentRecord CallDeSerialization()
        {
            BasicConfigurator.Configure();
            StreamReader file = null;
            StudentRecord obj;
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(StudentRecord));
                file = new StreamReader(@"StudentRecord.xml");
                obj = (StudentRecord)reader.Deserialize(file);
                return obj;
            }
            catch (FileNotFoundException ex)
            {
                log.Error(ex.Message);
                return null;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

      
        public void GetData(out StudentRecord sObject)
        {
            sObject = new StudentRecord();
            Console.WriteLine("Enter Student Record : ");
            Console.Write("Student Name    : ");
            sObject.SName = Console.ReadLine();
            Console.Write("Address         : ");
            sObject.Add = Console.ReadLine();
        }

      
        public void DisplayData(StudentRecord obj)
        {
            Console.WriteLine("Student Record After Deserilization:");
            Console.WriteLine("Name : " + obj.SName);
            Console.WriteLine("Address : " + obj.Add);
        }



    
        static void Main(string[] args)
        {
            XmlDocumentation xmlSer = new XmlDocumentation();
            StudentRecord serobj;
            xmlSer.GetData(out serobj);
            xmlSer.CallSerialization(serobj);
            StudentRecord deserobj = xmlSer.CallDeSerialization();
            xmlSer.DisplayData(deserobj);
            Console.Read();


        }
    }

}
