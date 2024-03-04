//using System.Diagnostics;
//using System.Text.RegularExpressions;
//using System.Xml.Linq;

//namespace ConsoleApp1.User
//{
//    internal class File
//    {
//        enum Continent
//        {
//            Rossiya,
//            Turkey,
//            Japan,
//            Stop
//        }
//        static void Main()
//        {

//            List<ClassBilet.People> personsList = new List<ClassBilet.People>
//            {
//                new ClassBilet.People { Name = "Baku", Name2 = "Rossiya", Price = 100 },
//                new ClassBilet.People { Name = "Baku", Name2 = "Turkey", Price = 130 },
//                new ClassBilet.People { Name = "Baku", Name2 = "Japan", Price = 120 }
//            };

//            Class person = new Class();

//            int year = DateTime.Now.Year;
//            int month = DateTime.Now.Month;
//            int day = DateTime.Now.Day;
//            int hour = DateTime.Now.Hour;
//            int minutes = DateTime.Now.Minute;

//            int myMonth = 4;
//            int myDay = 4;
//            int myHour = 17;
//            int myMinutes = 45;

//            bool isActive = false;
//            bool exit = person.Giris(ref isActive);

//            while (isActive == false)
//            {
                

//                bool isMatch = year == year && day >= myDay && hour >= myHour && minutes >= myMinutes;

//                if (isMatch)
//                {
//                    person.Decrement();
//                }

//                int monthDifference = myMonth - month;
//                int dayDifference = myDay - day;
//                int hourDifference = myHour - hour;
//                int minuteDifference = myMinutes - minutes;

//                string totalTimeDifference = $"Month:{monthDifference} ,day:{dayDifference} , hour:{hourDifference} , minute:{minuteDifference}";

//                Console.WriteLine("Istediyiniz reysi secin :");
//                int count = 0;
//                foreach (var item in personsList)
//                {
//                    Console.WriteLine($"{item.Name} -- {item.Name2} day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{item.Price} Enter: {count++}");

//                }
//                Console.WriteLine("Cihis Enter: 3" +
//                    "");

//                for (int i = 0; i < 1; i++)
//                {

//                    int secim;
//                    if (int.TryParse(Console.ReadLine(), out secim))
//                    {
//                        switch ((Continent)secim)
//                        {
//                            case Continent.Rossiya:
//                                Console.WriteLine($"Baku -- Rossiya bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                                person.BiletAdd(personsList[0].Price);
//                                break;
//                            case Continent.Turkey:
//                                Console.WriteLine($"Baku -- Turkiye bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                                person.BiletAdd(personsList[1].Price);
//                                break;
//                            case Continent.Japan:
//                                Console.WriteLine($"Baku -- Japoniya bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                                person.BiletAdd(personsList[2].Price);
//                                break;
                            
//                            default:
//                                Console.WriteLine("Invalid choice! Please try again.");
//                                break;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please enter a valid integer.");
//                    }
//                }
                
//                isActive = true;
//            }

//            while (exit)
//            {

              

                

//                bool isMatch = year == year && day >= myDay && hour >= myHour && minutes >= myMinutes;

//                if (isMatch)
//                {
//                    Console.WriteLine("biletinizin vahti kecib !!!");
//                    person.Decrement();
//                }

//                int monthDifference = myMonth - month;
//                int dayDifference = myDay - day;
//                int hourDifference = myHour - hour;
//                int minuteDifference = myMinutes - minutes;

//                string totalTimeDifference = $"Month:{monthDifference} ,day:{dayDifference} , hour:{hourDifference} , minute:{minuteDifference}";

//                Console.WriteLine("Istediyiniz reysi secin :");
//                int count = 0;
//                foreach (var item in personsList)
//                {
//                    Console.WriteLine($"{item.Name} -- {item.Name2} day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{item.Price} Enter: {count++}");

//                }

//                for (int i = 0; i < 1; i++)
//                {
//                    int secimler = int.Parse(Console.ReadLine());

//                    switch ((Continent)secimler)
//                    {
//                        case Continent.Rossiya:
//                            Console.WriteLine($"Baku -- Rossiya bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                            person.BiletAdd(personsList[0].Price);
//                            break;
//                        case Continent.Turkey:
//                            Console.WriteLine($"Baku -- Turkiye bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                            person.BiletAdd(personsList[1].Price);
//                            break;
//                        case Continent.Japan:
//                            Console.WriteLine($"Baku -- Japoniya bilet aldiniz. Biletin yararsig olmagina: {totalTimeDifference}");
//                            person.BiletAdd(personsList[2].Price);
//                            break;
//                        default:
//                            Console.WriteLine("Invalid choice! Please try again.");
//                            break;

//                    }


//                    Console.WriteLine("1. Bilet Iade");
//                    Console.WriteLine("2. Balansi Artir");
//                    Console.WriteLine("3. Balansi Goster");
//                    Console.WriteLine("4. Biletlerin Sayi");
//                    Console.WriteLine("5. Cihis");

//                    int secim = int.Parse(Console.ReadLine());


//                    switch (secim)
//                    {
//                        case 1:                            
//                                if (person.BiletCountBool())
//                                {
//                                    Console.WriteLine("Iade etmek istediyiniz bileti sechdiyiniz bilete uygun olaraq secin:");
//                                    Console.WriteLine("1. Baku -- Russiya");
//                                    Console.WriteLine("2. Baku -- Turkiye");
//                                    Console.WriteLine("3. Baku -- Japoniya");

//                                    int returnChoice = int.Parse(Console.ReadLine());

//                                    for (int j = 0; j < 1; j++)
//                                    {
//                                        switch (returnChoice)
//                                        {
//                                            case 1:
//                                                Console.WriteLine($"Baku -- Russiya biletinizi iade ettiniz");
//                                                person.BiletIade(personsList[0].Price);
//                                                break;
//                                            case 2:
//                                                Console.WriteLine($"Baku -- Turkiye biletinizi iade ettiniz");
//                                                person.BiletIade(personsList[1].Price);
//                                                break;
//                                            case 3:
//                                                Console.WriteLine($"Baku -- Japoniya biletinizi iade ettiniz");
//                                                person.BiletIade(personsList[2].Price);
//                                                break;
//                                            default:
//                                                Console.WriteLine("Yanlis secim! Tekrar deneyin.");
//                                                break;
//                                        }
//                                    }
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Bilet iade etmek icin bilet alin !!!");
//                                }
                            
//                            break;
//                        case 2:
//                            person.Balance();
//                            break;
//                        case 3:
//                            person.VievBalance();
//                            break;
//                        case 4:
//                            Console.WriteLine("Aldiginiz biletlerin sayi !!!");
//                            person.BiletCount();
//                            break;
//                        case 5:
//                            Console.Clear();
//                            break;
//                        default:
//                            Console.WriteLine("Yanliz menuda olan regemleri dahil edin !!!");
//                            break;

//                    }
//                }

//                Console.WriteLine("Yeni bilet almak istiyor musunuz? (y/n)");
//                string response = Console.ReadLine();
//                if (response.ToLower() == "y")
//                {
//                    exit = true;
//                }
//                else
//                {
//                    Console.Clear();
//                }

//            }
//        }
//    }
//}