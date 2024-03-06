using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Dictionary
{
    public class FileName
    {
        static void Main()
        {

            Person person = new Person();
            Fines fines = new Fines();

            Console.WriteLine("Keyi dahil edin:");
            string keys = Console.ReadLine();

            Console.WriteLine("Ikinci keyi dahil edin:");
            string keys2 = Console.ReadLine();

            var keyValue = new Dictionary<string, Dictionary<string, Fines>>();

            keyValue.Add(person.Name = "Mike", new Dictionary<string, Fines>
                {
                    { person.CarNumbers = "11BB001", new Fines { Amount = 43, Street = "New York" } }
                });

            keyValue.Add(person.Name = "Denial", new Dictionary<string, Fines>
                {
                    { person.CarNumbers = "11BB002", new Fines { Amount = 34, Street = "Mosskow" } }
                });

            keyValue.Add(person.Name = "Russlan", new Dictionary<string, Fines>
                {
                    { person.CarNumbers = "11BB003", new Fines { Amount = 45, Street = "Baku" } }
                });

            keyValue.Add(person.Name = "Emil", new Dictionary<string, Fines>
                {
                    { person.CarNumbers = "11BB004", new Fines { Amount = 54, Street = "Polsa" } }
                });

            foreach (var itemKey1 in keyValue)
            {
                foreach (var itemKey2 in itemKey1.Value)
                {
                    if (keys == itemKey1.Key && keys2 == itemKey2.Key)
                    {
                        Console.WriteLine($"Name: {itemKey1.Key}, Car Numbers: {itemKey2.Key}, Fines: Amount:{itemKey2.Value.Amount}, Street: {itemKey2.Value.Street}");
                    }
                }
            }

            Console.WriteLine();

            keyValue[keys].Remove(keys2);

            foreach (var itemKey1 in keyValue)
            {
                foreach (var itemKey2 in itemKey1.Value)
                {
                    
                    
                        Console.WriteLine($"Name: {itemKey1.Key}, Car Numbers: {itemKey2.Key}, Fines: Amount:{itemKey2.Value.Amount}, Street: {itemKey2.Value.Street}");
                    
                }
            }
        }
    }
}

