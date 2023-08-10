using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExamle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 12,
                Name = "Sam",
                Designation = "Manager"
            };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\OurExampleOne.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, employee);
            stream.Close();

            stream = new FileStream(@"D:\OurEmployeOne.txt", FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)formatter.Deserialize(stream);

            Console.WriteLine(objnew.Id);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Designation);
        }
    }
}
