//double number = 123.789;

//int result = ((int)number);

//double res = number - result;
//double res2 = res * 1000;

//Console.WriteLine((int)+res2);

//1=========

//Console.WriteLine("Birinci uclu regemi dahil edin: ");
//if (int.TryParse(Console.ReadLine(), out int res))
//{
//    Console.WriteLine("Ikinci uclu regemi dahil edin: ");
//    if (int.TryParse(Console.ReadLine(), out int res2))
//    {
//        int rest = (res % 100) - (res % 10);
//        Console.WriteLine($"{res - rest} and {res2 + rest}");
//    }
//    else
//    {
//        Console.WriteLine("Invalid number 2 !!");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid number 1 !!");
//}

//2=========

//Console.WriteLine("Dort regemli regemi dahil edin: ");
//if (int.TryParse(Console.ReadLine(), out int pin))
//{
//    int res2 = (pin / 1000) + ((pin / 10) % 10);
//    int res3 = ((pin % 100) % 10) - ((pin / 100) % 10);
//    Console.WriteLine(res2);
//    Console.WriteLine(res3);

//}
//else
//{
//    Console.WriteLine("Invalid number");
//}

//3=========

//Console.WriteLine("Uc regemli regemi dahil edin: ");
//if (int.TryParse(Console.ReadLine() , out int res))
//{
//int res2 = (res % 10);
//int rest = (res / 100);
//Console.WriteLine($"{rest}{res2}");
//}
//else
//{
//    Console.WriteLine("Invalid number !!");
//}

//4=========

//Console.WriteLine("Emaneti manatla dahil edin");
//if (int.TryParse(Console.ReadLine(), out int manat))
//{
//    Console.WriteLine("Illik faizini daxil edin");
//    if (int.TryParse(Console.ReadLine(), out int fayiz))
//    {
//        int aylig = ((manat * fayiz) / 12) / 100;
//        Console.WriteLine("Aylig alacaginiz mebleg: ");
//        Console.WriteLine(aylig);
//    }
//    else
//    {
//        Console.WriteLine("Invalid number 2 !!");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid number 1 !!");
//}

//5========

//double funt = 405.9;
//Console.WriteLine("Cekini kiloda dahil edin: ");
//if (int.TryParse(Console.ReadLine(), out int kilogram))
//{
//    double funts = (funt * kilogram);
//    Console.WriteLine(funts);
//}else
//{
//Console.WriteLine("Invalid number !!");
//}

//6=======

//while (true)
//{
//    Console.WriteLine("Otagin uzunlugun dahil edin: ");
//    if (int.TryParse(Console.ReadLine(), out int uzunlug))
//    {
//        Console.WriteLine("Otagin enin dahil edin: ");
//        if (int.TryParse(Console.ReadLine(), out int eni))
//        {
//            Console.WriteLine("Otagin hundurluyun dahil edin: ");
//            if (int.TryParse(Console.ReadLine(), out int hundurluy))
//            {
//                double rest1 = (uzunlug * eni) * 0.2;
//                double rest2 = (uzunlug * eni) - rest1;
//                double boya = rest2 * 0.5;
//                Console.WriteLine("Otagin kvadrati: " + rest2);
//                Console.WriteLine("Otaga lazim olan boya: " + boya + " ml");
//            }
//            else
//            {
//                Console.WriteLine("Invalid number !!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid number !!");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid number !!");
//    }
//}