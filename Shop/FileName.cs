using System;
using System.IO;
using System.Text.Json;
using ConsoleApp1.Shop;

internal class FileName
{
    public static Dictionary<string, Product> listPerson = new Dictionary<string, Product>();
    public static List<Product> productList = new List<Product>();

    static void Main()
    {

        Product product = new Product();
        Console.WriteLine("Adinizi dahil edin:");
        string personName = Console.ReadLine().ToLower();
        Console.WriteLine("Sifreni dahil edin:");
        string personPass = Console.ReadLine();

        bool authenticated = Class1.Users(personName, personPass);



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
                                Console.WriteLine("İçki əlavə etmək:");
                                string drinkName = Console.ReadLine();
                                Console.WriteLine("İçki qiymətini daxil edin:");
                                int drinkPrice = int.Parse(Console.ReadLine());
                                Product productDrink = new Product();
                                productDrink.Category = Category.Drink;
                                productDrink.Description = drinkName;
                                productDrink.Price = drinkPrice;
                                productDrink.Count = 1;
                                Class1.AddProduct(productDrink, Category.Drink);
                                break;

                            case 2:
                                Console.WriteLine("Pizza əlavə etmək:");
                                string pizzaName = Console.ReadLine();
                                Console.WriteLine("Pizza qiymətini daxil edin:");
                                int pizzaPrice = int.Parse(Console.ReadLine());

                                Product productPizza = new Product();
                                productPizza.Category = Category.Pizza;
                                productPizza.Description = pizzaName;
                                productPizza.Price = pizzaPrice;
                                productPizza.Count = 1;

                                Class1.AddProduct(productPizza, Category.Pizza);
                                break;

                            case 3:
                                Console.WriteLine("Desert əlavə etmək:");
                                string desertName = Console.ReadLine();
                                Console.WriteLine("Desertin qiymətini daxil edin:");
                                int desertPrice = int.Parse(Console.ReadLine());

                                Product productDesert = new Product();
                                productDesert.Category = Category.Dessert;
                                productDesert.Description = desertName;
                                productDesert.Price = desertPrice;
                                productDesert.Count = 1;

                                Class1.AddProduct(productDesert, Category.Dessert);
                                break;

                            case 4:
                                Console.WriteLine("Salat əlavə etmək:");
                                string saladName = Console.ReadLine();
                                Console.WriteLine("Salatın qiymətini daxil edin:");
                                int saladPrice = int.Parse(Console.ReadLine());

                                Product productSalad = new Product();
                                productSalad.Category = Category.Salad;
                                productSalad.Description = saladName;
                                productSalad.Price = saladPrice;
                                productSalad.Count = 1;


                                Class1.AddProduct(productSalad, Category.Salad);
                                break;

                            default:
                                Console.WriteLine("Menuda olan regemleri dahil edin !!!");
                                break;
                        }
                        break;

                    case 2:
                        foreach (var products in productList)
                        {
                            Console.WriteLine($"{products.Category}: {products.Description}, Price: {products.Price}, Count: {products.Count}");
                        }
                        break;

                    case 3:
                        Class1.SaveProductsToFile();
                        break;
                    case 4:
                        Class1.ReadProductsFromFile();
                        break;
                    case 5:
                        Class1.ReadPersonProductsFromFile();
                        foreach (var products in listPerson)
                        {

                            Console.WriteLine($"{products.Key}: {products.Value.Category} - {products.Value.Description}");

                        }
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Menuda olan regemleri dahil edin !!!");
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
                Class1.ReadProductsFromFile();

                switch (nums)
                {
                    case 1:
                        foreach (var products in productList)
                        {
                            Console.WriteLine($"{products.Category}: {products.Description}, Price: {products.Price}, Count: {products.Count}");
                        }


                        Console.WriteLine("1. İçki almaq");
                        Console.WriteLine("2. Pizza almaq");
                        Console.WriteLine("3. Desert almaq");
                        Console.WriteLine("4. Salat almaq");

                        int num = int.Parse(Console.ReadLine());

                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Ickini almaq:");

                                foreach (var products in productList)
                                {
                                    if (products.Category == Category.Drink)
                                    {
                                        Class1.AddProductToPerson(personName, products);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Pizzani almaq:");

                                foreach (var products in productList)
                                {
                                    if (products.Category == Category.Pizza)
                                    {
                                        Class1.AddProductToPerson(personName, products);
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Deserti almaq:");

                                foreach (var products in productList)
                                {
                                    if (products.Category == Category.Dessert)
                                    {
                                        Class1.AddProductToPerson(personName, products);
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine("Salat almaq:");

                                foreach (var products in productList)
                                {
                                    if (products.Category == Category.Salad)
                                    {
                                        Class1.AddProductToPerson(personName, products);
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Menuda olan regemleri dahil edin !!!");
                                break;

                        }
                        break;
                    case 2:
                        Class1.SavePersonProductsToFile();
                        break;
                    case 3:
                        Class1.ReadPersonProductsFromFile();
                        break;
                    case 4:
                        var totalPrice = productList.Select(x => x.Count * x.Price).Sum();

                        foreach (var personEntry in listPerson)
                        {

                            Console.WriteLine($"Products for {personEntry.Key}:");

                            foreach (var products in productList)
                            {
                                Console.WriteLine($"{products.Category} - {products.Description} - Count:{product.Count} - Price: {products.Price}");
                            }
                            Console.WriteLine($"Total Price: {totalPrice}");
                        }
                        break;
                    default:
                        Console.WriteLine("Menuda olan regemleri dahil edin !!!");
                        break;

                }
            }
        }
    }
}

