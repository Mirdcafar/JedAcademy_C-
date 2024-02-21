
//1==========
//bool choose = true;

//while (choose)
//{
//    Console.WriteLine("1-4 geder regem secin");
//    Console.WriteLine("1 Yeni oyun"); Console.WriteLine("2 Oyun davam edir");
//    Console.WriteLine("3 Oyun parametirler"); Console.WriteLine("4 Cihis");
//    string secim = Console.ReadLine();
//    switch (secim)
//    {
//        case "1":
//            Console.WriteLine("1 Yeni oyun");
//            break;
//        case "2":
//            Console.WriteLine("2 Oyun davam edir"); break;
//        case "3":
//            Console.WriteLine("3 Oyun parametirler");
//            break;
//        case "4":
//            Console.WriteLine("4 Cihis"); choose = false;
//            break;
//        default:
//            Console.WriteLine("Yanlis regem"); break;
//    }
//}


//2=======


Console.WriteLine("saati dahil et");
if (Int32.TryParse(Console.ReadLine(), out int saat))
{
    Console.WriteLine("deyge dahil et");
    if (Int32.TryParse(Console.ReadLine(), out int deyge))
    {
        if (0 <= saat && saat < 24 && 0 <= deyge && deyge < 60)
        {
            if (5 <= saat && saat < 12)
            {
                Console.WriteLine("Seheriniz heyir !!!");
            }
            else if (12 <= saat && saat < 18)
            {
                Console.WriteLine("Ginortaniz heyir !!!");
            }
            else if (18 <= saat && saat < 23)
            {
                Console.WriteLine("Axsaminiz heyir !!!");
            }
        }
        else
        {
            Console.WriteLine("Invalid number !!!");
        }
    }
    else
    {
        Console.WriteLine("Invalid number !!!");
    }
}
else
{
    Console.WriteLine("Invalid number !!!");
}

//3==========

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Oyun kartının seriya nömrəsini daxil edin (0-dan 35-ə qədər): ");
//        int seriyaNomresi = Convert.ToInt32(Console.ReadLine());

//        string kostyum = (seriyaNomresi <= 17) ? "A" : "B";
//        int deyer = (seriyaNomresi <= 17) ? 10 : 20;

//        Console.WriteLine($"Kartın kostyumu: {kostyum}");
//        Console.WriteLine($"Kartın dəyəri: {deyer}");
//    }
//}


//4============

//double[] massiv = { 2, 5, 8, 12, 15, 20.5, 25, 30, 40, 50.5 };

//for (int i = 0; i < massiv.Length; i++) { 

//    double element = massiv[i];

//    if (element % 1 == 0)
//    {
//        Console.WriteLine($"{element} element kesir deyil !!!");
//    }
//    else
//    {
//        Console.WriteLine($"{element} element kesirdi !!!");
//    }
//}


//5==============


//int[] massiv = new int[20];

//for (int i = 0; i < 20; i++)
//{
//    massiv[i] = new Random().Next(1, 201);
//}

//int bir = 0;
//int iki = 0;
//int uc = 0;

//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] < 10)
//    {
//        bir++;
//    }
//    else if (massiv[i] < 100)
//    {
//        iki++;
//    }
//    else if (massiv[i] < 200)
//    {
//        uc++;
//    }
//}
//double ucReqeminNisbeti = (double)uc / massiv.Length * 100;

//Console.WriteLine($"3 rəqəmli ədədin sayı: {uc}, Faizi: {ucReqeminNisbeti}%");

//6============
//int[] massiv = new int[20];

//for (int i = 0; i < 20; i++)
//{
//    massiv[i] = new Random().Next(1, 101);
//}

//int sel = 0;

//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] % 1 == 0)
//    {
//        sel++;
//    }
//}


//Console.WriteLine(sel);

//7============

//int[] massiv = new int[10];

//for (int i = 0; i < massiv.Length; i++)
//{
//    massiv[i] = new Random().Next(1, 101);
//}

//Console.WriteLine("Original");

//for (int i = 0; i < massiv.Length; i++)
//{
//    Console.Write($"{massiv[i]} ");
//}

//Console.WriteLine("New");

//for (int i = massiv.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{massiv[i]} ");
//}

//8===============


//int[] massiv = new int[10];
//Random random = new Random();

//for (int i = 0; i < massiv.Length; i++)
//{
//    massiv[i] = random.Next(1, 100);
//    Console.Write(massiv[i] + " ");
//}

//Console.WriteLine();

//for (int i = 0; i < massiv.Length - 1; i += 2)
//{
//    (massiv[i], massiv[i + 1]) = (massiv[i + 1], massiv[i]);
//}

//for (int i = 0; i < massiv.Length; i++)
//{
//    Console.Write(massiv[i] + " ");
//}
