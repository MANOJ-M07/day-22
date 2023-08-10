/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using PersonLib;


namespace DeserilizationExamle
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D://person.bin", FileMode.Open))
            {
                Person dsPerson = (Person)formatter.Deserialize(fs);
                Console.WriteLine("Serializable object is :" + dsPerson.Name + "\nAge :" + dsPerson.Age + "\nContact :" + dsPerson.Contact);
            }

            Console.ReadKey();
        }
    }
    
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Assignment24;
using System.Xml.Serialization;

namespace Assignment24
{
    [Serializable]
    public class Employee
    {

        public int Id;
        public string FirstName;
        public string LastName;
        public double Salary;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 12,
                FirstName = "Aishu",
                LastName = "Divi",
                Salary = 90000
            };
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\simplilearn\\day-22\\Employee.bin", FileMode.Open);

            formatter.Serialize(stream, employee);
            stream.Close();


            stream = new FileStream("D:\\simplilearn\\day-22\\Employee.bin", FileMode.Open);
            Employee objnew = (Employee)formatter.Deserialize(stream);

            Console.WriteLine(objnew.Id);
            Console.WriteLine(objnew.FirstName);
            Console.WriteLine(objnew.LastName);
            Console.WriteLine(objnew.Salary);


            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("D:\\Training\\day21\\Assignment24\\employee.xml"))
            {
                serializer.Serialize(writer, employee);

            }
            Console.WriteLine("***Done***");


            BinaryFormatter format = new BinaryFormatter();

            using (FileStream fs = new FileStream("D:\\Training\\day21\\Assignment24\\Employee.bin", FileMode.Open))
            {
                Employee dp = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("Id : " + dp.Id);
                Console.WriteLine("First Name : " + dp.FirstName);
                Console.WriteLine("LastName : " + dp.LastName);
                Console.WriteLine("Salary : " + dp.Salary);


            }
            Console.ReadKey();

        }

    }
}