using ConsoleApp1.Dictionary_02;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Person> personsList = new List<Person>();

        bool cixis = true;

        while (cixis)
        {
            Console.WriteLine("1.Yuser Dahil Etmek");
            Console.WriteLine("2.Yuserlere Bahmag");
            Console.WriteLine("3.Cixis");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Masinin Nomresini dahil edin:");
                    string carNumber = Console.ReadLine();

                    Console.WriteLine("Adinizi Dahil edin:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Cermenin meblegini dahil edin:");
                    int amount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Cermenin yerini dahil edin:");
                    string street = Console.ReadLine();

                    var person = new Person { CarNumbers = carNumber, Name = name, Fines = new Fines { Amount = amount, Street = street } };

                    personsList.Add(person);

                    break;
                    
                case 2:
                    Console.WriteLine("Person:");
                    foreach (var p in personsList)
                    {
                        Console.WriteLine($"Name: {p.Name}, Car Numbers: {p.CarNumbers}, Fines: Amount: {p.Fines.Amount}, Street: {p.Fines.Street}");
                    }
                    break;
                case 3:
                    cixis = false;
                    break;
                    
            }
        }
    }
}
