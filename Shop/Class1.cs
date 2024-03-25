using ConsoleApp1.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Shop;

public class Product
{
   public string Description { get; set; }
    public int Price { get; set; }
    public Category Category { get; set; }
}

public enum Category
{
    Drink,
    Pizza,
    Dessert,
    Salad
}

class Class1
{
    public static bool Users(string name, int pass)
    {
        if (name == "admin" && pass == 123)
        {
            return true;
        }
        return false;
    }

    public static void SaveProductsToFile()
    {
        string json = JsonSerializer.Serialize(FileName.productList);
        File.WriteAllText("products.txt", json);
    }

    public static void ReadProductsFromFile()
    {
        string filePath = "products.txt";
        string directory = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        string json = JsonSerializer.Serialize(FileName.productList);
        File.WriteAllText(filePath, json);
    }

    public static void SavePersonProductsToFile()
    {
        var serializedData = Enumerable.Select(FileName.listPerson, (KeyValuePair<string, Dictionary<string, Product>> entry) => new
        {
            PersonName = entry.Key,
            Products = entry.Value
        });
        string json = JsonSerializer.Serialize(serializedData);
        File.WriteAllText("person_products.txt", json);
    }

    public static void ReadPersonProductsFromFile()
    {
        string jsonString = File.ReadAllText("person_products.txt");
        FileName.listPerson = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Product>>>(jsonString);
    }

    public static void AddProduct(string productName, Product product)
    {
        if (FileName.productList.ContainsKey(productName))
        {
            FileName.productList[productName] = product;
        }
        else
        {
            FileName.productList.Add(productName, product);
        }
    }

    public static void AddProductToPerson(string personName, string category, Product product)
    {
        if (!FileName.listPerson.ContainsKey(personName))
        {
            FileName.listPerson[personName] = new Dictionary<string, Product>();
        }
        if (FileName.listPerson[personName].ContainsKey(category))
        {
            Console.WriteLine(personName + " already has a product in category " + category + ".");
            return;
        }
        FileName.listPerson[personName][category] = product;
        Console.WriteLine($"Product added successfully for {personName} in category {category}.");
    }

}

