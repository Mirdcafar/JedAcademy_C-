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
        private string _connectionString;

        public Methods(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void ViewProduct(List<Product> products)
        {

            using (var connection = new SqlConnection(_connectionString))
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

            }
        }

        public void ViewCount()
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = @"SELECT COUNT(*) FROM Product";

                var command = new SqlCommand(query, connection);
                var result = (int)command.ExecuteScalar();
                Console.WriteLine($"Mehsullarin sayi:{result}");

            }
        }
        public void InsertData(string name , int price , int count , string description)
        {

            using (var connection = new SqlConnection(_connectionString))
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

        public void UpdateData(string names, string product , int id)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var querys = @$"UPDATE Product SET {names} = @Product WHERE Id = @Id";

                var commands = new SqlCommand(querys, connection);

                commands.Parameters.AddWithValue("@Product", product);
                commands.Parameters.AddWithValue("@Id", id);

                var result = commands.ExecuteNonQuery();

            }
        }

        public void DeleteData( int idi)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var queryi = @$"DELETE FROM Product WHERE Id = @Id";

                var commande = new SqlCommand(queryi, connection);

                commande.Parameters.AddWithValue("@Id", idi);
                var result = commande.ExecuteNonQuery();

            }
        }

        public void ViewEmployees(List<Employees> employees)
        {

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = @"SELECT * FROM Employees";
                var command = new SqlCommand(query, connection);


                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var employe = new Employees();
                        var id = reader.GetInt32(0);
                        var FullName = reader.GetString(1);
                        var NumberOfUnitsSold = reader.GetInt32(2);

                        employe.Id = id;
                        employe.FullName = FullName;
                        employe.NumberOfUnitsSold = NumberOfUnitsSold;

                        employees.Add(employe);
                    }
                }
            }

        }
    }
}
