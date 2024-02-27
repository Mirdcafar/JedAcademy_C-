

namespace ConsoleApp1.User
{
    internal class File
    {
        static void Main()
        {
            Class person = new Class();


            bool isActive = false;
            bool exit = person.Giris(ref isActive);
            while (exit)
            {
                Console.WriteLine("1. Bilet Al");
                Console.WriteLine("2. Bilet Iade");
                Console.WriteLine("3. Balansi Artir");
                Console.WriteLine("4. Balansi Goster");
                Console.WriteLine("5. Cikis");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        person.BiletAlmag();
                        break;
                    case 2:
                        person.BiletIade();
                        break;
                    case 3:
                        person.Balance();
                        break;
                    case 4:
                        person.VievBalance();
                        break;
                    case 5:
                        exit = false;
                        Console.WriteLine("Cixis...");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim! Tekrar deneyin.");
                        break;
                }
            }

        }
    }
}
