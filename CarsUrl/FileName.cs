//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CarsUrl
//{
//    public class FileName
//    {
//        public async static Task Main()
//        {
//            string json = File.ReadAllText("C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\CarsUrl\\db.json");
//            var res = JsonSerializer.Deserialize<Root>(json);

//            foreach (var item in res.cars)
//            {
//                Console.WriteLine($"Model: {item.model}, Year: {item.year}");
//            }
//        }
//    }
//}
