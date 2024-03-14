//using ConsoleApp1.Dictionary_02;
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<Person> personsList = new List<Person>();

//        bool cixis = true;

//        while (cixis)
//        {
//            Console.WriteLine("1.Yuser Dahil Etmek");
//            Console.WriteLine("2.Masin Nomresini Ahtarmag");
//            Console.WriteLine("3.Yuserlere Bahmag");
//            Console.WriteLine("4.Cixis");
//            int num = int.Parse(Console.ReadLine());

//            switch (num)
//            {
//                case 1:
//                    Console.WriteLine("Masinin Nomresini dahil edin:");
//                    string carNumber = Console.ReadLine();

//                    Console.WriteLine("Adinizi Dahil edin:");
//                    string name = Console.ReadLine();

//                    Console.WriteLine("Cermenin meblegini dahil edin:");
//                    int amount = int.Parse(Console.ReadLine());

//                    Console.WriteLine("Cermenin yerini dahil edin:");
//                    string street = Console.ReadLine();

//                    var person = new Person { CarNumbers = carNumber, Name = name, Fines = new Fines { Amount = amount, Street = street } };

//                    personsList.Add(person);

//                    break;
//                case 2:
//                    Console.WriteLine("Masinin Nomresini Dahil edin Axtaris Ucun :");
//                    var per = Console.ReadLine().ToUpper();
//                    foreach (var items in personsList)
//                    {
//                        if (per == items.CarNumbers)
//                        {
//                            Console.WriteLine($"Name: {items.Name}, Car Numbers: {items.CarNumbers}, Fines: Amount: {items.Fines.Amount}, Street: {items.Fines.Street}");
//                        }
                        
//                    }
//                    break;
//                case 3:
//                    Console.WriteLine("Person:");
//                    foreach (var item in personsList)
//                    {
//                        Console.WriteLine($"Name: {item.Name}, Car Numbers: {item.CarNumbers}, Fines: Amount: {item.Fines.Amount}, Street: {item.Fines.Street}");
//                    }
//                    break;
//                case 4:
//                    cixis = false;
//                    break;
                    
//            }
//        }
//    }
//}
