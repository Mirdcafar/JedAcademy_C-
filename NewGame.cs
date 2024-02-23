int balans = 0;
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


    if (string.Join("" , selectedElements) == "@@@")
    {
        balans += 100;
        tryi = false;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else if (string.Join("", selectedElements) == "###")
    {
        balans += 1000;
        tryi = false;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else if (string.Join("", selectedElements) == "$$$")
    {
        balans += 10000;
        tryi = false;
        Console.WriteLine("Siz udtunuz !!!");
    }
    else
    {
        Console.WriteLine("Siz uduzdunuz !!!");
        tryi = false;
    }

    Console.WriteLine("Balans: " + balans);
}
