using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CarList
{
    public class FileName
    {
        static void Main()
        {
            List<Class1.Car> CarList = new List<Class1.Car>
            {
                new Class1.Car { Price = 10.000,Color  = "Red", Marka = "Porshe",  Kuzov = "sedan"},
                new Class1.Car { Price = 12.000,Color  = "White", Marka = "Audi", Kuzov = "sedan" },
                new Class1.Car { Price = 15.000,Color  = "Black", Marka = "BMW", Kuzov = "sedan" }
            };

            

            Console.WriteLine("Giymetini yazin:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Reyin yazin:");
            string color = Console.ReadLine();
            Console.WriteLine("Markasin yazin:");
            string marka = Console.ReadLine();
            Console.WriteLine("Kuzovun yazin:");
            string kuzov = Console.ReadLine();

            Class1.Car car = new Class1.Car
            {
                Price = price,
                Color = color,
                Marka = marka,
                Kuzov = kuzov
            };

            CarList.Add(car);

            foreach (var item in CarList)
            {
                Console.WriteLine($"Price:{item.Price} , Color:{item.Color} , Marka:{item.Marka} , Kuzov:{item.Kuzov} ");
            }
        }
    }
}
