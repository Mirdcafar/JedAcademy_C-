//using ConsoleApp1.Shop;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ConsoleApp1.Shop;

//public class Product
//{
//    public int Count { get; set; }
//    public string Description { get; set; }
//    public int Price { get; set; }
//    public Category Category { get; set; }
//}

//public enum Category
//{
//    Drink,
//    Pizza,
//    Dessert,
//    Salad
//}

//class Class1
//{
//    public static bool Users(string name, string pass)
//    {
//        if (name == "admin" && pass == "123")
//        {
//            return true;
//        }
//        else
//        {

//            return false;
//        }
//    }

//    public static void SaveProductsToFile()
//    {

//        var json = JsonSerializer.Serialize(FileName.productList);
//        File.WriteAllText("products.txt", json);

//    }

//    public static void ReadProductsFromFile()
//    {

//        string jsonString = File.ReadAllText("products.txt");
//        FileName.productList = JsonSerializer.Deserialize<List<Product>>(jsonString);

//    }




//    public static void AddProduct(Product product, Category category)
//    {
//        var existingProduct = FileName.productList.FirstOrDefault(p => p.Category == category);

//        if (existingProduct == null)
//        {
//            FileName.productList.Add(product);
//        }

//    }

//    public static void SavePersonProductsToFile()
//    {
//        var json = JsonSerializer.Serialize(FileName.listPerson);
//        File.WriteAllText("person.txt", json);
//    }

//    public static void ReadPersonProductsFromFile()
//    {
//        string jsonString = File.ReadAllText("person.txt");
//        FileName.listPerson = JsonSerializer.Deserialize<Dictionary<string, Product>>(jsonString);
//    }

//    public static void AddProductToPerson(string personName, Product product)
//    {

//        if (!FileName.listPerson.ContainsKey(personName))
//        {
//            FileName.listPerson = new Dictionary<string, Product>();
//        }



//        FileName.listPerson[personName] = product;
//        product.Count++;

//    }

//    public static void FindRemove(string name)
//    {
//        var find = FileName.listPerson.FirstOrDefault(x => x.Value.Category.ToString() == name);

//        if (find.Key != null)
//        {
//            FileName.listPerson.Remove(find.Key);
//            Console.WriteLine("Məhsul uğurla silindi.");
//        }
//        else
//        {
//            Console.WriteLine("Belirtilen kategoriye uyğun məhsul tapılmadı.");
//        }
//    }


//}

