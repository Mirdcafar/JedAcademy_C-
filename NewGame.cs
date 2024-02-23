int balans = 100;
bool tryi = true;

while (tryi)
{
    string[] sert = { "#", "@", "$" };

    Random random = new Random();

    List<string> selectedElements = new List<string>();

    for (int i = 0; i < 3; i++)
    {
        selectedElements.Add(sert[random.Next(0, sert.Length)]);
    }

    Console.WriteLine(string.Join("", selectedElements));

    Console.WriteLine($"Balans:{balans}");


    if (string.Join("" , selectedElements) == "@@@")
    {
        balans += 100;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else if (string.Join("", selectedElements) == "###")
    {
        balans += 1000;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else if (string.Join("", selectedElements) == "$$$")
    {
        balans += 10000;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else
    {
        Console.WriteLine("Siz uduzdunuz !!!");
        balans -= 100;
    }


    Console.Write("Yenidən oynamaq istəyirsinizmi? (y/n): ");
    string yanit = Console.ReadLine();

    if (balans == 0)
    {
        tryi = false;
    }

    if ( yanit != "y")
    {
        tryi = false;
    }


    Console.Clear(); 
}
