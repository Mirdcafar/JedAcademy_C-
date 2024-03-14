namespace ConsoleApp1.ToDoList;

internal class FileName
{
    public static List<Class1> ToDo = new List<Class1>();
    public static void Main()
    {
        bool exit = true;
        while (exit)
        {
            
            Console.WriteLine("1.List Add elemey");
            Console.WriteLine("2.Listi gormek");
            Console.WriteLine("3.List Remove elemey");
            Console.WriteLine("4.List Find elemey");
            Console.WriteLine("5.Cixis");
            Storage storage = new Storage();


            if (int.TryParse(Console.ReadLine(), out int users))
            {
                switch (users)
                {
                    case 1:
                        Console.WriteLine("Id Dahil edin:");

                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            Class1 existingToDo = storage.Find(id);
                            if (existingToDo != null)
                            {
                                Console.WriteLine("Baska bir id dahil edin !!");
                            }
                            else
                            {
                                Console.WriteLine("Tittle Dahil edin:");
                                string title = Console.ReadLine();

                                Class1 toDo1 = new Class1() { Id = id, Tittle = title };

                                storage.Add(toDo1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ancag Regem Dahil ede bilersiz !!");
                        }
                        break;
                    case 2:
                        foreach (var item in ToDo)
                        {
                            Console.WriteLine($"Id: {item.Id} , Tittle: {item.Tittle}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Remove elemey istediyiniz listin id sini Dahil edin ");
                        int index = int.Parse(Console.ReadLine());
                        storage.Remove(index);
                        break;
                    case 4:
                        Console.WriteLine("Ahtarmag istediyiniz listin id sini dahil edin");
                        int ListId = int.Parse(Console.ReadLine());
                        var find = storage.Find(ListId);

                        Console.WriteLine($"id:{find.Id} , Tittle:{find.Tittle}");
                        break;
                    case 5:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Ancag menuda olan regemleri dahil edin !!");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Ancag Regem Dahil edin !!");
            }

            Console.WriteLine("Davam Etmek ucun bir klavisa basin !!");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
