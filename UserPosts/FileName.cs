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
            var json = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\user.json");
            var res = JsonSerializer.Deserialize<List<User>>(json);

            var post = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\UserPosts\\post.json");
            var rest = JsonSerializer.Deserialize<List<Post>>(post);


            while (true)
            {
                for (int i = 1; i < res.Count; i++)
                {
                    Console.WriteLine($"{i}.Name:{res[i].name}, Email:{res[i].email}");
                }
                int num = int.Parse(Console.ReadLine());
                foreach (var item in rest)
                {
                    if (item.userId == num)
                    {
                        Console.WriteLine($"UserId:{item.userId}, Id:{item.id}, Title:{item.title}, Body:{item.body} ");
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

