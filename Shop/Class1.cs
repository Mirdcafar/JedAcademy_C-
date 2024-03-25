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
        else
        {

            return false;
        }
    }

    public static void SaveProductsToFile()
    {
        try
        {
            var json = JsonSerializer.Serialize(FileName.productList);
            File.WriteAllText("products.txt", json);
            Console.WriteLine("Products saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving products: {ex.Message}");
        }
    }

    public static void ReadProductsFromFile()
    {
        try
        {
            string jsonString = File.ReadAllText("products.txt");
            FileName.productList = JsonSerializer.Deserialize<List<Product>>(jsonString);
            Console.WriteLine("Products loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading products: {ex.Message}");
        }
    }




    public static void AddProduct(Product product, Category category)
    {
        if (product != null && product.Price > 0)
        {
            FileName.productList.Add(product);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid product information. Product not added.");
        }
    }

    public static void SavePersonProductsToFile()
    {
        var json = JsonSerializer.Serialize(FileName.listPerson);
        File.WriteAllText("person.txt", json);
    }

    public static void ReadPersonProductsFromFile()
    {
        string jsonString = File.ReadAllText("person.txt");
        FileName.listPerson = JsonSerializer.Deserialize<Dictionary<string, Product>>(jsonString);
    }

    public static void AddProductToPerson(string personName, Product product)
    {

        if (!FileName.listPerson.ContainsKey(personName))
        {
            FileName.listPerson = new Dictionary<string, Product>();
        }

        FileName.listPerson[personName] = product;
        Console.WriteLine($"Product added successfully for {personName} ");
    }

}

