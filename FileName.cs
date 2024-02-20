
//==========

//int[] arr = new int[5] { 11, 20, 31, 40, 50 };

//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 2; j <= arr[i]; j++)
//    {
//        if (j % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//    count = 0;
//}


//========

//Random random = new Random();

//int[,] numbers = new int[3, 10];


//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        numbers[i, j] = random.Next(1, 101);
//        Console.Write(numbers[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//1==========

//Random random = new Random();
//int[] num = new int[10];

//for (int i = 0; i < num.Length; i++)
//{
//    num[i] = random.Next(1, 101);
//}

//Console.WriteLine("Original array:");
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//}

//for (int i = 0; i < num.Length - 1; i++)
//{
//    for (int j = 0; j < num.Length - i - 1; j++)
//    {
//        if (num[j] > num[j + 1])
//        {
//            int temp = num[j];
//            num[j] = num[j + 1];
//            num[j + 1] = temp;
//        }        

//    }
//}

//Console.WriteLine("Sorted array:");

//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//}

//2=============
//while (true)
//{
//    Console.WriteLine("Tələbənin adını daxil edin (çıxmaq üçün 'exit' yazın):");
//    string name = Console.ReadLine();

//    if (name.ToLower() == "exit")
//    {
//        break;
//    }

//    Console.WriteLine("Online və ya Offline olduğunu qeyd edin:");
//    string status = Console.ReadLine().ToLower();

//    if (status == "online" || status == "offline")
//    {
//        Console.WriteLine($"{status} and {name}");
//    }
//    else
//    {
//        Console.WriteLine("Yanlış status! Yalnız 'online' və ya 'offline' daxil edin.");
//    }
//}

//3=============
int rows = 5; 
int cols = 5;

char[,] array = new char[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = '*';
    }
    
}

int centerRow = rows / 2;
int centerCol = cols / 2;
array[centerRow, centerCol] = '+';

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

