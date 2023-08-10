using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SimpleLib;

namespace XMLDeSerilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            using (TextReader reader = new StreamReader("D:\\simplilearn\\day-22\\player.xml"))
            {
                Player deserializedPerson = (Player)serializer.Deserialize(reader);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Id: {deserializedPerson.Id}");
                Console.WriteLine($"Type of Player: {deserializedPerson.PlayerType}, Team: {deserializedPerson.Team}");

            }
            Console.ReadKey();
        }
    }
}
