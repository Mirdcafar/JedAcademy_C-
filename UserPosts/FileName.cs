using ConsoleApp1.UserPosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.UserPosts
{
    public class FileName
    {
        public static async Task Main()
        {
            Task<List<User>> userTask = Task.Run(() => ReadUserAsync("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\user.json"));
            Task<List<Post>> postTask = Task.Run(() => ReadPostAsync("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\post.json"));

            List<User> user = await userTask;
            List<Post> post = await postTask;

            while (true)
            {
                for (int i = 1; i < user.Count; i++)
                {
                    Console.WriteLine($"{i}.Name:{user[i].name}, Email:{user[i].email}");
                }
                Console.Write("Regemi dahil edin:");
                int id = int.Parse(Console.ReadLine());
                foreach (var item in post)
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
        public static async Task<List<User>> ReadUserAsync(string filePath)
        {
            string json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        public static async Task<List<Post>> ReadPostAsync(string filePath)
        {
            string post = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Post>>(post);
        }
    }
}

