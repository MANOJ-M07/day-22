using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SimpleLib;

namespace XMLSerilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Id = 1,
                Name = "Kholi",
                PlayerType = "Bates Man",
                Team = "India"
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            using (TextWriter writer = new StreamWriter("D:\\simplilearn\\day-22\\Player.xml"))
            {
                serializer.Serialize(writer, player);
            }
            Console.WriteLine("***Done***");
            Console.ReadKey();
        }
    }
}
