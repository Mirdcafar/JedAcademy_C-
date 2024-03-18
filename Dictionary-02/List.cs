
using System.Text.Json;

class Program
{
    public static Dictionary<Person, Dictionary<string, Fines>> personsList = new Dictionary<Person, Dictionary<string, Fines>>();

    static void Main()
    {


        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Useri eleve etmek ");
            Console.WriteLine("2. masinin nomresin tapmag");
            Console.WriteLine("3. Useri liste eleve elemek");
            Console.WriteLine("4. userleri ve masinin nomresini gormek");
            Console.WriteLine("5. File leri listen goturmek");
            Console.WriteLine("6. Cixis");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:

                    PersonManager.AddFile();
                    break;
                case 2:
                    PersonManager.FindCarNumber();
                    break;
                case 3:
                    PersonManager.UserAddList();
                    break;

                case 4:
                    PersonManager.VievUser();
                    break;

                case 5:
                    PersonManager.VievFile();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Menuda olan regemleri dahil edin\r\n");
                    break;
            }
        }
    }
}
