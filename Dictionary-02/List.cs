
//using System.Text.Json;

//class Program
//{
//    public static Dictionary<Person, Dictionary<string, Fines>> personsList = new Dictionary<Person, Dictionary<string, Fines>>();

//    static void Main()
//    {


//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("1. Useri eleve etmek ");
//            Console.WriteLine("2. masinin nomresin tapmag");
//            Console.WriteLine("3. Useri liste eleve elemek");
//            Console.WriteLine("4. userleri ve masinin nomresini gormek");
//            Console.WriteLine("5. File leri listen goturmek");
//            Console.WriteLine("6. Cixis");

//            int num = int.Parse(Console.ReadLine());

//            switch (num)
//            {
//                case 1:
//                    Console.Clear();
//                    Person person = new Person();
//                    Console.WriteLine("Adinizi dahil edin:");
//                    string personName = Console.ReadLine();

//                    person.Name = personName;

//                    Console.WriteLine("masinin nomresini dahil edin:");
//                    string carNumber = Console.ReadLine();

//                    Console.WriteLine("Cermenin meblegini dahil edin:");
//                    int fineAmount = int.Parse(Console.ReadLine());

//                    Console.WriteLine("Hadise olan yeri dahil edin :");
//                    string street = Console.ReadLine();

//                    PersonManager.AddFile(personName , carNumber , fineAmount , street , person);
//                    break;
//                case 2:
//                    Console.Clear();
//                    Console.WriteLine("Enter the car number for search:");
//                    string searchCarNumber = Console.ReadLine().ToUpper();

//                    foreach (var entry in personsList)
//                    {
//                        foreach (var item in entry.Value)
//                        {
//                            if (item.Key == searchCarNumber)
//                            {
//                                Console.WriteLine($"Person: {entry.Key.Name}, Car Number: {item.Key}, Fine Amount: {item.Value.Amount}, Street: {item.Value.Street}");
//                            }
//                        }
//                    }
//                    break;
//                case 3:
//                    PersonManager.UserAddList();
//                    break;

//                case 4:
//                    foreach (var entry in Program.personsList)
//                    {
//                        Console.WriteLine($"Person: {entry.Key.Name}");
//                        foreach (var item in entry.Value)
//                        {
//                            Console.WriteLine($"Car Number: {item.Key}, Fine Amount: {item.Value.Amount}, Street: {item.Value.Street}");
//                        }
//                    }
//                    break;

//                case 5:
//                    PersonManager.VievFile();
//                    break;
//                case 6:
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Menuda olan regemleri dahil edin\r\n");
//                    break;
//            }
//        }
//    }
//}
