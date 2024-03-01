using System.Text.RegularExpressions;

namespace ConsoleApp1.User
{
    internal class File
    {
        
        static void Main()
        {
            Class person = new Class();
        

            bool isActive = false;
            bool exit = person.Giris(ref isActive);

            while (isActive == false) 
            {
                int BakuRossiyaPrice = 100;
                int BakuTurkeyPrice = 125;
                int BakuJapanPrice = 150;

                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                int hour = DateTime.Now.Hour;
                int minutes = DateTime.Now.Minute;

                Console.WriteLine("almag istediyiniz Biletin Ayini yazin:");
                int myMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Gununu yazin:");
                int myDay = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Saatini yazin:");
                int myHour = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Deygesini yazin:");
                int myMinutes = int.Parse(Console.ReadLine());

                bool isMatch = year == year && day >= myDay && hour >= myHour && minutes >= myMinutes;

                if (isMatch)
                {
                    person.Decrement();
                }

                int monthDifference = myMonth - month;
                int dayDifference = myDay - day;
                int hourDifference = myHour - hour;
                int minuteDifference = myMinutes - minutes;

                string totalTimeDifference = $"Month:{monthDifference} ,day:{dayDifference} , hour:{hourDifference} , minute:{minuteDifference}";

                Console.WriteLine($"Baku -- Russiya day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuRossiyaPrice} Enter: 1");
                Console.WriteLine($"Baku -- Turkiye day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuTurkeyPrice} Enter: 2");
                Console.WriteLine($"Baku -- Japoniya day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuJapanPrice} Enter: 3");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine($"Baku -- Russiya bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuRossiyaPrice);
                        break;
                    case 2:
                        Console.WriteLine($"Baku -- Turkiye bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuTurkeyPrice);
                        break;
                    case 3:
                        Console.WriteLine($"Baku -- Japoniya bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuJapanPrice);
                        break;
                    case 4:
                        person.VievBalance();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim! Tekrar deneyin.");
                        break;
                }

                isActive = true;

            }

            while (exit)
            {
                

                int BakuRossiyaPrice = 100;
                int BakuTurkeyPrice = 125;
                int BakuJapanPrice = 150;

                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                int hour = DateTime.Now.Hour;
                int minutes = DateTime.Now.Minute;

                Console.WriteLine("almag istediyiniz Biletin Ayini yazin:");
                int myMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Gununu yazin:");
                int myDay = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Saatini yazin:");
                int myHour = int.Parse(Console.ReadLine());
                Console.WriteLine("Biletin Deygesini yazin:");
                int myMinutes = int.Parse(Console.ReadLine());

                bool isMatch = year == year && day >= myDay && hour >= myHour && minutes >= myMinutes;

                if (isMatch)
                {
                    Console.WriteLine("biletinizin vahti kecib !!!");
                    person.Decrement();
                }

                int monthDifference = myMonth - month;
                int dayDifference = myDay - day;
                int hourDifference = myHour - hour;
                int minuteDifference = myMinutes - minutes;

                string totalTimeDifference = $"Month:{monthDifference} ,day:{dayDifference} , hour:{hourDifference} , minute:{minuteDifference}";

                Console.WriteLine($"Baku -- Russiya day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuRossiyaPrice} Enter: 1");
                Console.WriteLine($"Baku -- Turkiye day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuTurkeyPrice} Enter: 2");
                Console.WriteLine($"Baku -- Japoniya day:{myDay} hour:{myHour} minutes:{myMinutes} Price:{BakuJapanPrice} Enter: 3");
                Console.WriteLine("4. Bilet Iade");
                Console.WriteLine("5. Balansi Artir");
                Console.WriteLine("6. Balansi Goster");
                Console.WriteLine("7. Biletlerin Sayi");
                Console.WriteLine("8. Cihis");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine($"Baku -- Russiya bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuRossiyaPrice);
                        break;
                    case 2:
                        Console.WriteLine($"Baku -- Turkiye bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuTurkeyPrice);
                        break;
                    case 3:
                        Console.WriteLine($"Baku -- Japoniya bilet aldiniz biletin yararsig olmagina : {totalTimeDifference}");
                        person.BiletAdd(BakuJapanPrice);
                        break;
                    case 4:
                        if (person.BiletCount())
                        {
                            bool isReturnMatch = year == year && myDay <= day && myHour <= hour && myMinutes <= minutes;

                            if (isReturnMatch)
                            {
                                Console.WriteLine("Iade etmek istediyiniz bileti sechdiyiniz bilete uygun olaraq secin:");
                                Console.WriteLine("1. Baku -- Russiya");
                                Console.WriteLine("2. Baku -- Turkiye");
                                Console.WriteLine("3. Baku -- Japoniya");

                                int returnChoice = int.Parse(Console.ReadLine());

                                switch (returnChoice)
                                {
                                    case 1:
                                        Console.WriteLine($"Baku -- Russiya biletinizi iade ettiniz");
                                        person.BiletIade(BakuRossiyaPrice);
                                        break;
                                    case 2:
                                        Console.WriteLine($"Baku -- Turkiye biletinizi iade ettiniz");
                                        person.BiletIade(BakuTurkeyPrice);
                                        break;
                                    case 3:
                                        Console.WriteLine($"Baku -- Japoniya biletinizi iade ettiniz");
                                        person.BiletIade(BakuJapanPrice);
                                        break;
                                    default:
                                        Console.WriteLine("Yanlis secim! Tekrar deneyin.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bilet iade etmek ucun uygun vahtda deyilsiniz!");
                            }
                        }
                        break;
                    case 5:
                        person.Balance();
                        break;
                    case 6:
                        person.VievBalance();
                        break;
                    case 7:
                        Console.WriteLine("Aldiginiz biletlerin sayi !!!");
                        Console.WriteLine(person.BiletCount());
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Yanliz menuda olan regemleri dahil edin !!!");
                        break;

                }
            }

        }
    }
}
