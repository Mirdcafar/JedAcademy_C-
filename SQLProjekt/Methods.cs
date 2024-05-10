using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SQLProjekt
{
    public class Methods
    {
        public static void ViewProduct(List<Product> products)
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
        }

        public static void ViewCount()
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"SELECT COUNT(*) FROM Product";

                var command = new SqlCommand(query, connection);
                var result = (int)command.ExecuteScalar();
                Console.WriteLine($"Mehsullarin sayi:{result}");

            }
        }
        public static void InsertData(string name , int price , int count , string description)
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @$"INSERT INTO Product (Name, Price, Count, Description) VALUES (@Name,@Price, @Count, @Description)";

                var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Count", count);
                command.Parameters.AddWithValue("Description", description);

                var result = command.ExecuteNonQuery();

            }
        }

        public static void UpdateData(string names, string product , int id)
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var querys = @$"UPDATE Product SET {names} = @Product WHERE Id = @Id";

                var commands = new SqlCommand(querys, connection);

                commands.Parameters.AddWithValue("@Product", product);
                commands.Parameters.AddWithValue("@Id", id);

                var result = commands.ExecuteNonQuery();

            }
        }

        public static void DeleteData( int idi)
        {
            var connectionString = @"Data Source=DESKTOP-1EL7RH1\MSSQLSERVER01;Initial Catalog=Sport_Shop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var queryi = @$"DELETE FROM Product WHERE Id = @Id";

                var commande = new SqlCommand(queryi, connection);

                commande.Parameters.AddWithValue("@Id", idi);
                var result = commande.ExecuteNonQuery();

            }
        }
    }
}
