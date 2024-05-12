using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.SQLProjekt
{
    public class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            List<Employees> employees = new List<Employees>();

            Methods.ViewProduct(products);


            foreach (var product1 in products)
            {
                Console.WriteLine($"ID: {product1.Id}, Name: {product1.Name}, Price: {product1.Price}, Count: {product1.Count}, Description: {product1.Description}");
            }

            bool exit = true;

            while (exit)
            {
                Methods.ViewCount();

                Console.WriteLine("1.Mexsul eleve etmey");
                Console.WriteLine("2.Mexsulun icinde neyise deyistirmey");
                Console.WriteLine("3.Mexsul silmey");
                Console.WriteLine("4.Iscilerin siyahi");
                Console.WriteLine("5.Iscilerin satdigi mehsullarin sayi");
                Console.WriteLine("6.Cixis");
                
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("mehsulun adini dahiledin:");
                            string name = Console.ReadLine();
                            Console.WriteLine("mehsulun giymetini dahiledin:");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine("mehsulun sayini dahiledin:");
                            int count = int.Parse(Console.ReadLine());
                            Console.WriteLine("mehsulun hsusiyeterini dahil edin dahiledin:");
                            string description = Console.ReadLine();

                            Methods.InsertData(name, price, count, description);

                            break;
                        case 2:
                            Console.WriteLine("Neyi deyistirmek istiyirsiz:");
                            string names = Console.ReadLine();
                            Console.WriteLine("Neye deyistirmek istiyirsiz:");
                            string product = Console.ReadLine();
                            Console.WriteLine("Mehsulun id sini dahil edin:");
                            int id = int.Parse(Console.ReadLine());

                            Methods.UpdateData(names, product, id);

                            break;
                        case 3:
                            Console.WriteLine("Mehsulun idi sini dahil edin:");
                            int idi = int.Parse(Console.ReadLine());
                            
                            Methods.DeleteData(idi);

                            break;
                        case 4:
                        Methods.ViewEmployees(employees);


                        foreach (var employe in employees)
                        {
                            Console.WriteLine($"Id: {employe.Id}, FullName: {employe.FullName}, NumberOfUnitsSold: {employe.NumberOfUnitsSold}");
                        }
                        break;
                        case 6:
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Menuda olan regemi dahil edin !!!");
                            break;
                    }
                
            }
        }
    }
}
