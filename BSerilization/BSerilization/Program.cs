using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SimpleLib;


namespace BSerilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Enter Player id");
            player.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            player.Name = Console.ReadLine();
            Console.WriteLine("Enter player type");
            player.PlayerType = Console.ReadLine();
            Console.WriteLine("Enter player team");
            player.Team = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\simplilearn\\day-22\\Players.bin", FileMode.Create))
            {
                formatter.Serialize(fs, player);
            }
            Console.WriteLine("Created & Serilized");
            Console.ReadKey();

        }
    }
}
