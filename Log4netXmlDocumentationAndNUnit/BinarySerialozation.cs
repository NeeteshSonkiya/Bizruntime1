using log4net.Config;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace log4netAndNunitTest
{
    [Serializable]
    ///<summary>
    ///This is the Student class Witch contains some records(field and properties)
    ///Genrated Id is "T:log4netAndNunitTest.Student"
    ///</summary>
    public class Student
    {
        /// <summary>
        /// Id is a Property, used to get and set id value and return int
        /// Genrated Id is "P:log4netAndNunitTest.Student.id"
        /// </summary>
        ///<value>The Id property gets/sets the value of the integer field, _id.</value>
        public int id { get; set; }
        /// <summary>
        /// Name is a property, used to get and set name value and return string
        /// Genrated Id is "P:log4netAndNunitTest.Student.name"
        /// </summary>
        /// <value>The Name property gets/sets the value of the string field, _name.</value>
        public string name { get; set; }
        /// <summary>
        /// Address is property, used to get and set address value and return string
        /// </summary>
        /// <value>The Address property gets/sets the value of the string field, _address.</value>
        public string address { get; set; }
    }
    /// <summary>
    /// BinarySerialozation is a class which contains main method
    /// Genrated Id is "T:log4netAndNunitTest.BinarySerialozation"
    /// </summary>
    class BinarySerialozation
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BinarySerialozation));
        /// <summary>
        /// <c>callSerializable</c> is a method in <c>BinarySerialozation</c>class
        /// </summary>
        /// <example>
        /// This method perform the serialization operation
        /// <code>
        /// static void callSerializable()
        /// {
        ///     return;
        /// }
        /// </code>
        /// </example>
        /// <include file='StudentRecord.txt' path='[@name="F:\Bizruntime\Workspace\Log4netAnd Nunit-Test\log4netAndNunitTest\log4netAndNunitTest\StudentRecod.txt"]'/>
        static void callSerializable()
        {
            FileStream fs = new FileStream(@"F:\Bizruntime\Workspace\Log4netAnd Nunit-Test\log4netAndNunitTest\log4netAndNunitTest\StudentRecod.txt", FileMode.OpenOrCreate);
            Student stu = new Student() { id = 01, name = "Ansh", address = "BTM" };
            BasicConfigurator.Configure();
            S:
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, stu);
                Console.WriteLine("Serialization successful");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                goto S;
            }
            fs.Close();
        }
        /// <summary>
        /// <c>callSerializable</c> is a method in <c>BinarySerialozation</c>class
        /// </summary>
        /// <example>
        /// This method perform the deserialization operation
        /// <code>
        /// static void callDeserializable()
        /// {
        ///     return;
        /// }
        /// </code>
        /// </example>
        /// <include file='StudentRecord.txt' path='[@name="F:\Bizruntime\Workspace\Log4netAnd Nunit-Test\log4netAndNunitTest\log4netAndNunitTest\StudentRecod.txt"]'/>
        static void callDeserializable()
        {
            FileStream fs = new FileStream(@"F:\Bizruntime\Workspace\Log4netAnd Nunit-Test\log4netAndNunitTest\log4netAndNunitTest\StudentRecod.txt", FileMode.OpenOrCreate);
            BasicConfigurator.Configure();
            D:
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Student obj = (Student)formatter.Deserialize(fs);
                Console.WriteLine();
                Console.WriteLine("After Deserialization...");
                Console.WriteLine("Student Id : " + obj.id);
                Console.WriteLine("Student Name : " + obj.name);
                Console.WriteLine("Student Address : " + obj.address);
                
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
                goto D;
            }
            fs.Close();
        }
        /// <summary>
        /// <c>Main method</c> of the class<c>BinarySerialization</c>
        /// <list type="bullet">
        /// <item>
        /// <description> CallSerialization method</description>
        /// </item>
        /// <item>
        /// <description> CallDeserialization method</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            callSerializable();
            callDeserializable();
            Console.ReadKey();
        }
    }
}
