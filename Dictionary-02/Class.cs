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
    public static void AddFile(string personName , string carNumber ,int fineAmount , string street , Person person)
    {

        Fines fines = new Fines();
        fines.Amount = fineAmount;
        fines.Street = street;

        // Kişinin var olup olmadığını kontrol edin
        Person existingPerson = Program.personsList.Keys.FirstOrDefault(p => p.Name == person.Name);

        if (existingPerson == null)
        {
            Dictionary<string, Fines> finesDictionary = new Dictionary<string, Fines>();
            finesDictionary.Add(carNumber, fines);
            Program.personsList.Add(person, finesDictionary);
            Console.WriteLine("Kullanıcı eklendi!");
        }
        else
        {
            Program.personsList[existingPerson].Add(carNumber, fines);
            Console.WriteLine("Ceza eklendi!");
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
    }

    public static void VievFile()
    {
        string jsonString = File.ReadAllText("json.txt");
        Program.personsList = JsonSerializer.Deserialize<Dictionary<Person, Dictionary<string, Fines>>>(jsonString);

    }
}

