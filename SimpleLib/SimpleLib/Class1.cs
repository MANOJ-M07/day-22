using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLib
{
    [Serializable]
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PlayerType { get; set; }

        public string Team { get; set; }
    }
}
