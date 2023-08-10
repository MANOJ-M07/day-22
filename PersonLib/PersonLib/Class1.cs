using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }

        public string Contact { get; set; }

        public int Age { get; set; }
    }
}
