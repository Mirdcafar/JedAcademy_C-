using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cars;

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }
    public int NumberOfDoors { get; set; }

    public override string ToString()
    {
        return $"Model:{Model} , Color:{Color} , Speed:{Speed} , Doors:{NumberOfDoors}";
    }
}

