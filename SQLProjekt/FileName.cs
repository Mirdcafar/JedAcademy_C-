using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.SQLProjekt
{
    public class Program
    {
        public static void Main()
        {
            DeleteData();
        }

        static void ViewNameProduct()
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
                        var id = reader.GetInt32(0); // Assuming Id is an integer
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
        }

        static void ViewCountProduct()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"SELECT COUNT(*) FROM Product";

                var command = new SqlCommand(query, connection);
                var result = (int)command.ExecuteScalar();
                Console.WriteLine(result);

            }
        }

        static void InsertData()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"INSERT INTO Product (Name, Price, Count, Description) VALUES ('cola',3, 3, 'Mehsul bitmek uzre')";

                var command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();

                Console.WriteLine($"Rows affected: {result}");
            }
        }

        static void UpdateData()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"UPDATE Product SET Name = 'brokoli' WHERE Id = 2";

                var command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();

                Console.WriteLine($"Rows affected: {result}");
            }
        }

        static void DeleteData()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"DELETE FROM Product WHERE Id = 2";

                var command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();

                Console.WriteLine($"Rows affected: {result}");
            }
        }

    }

}
