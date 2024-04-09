using ConsoleApp1.UserPosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.UserPosts
{
    public class UserPost
    {
        public static void Main()
        {
           

           

            string json = File.ReadAllText("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\user.json");
            var user = JsonSerializer.Deserialize<List<User>>(json);

            string post = File.ReadAllText("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\post.json");
            var posts = JsonSerializer.Deserialize<List<Post>>(post);
            while (true)
            {
                for (int i = 1; i < user.Count; i++)
                {
                    Console.WriteLine($"{i}.Name:{user[i].name}, Email:{user[i].email}");
                }
                Console.Write("Regemi dahil edin:");
                int id = int.Parse(Console.ReadLine());
                foreach (var item in posts)
                {
                    if (item.userId == id)
                    {
                        Console.WriteLine($"UserId:{item.userId}, Id:{item.id}, Title:{item.title}, Body:{item.body} ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Davam etmek ucun entere tikliyin");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
    }
}

