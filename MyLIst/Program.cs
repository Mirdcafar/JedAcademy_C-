namespace ConsoleApp1.MyLIst
{
    class Program
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();

            // 5 eleman ekleyelim
            for (int i = 1; i <= 5; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine("After adding 5 elements:");
            myList.PrintList();

            // 500 eleman ekleyelim
            for (int i = 6; i <= 505; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine("After adding 500 more elements:");
            myList.PrintList();
        }
    }
}
