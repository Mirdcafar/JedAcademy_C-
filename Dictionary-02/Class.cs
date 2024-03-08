using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dictionary_02
{

    class Person
    {
        public string CarNumbers { get; set; }
        public string Name { get; set; }
        public Fines Fines { get; set; }
    }

    class Fines
    {
        public int Amount { get; set; }
        public string Street { get; set; }
    }

}
