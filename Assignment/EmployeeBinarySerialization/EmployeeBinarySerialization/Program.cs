using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace EmployeeBinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "Virat",
                LastName = "kholi",
                Salary = 50000.0
            };

            //Binary Serialization
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fileStream = new FileStream("D:\\simplilearn\\day-22\\Assignment\\employee.bin", FileMode.Create))
            {
                bf.Serialize(fileStream, employee);
            }

            Console.WriteLine("Employee Object created");
            Console.WriteLine("*********************************");


            //Binary Deserialization
            Employee deserializedEmployee;
            using (FileStream filestream = new FileStream("D:\\simplilearn\\day-22\\Assignment\\employee.bin", FileMode.Open))
            {
                deserializedEmployee = (Employee)bf.Deserialize(filestream);
            }

            Console.WriteLine("Deserialized Employee:");
            Console.WriteLine($"ID: {deserializedEmployee.Id}");
            Console.WriteLine($"First Name: {deserializedEmployee.FirstName}");
            Console.WriteLine($"Last Name: {deserializedEmployee.LastName}");
            Console.WriteLine($"Salary: {deserializedEmployee.Salary}");
            Console.ReadKey();
        }
    }
}
