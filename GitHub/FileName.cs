//using System;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;
//using Translater.Models;

//namespace ConsoleApp1.GitHub
//{
//    public class Program
//    {
//        public static async Task Main()
//        {
//            HttpClient client = new HttpClient();
//            client.DefaultRequestHeaders.Add("User-Agent", "MyUserAgent");

//            string gitHubUrl = "https://api.github.com/users/Mirdcafar";
//            var response = await client.GetAsync(gitHubUrl);
//            string responseBody = await response.Content.ReadAsStringAsync();


//            var userObject = JsonSerializer.Deserialize<User>(responseBody);

//            Console.WriteLine($"ID: {userObject.login}");
//            Console.WriteLine($"Type: {userObject.id}");
//            Console.WriteLine($"SetAdmin: {userObject.site_admin}");


//        }
//    }
//}