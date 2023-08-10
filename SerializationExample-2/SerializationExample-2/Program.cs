using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace SerializationExample_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person()
            {
                Name = "Sam", Contact = "9940403441", Age = 32
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D://person.bin", FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
            Console.WriteLine("File created onject is serilized");
            Console.ReadKey();

        }
    }
}
