using ConsoleApp1.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Shop;

public class SerializedPersonProduct
{
    public Person Person { get; set; }
    public Product Product { get; set; }
}
public class Person
{
    public string Name { get; set; }
    public int Password { get; set; }
}

public class Product
{
    public Drinks Drinks { get; set; } = new Drinks();
    public Pizza Pizza { get; set; } = new Pizza();
    public Desserts Desserts { get; set; } = new Desserts();
    public Salad Salad { get; set; } = new Salad();

    public int ProductCount { get; set; }
}

public class Drinks
{
    public string Name { get; set; }
    public int Price { get; set; }
}

public class Pizza
{
    public string Name { get; set; }
    public int Price { get; set; }

}

public class Desserts
{
    public string Name { get; set; }
    public int Price { get; set; }
}

public class Salad
{
    public string Name { get; set; }
    public int Price { get; set; }
}

class Class1
{
    public static bool Users(string name, int pass)
    {
        if (name == "admin" && pass == 123)
        {
            return true;
        }
        else
        {

            return false;
        }
    }


    public static void AddProduct(string name, Product product)
    {
        Product existingPerson = FileName.productList.FirstOrDefault(p => p.Key == name).Value;


        if (existingPerson == null)
        {
            FileName.productList.Add(name, product);
        }
        else
        {
            FileName.productList[name] = product;
        }
    }

    public static void AddToFile()
    {
        var json = JsonSerializer.Serialize(FileName.productList);

        File.WriteAllText("json.txt", json);
    }

    public static void ReadFile()
    {
        string jsonString = File.ReadAllText("json.txt");
        FileName.productList = JsonSerializer.Deserialize<Dictionary<string, Product>>(jsonString);
    }

    public static void AddToFile3()
    {
        var serializedData = FileName.listPerson.Select(entry => new
        {
            Person = entry.Key,
            Products = entry.Value
        });

        var json = JsonSerializer.Serialize(serializedData);

        File.WriteAllText("file.txt", json);

    }

    public static void ReadFile3()
    {

        string jsonString = File.ReadAllText("file.txt");
        var list = JsonSerializer.Deserialize<Dictionary<Person, Dictionary<string, Product>>>(jsonString);

        foreach (var kvp in list)
        {
            foreach (var productKvp in kvp.Value)
            {
                if (!FileName.listPerson.ContainsKey(kvp.Key))
                {
                    FileName.listPerson[kvp.Key] = new Dictionary<string, Product>();
                }
                FileName.listPerson[kvp.Key].Add(productKvp.Key, productKvp.Value);
            }
        }
    }

    public static void AddProductToPerson(string personName, Person person, string category, Product product)
    {
        

        if (!FileName.listPerson.ContainsKey(person))
        {
            FileName.listPerson[person] = new Dictionary<string, Product>();
        }

        if (FileName.listPerson[person].ContainsKey(category))
        {
            Console.WriteLine($"{personName} already has a product in category {category}.");
        }
        else
        {
            FileName.listPerson[person][category] = product;
            Console.WriteLine($"Product added successfully for {personName} in category {category}.");
        }
    }

}

