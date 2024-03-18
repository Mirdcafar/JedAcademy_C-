using System;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
}

public class Fines
{
    public int Amount { get; set; }
    public string Street { get; set; }
}

public static class PersonManager
{
    

    public static void AddFile()
    {
        

        Console.Clear();
        Person person = new Person();
        Console.WriteLine("Adinizi dahil edin:");
        string personName = Console.ReadLine();

        person.Name = personName;

        Console.WriteLine("masinin nomresini dahil edin:");
        string carNumber = Console.ReadLine();

        Console.WriteLine("Cermenin meblegini dahil edin:");
        int fineAmount = int.Parse(Console.ReadLine());

        Console.WriteLine("Hadise olan yeri dahil edin :");
        string street = Console.ReadLine();


        Fines fines = new Fines();
        fines.Amount = fineAmount;
        fines.Street = street;

            if (!Program.personsList.Keys.Any(p => p.Name == personName))
            {
            Dictionary<string, Fines> finesDictionary = new Dictionary<string, Fines>();
            finesDictionary.Add(carNumber, fines);
            Program.personsList.Add(person, finesDictionary);
            Console.WriteLine("User add olundu liste !!!");
            
            }
            else
            {
            Program.personsList[person].Add(carNumber, fines);
            Console.WriteLine("Cerme add olundu !!!");
            }


    }

    public static void FindCarNumber()
    {
        Console.Clear();
        Console.WriteLine("Enter the car number for search:");
        string searchCarNumber = Console.ReadLine().ToUpper();

        foreach (var entry in Program.personsList)
        {
            foreach (var item in entry.Value)
            {
                if (item.Key == searchCarNumber)
                {
                    Console.WriteLine($"Person: {entry.Key.Name}, Car Number: {item.Key}, Fine Amount: {item.Value.Amount}, Street: {item.Value.Street}");
                }
            }
        }
    }

    public static void UserAddList ()
    {
        var serializedData = Program.personsList.Select(entry => new
        {
            Person = entry.Key,
            Fines = entry.Value
        });

        var json = JsonSerializer.Serialize(serializedData);

        File.WriteAllText("json.txt", json);
        Console.WriteLine("Data serialized and saved to json.txt");
    }

    public static void VievUser()
    {
        foreach (var entry in Program.personsList)
        {
            Console.WriteLine($"Person: {entry.Key.Name}");
            foreach (var item in entry.Value)
            {
                Console.WriteLine($"Car Number: {item.Key}, Fine Amount: {item.Value.Amount}, Street: {item.Value.Street}");
            }
        }
    }

    public static void VievFile()
    {
        var fileContent = File.ReadAllText("json.txt");
        Program.personsList = JsonSerializer.Deserialize<Dictionary<Person, Dictionary<string, Fines>>>(fileContent);
    }
}

