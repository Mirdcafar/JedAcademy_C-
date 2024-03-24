using System;
using System.IO;
using System.Text.Json;
using ConsoleApp1.Shop;

internal class FileName
{
    public static Dictionary<Person, Dictionary<string, Product>> listPerson = new Dictionary<Person, Dictionary<string, Product>>();
    public static Dictionary<string , Product> productList = new Dictionary<string , Product>();

    static void Main()
    {
        Person person = new Person();

        Product product = new Product();
        Console.WriteLine("Adinizi dahil edin:");
        string personName = Console.ReadLine().ToLower();

        Console.WriteLine("Sifreni dahil edin:");
        int personPass = int.Parse(Console.ReadLine());

        person.Name = personName;
        person.Password = personPass;

        bool authenticated = Class1.Users(personName , personPass );

        if (authenticated)
        {
            while (true)
            {
                Console.WriteLine("1.Mehsul eleve etmek");
                Console.WriteLine("2.Mehsulari ve yserleri gormek");
                Console.WriteLine("3.Liste add elemek");
                Console.WriteLine("4.Liste olan melumati ohumag");
                Console.WriteLine("5.Personlari gormek");
                Console.WriteLine("6.Cixis");

                int num = int.Parse(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        Console.WriteLine("1.Icki eleve etmek");
                        Console.WriteLine("2.Pizza eleve etmek");
                        Console.WriteLine("3.Desert eleve etmek");
                        Console.WriteLine("4.Salat eleve etmek");

                        int nums = int.Parse(Console.ReadLine());

                        switch (nums)
                        {

                            case 1:
                                Console.WriteLine("Ickini eleve etmek:");
                                string drinks = Console.ReadLine();
                                Console.WriteLine("Ickinik nin giymetini dahil edin:");
                                int drinksPrice = int.Parse(Console.ReadLine());

                                Product productDrinks = new Product();

                                productDrinks.Drinks.Name = drinks;
                                productDrinks.Drinks.Price = drinksPrice;
                                productDrinks.ProductCount++;

                                Class1.AddProduct("Drinks", productDrinks);
                                break;
                            case 2:
                                Console.WriteLine("Pizzani eleve etmek:");
                                string pizzas = Console.ReadLine();
                                Console.WriteLine("Pizza nin giymetini dahil edin:");
                                int pizzaPrice = int.Parse(Console.ReadLine());

                                Product productPizza = new Product();

                                productPizza.Pizza.Name = pizzas;
                                productPizza.Pizza.Price = pizzaPrice;
                                productPizza.ProductCount++;

                                Class1.AddProduct("Pizza", productPizza);
                                break;
                            case 3:
                                Console.WriteLine("Deserti eleve etmek:");
                                string desserts = Console.ReadLine();
                                Console.WriteLine("Desert in giymetini dahil edin:");
                                int dessertPrice = int.Parse(Console.ReadLine());

                                Product productDessert = new Product();

                                productDessert.Desserts.Name = desserts;
                                productDessert.Desserts.Price = dessertPrice;
                                productDessert.ProductCount++;

                                Class1.AddProduct("Dessert", productDessert);
                                break;
                            case 4:
                                Console.WriteLine("Salat eleve etmek:");
                                string salads = Console.ReadLine();
                                Console.WriteLine("Salat in giymetini dahil edin:");
                                int saladPrice = int.Parse(Console.ReadLine());

                                Product productSalad = new Product();

                                productSalad.Salad.Name = salads;
                                productSalad.Salad.Price = saladPrice;
                                productSalad.ProductCount++;

                                Class1.AddProduct("Salad", productSalad);
                                break;
                        }
                        break;
                    case 2:

                        foreach (var item in productList)
                        {
                            Console.WriteLine($"Ürün Adı: {item.Key}");
                            if (item.Value.Drinks.Name != null)
                            {
                                Console.WriteLine($"İçecek: {item.Value.Drinks.Name}");
                            }
                            if (item.Value.Pizza.Name != null)
                            {
                                Console.WriteLine($"Pizza: {item.Value.Pizza.Name}");
                            }
                            if (item.Value.Desserts.Name != null)
                            {
                                Console.WriteLine($"Desert: {item.Value.Desserts.Name}");
                            }
                            if (item.Value.Salad.Name != null)
                            {
                                Console.WriteLine($"Salata: {item.Value.Salad.Name}");
                            }
                        }
                        break;
                    case 3:
                        Class1.AddToFile();
                        break;
                    case 4:
                        Class1.ReadFile();
                        break;
                    case 5:
                        Class1.ReadFile3();

                        foreach (var item in listPerson)
                        {
                            Console.WriteLine($"Name:{item.Key.Name}");
                            foreach (var item1 in item.Value)
                            {
                                Console.WriteLine($"{item1.Key}:{item1.Value.Pizza.Name}");
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        break;
                }
                Console.WriteLine("User authenticated successfully!");
            }
        }
        else
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1.Mehsul allmag");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.LogIn");
                Console.WriteLine("4.Liste olan mehsulara bahmag");

                int nums = int.Parse(Console.ReadLine());
                Class1.ReadFile();
                switch (nums)
                {
                    case 1:
                        Console.WriteLine("1.Icki eleve etmek");
                        Console.WriteLine("2.Pizza eleve etmek");
                        Console.WriteLine("3.Desert eleve etmek");
                        Console.WriteLine("4.Salat eleve etmek");

                        int num = int.Parse(Console.ReadLine());

                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Ickini Almag:");

                                foreach (var item in productList)
                                {
                                    Class1.AddProductToPerson(item.Key, person,"Drinks", item.Value);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Pizzani eleve etmek:");

                                foreach (var item in productList)
                                {
                                    Class1.AddProductToPerson(item.Key,person, "Pizza", item.Value);
                                }

                                break;
                            case 3:
                                Console.WriteLine("Deserti eleve etmek:");
                                foreach (var item in productList)
                                {
                                    Class1.AddProductToPerson(item.Key, person, "Desserts", item.Value);
                                }
                                break;
                            case 4:
                                Console.WriteLine("Salat eleve etmek:");
                                foreach (var item in productList)
                                {
                                    Class1.AddProductToPerson(item.Key, person,"Salad", item.Value);
                                }
                                break;
                        }
                        break;
                    case 2:
                        Class1.AddToFile3();
                        break; 
                    case 3:
                        Class1.ReadFile3();
                        break;
                    case 4:
                        foreach (var item in productList)
                        {
                            Console.WriteLine($"Ürün Adı: {item.Key}");
                            if (item.Value.Drinks.Name != null)
                            {
                                Console.WriteLine($"İçecek: {item.Value.Drinks.Name}");
                            }
                            if (item.Value.Pizza.Name != null)
                            {
                                Console.WriteLine($"Pizza: {item.Value.Pizza.Name}");
                            }
                            if (item.Value.Desserts.Name != null)
                            {
                                Console.WriteLine($"Desert: {item.Value.Desserts.Name}");
                            }
                            if (item.Value.Salad.Name != null)
                            {
                                Console.WriteLine($"Salata: {item.Value.Salad.Name}");
                            }
                        }
                        break; 

                }
            }
        }
    }
}

