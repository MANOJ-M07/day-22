using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace EmployeeXMLSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Rohit",
                LastName = "Sharma",
                Salary = 50000.0
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            using (FileStream fileStream = new FileStream("D:\\simplilearn\\day-22\\Assignment\\employee.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, employee);
            }

            Console.WriteLine("Employee object creared");
            Console.WriteLine("***************************");

            //Xml Deserialization

            Employee xmlDeserializedEmployee;
            using (FileStream fileStream = new FileStream("D:\\simplilearn\\day-22\\Assignment\\employee.xml", FileMode.Open))
            {
                xmlDeserializedEmployee = (Employee) xmlSerializer.Deserialize(fileStream);
            }

            Console.WriteLine("XML Deserialized Employee:");
            Console.WriteLine($"ID: {xmlDeserializedEmployee.Id}");
            Console.WriteLine($"First Name: {xmlDeserializedEmployee.FirstName}");
            Console.WriteLine($"Last Name: {xmlDeserializedEmployee.LastName}");
            Console.WriteLine($"Salary: {xmlDeserializedEmployee.Salary}");
            Console.ReadKey();
        }
    }
}
