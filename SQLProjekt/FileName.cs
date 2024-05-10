using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.SQLProjekt
{
    public class Program
    {
        public static void Main()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            List<Product> products = new List<Product>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = @"SELECT * FROM Product";
                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product();
                        var id = reader.GetInt32(0); 
                        var name = reader.GetString(1);
                        var price = reader.GetInt32(2);
                        var count = reader.GetInt32(3);
                        var description = reader.GetString(4);

                        product.Id = id;
                        product.Name = name;
                        product.Price = price;
                        product.Count = count;
                        product.Description = description;

                        products.Add(product);

                    }
                }

                foreach (var product1 in products)
                {
                    Console.WriteLine($"ID: {product1.Id}, Name: {product1.Name}, Price: {product1.Price}, Count: {product1.Count}, Description: {product1.Description}");
                }
            }

            bool exit = true;

            while (exit)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var query = @"SELECT COUNT(*) FROM Product";

                    var command = new SqlCommand(query, connection);
                    var result = (int)command.ExecuteScalar();
                    Console.WriteLine($"Mehsullarin sayi:{result}");

                }
                Console.WriteLine("1.Mexsul eleve etmey");
                Console.WriteLine("2.Mexsulun icinde neyise deyistirmey");
                Console.WriteLine("3.Mexsul silmey");
                Console.WriteLine("4.Cixis");
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
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

                            var query = @$"INSERT INTO Product (Name, Price, Count, Description) VALUES ('{name}',{price}, {count}, '{description}')";

                            var command = new SqlCommand(query, connection);
                            var result = command.ExecuteNonQuery();

                            Console.WriteLine($"Rows affected: {result}");
                            break;
                        case 2:
                            Console.WriteLine("Neyi deyistirmek istiyirsiz:");
                            string names = Console.ReadLine();
                            Console.WriteLine("Neye deyistirmek istiyirsiz:");
                            string product = Console.ReadLine();
                            Console.WriteLine("Mehsulun id sini dahil edin:");
                            int id = int.Parse(Console.ReadLine());

                            var querys = @$"UPDATE Product SET {names} = '{product}' WHERE Id = {id}";

                            var commands = new SqlCommand(querys, connection);
                            var results = commands.ExecuteNonQuery();

                            Console.WriteLine($"Rows affected: {results}");
                            break;
                        case 3:
                            Console.WriteLine("Mehsulun idi sini dahil edin:");
                            int idi = int.Parse(Console.ReadLine());
                            var queryi = @$"DELETE FROM Product WHERE Id = {idi}";

                            var commande = new SqlCommand(queryi, connection);
                            var resultse = commande.ExecuteNonQuery();

                            Console.WriteLine($"Rows affected: {resultse}");
                            break;
                        case 4:
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
}
