namespace ConsoleApp1.MyLIst
{
    public static class Program
    {
        public static void Main()
        {

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Array elements :");
            for (int i = 0; i < list.Count(); i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Silmek istediginiz regemi dahil edin :");
            int removeNum = int.Parse(Console.ReadLine());
            list.Remove(removeNum);


            Console.WriteLine("Removing element :" + removeNum);

            foreach (var element in list)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();
            List<int> lists = new List<int>();

            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            lists.Add(4);
            lists.Add(5);
            lists.Remove(removeNum);
            for (int i = 0; i < lists.Count(); i++)
            {
                Console.Write($"{lists[i]}, ");
            }

            Console.WriteLine();

            Console.WriteLine("Array count :");

            Console.WriteLine(list.Count());

            Console.WriteLine("List Any :");

            bool containts = list.Any(x => x == 3);

            Console.WriteLine(containts);

            Console.WriteLine("List Max :");

            Console.WriteLine(list.Max(x => x));

            Console.WriteLine("List Min :");

            Console.WriteLine(list.Min(x => x));

            Console.WriteLine("List Concat :");

            int[] concat = list.Concat(lists).ToArray();

            Console.WriteLine("Concatenated array elements:");

            foreach (var element in concat)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();

            Console.WriteLine("List Average :");

            double average = list.Average();

            Console.WriteLine($"Average : {average}");

            Console.WriteLine("List Reverse :");

            list.Reverse();

            foreach (var item in list)
            {
                Console.Write($"{item} ,");
            }

        }
    }
}
