using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.PhonShop.FileName;

namespace ConsoleApp1.PhonShop;

public class Xiaomi : Phon
{
    private int time { get; set; }
    public Xiaomi(string marka, int price, int time) : base(marka, price, time)
    {

    }

    public override string GetPhoneInfo()
    {
        return $"Marka:{Marka} Price: {Price}, Stock: {time}";
    }
    public override int ComingTime
    {
        get => time;
        set
        {
            int times = DateTime.Now.Day;
            time = value;
            if (time == times)
            {
                Console.WriteLine($"Marka:{Marka} Stoka geldi !!!");
                phonEvent?.Invoke(this);

            }
        }
    }
    public override event PhonEvent phonEvent;

    public override void Buy(int price)
    {

        if (Price <= price)
        {
            Console.WriteLine($"{Marka} telefonu aldiniz");
            price -= Price;
            Console.WriteLine($"Qalan balans: {price}");
        }
        else
        {
            Console.WriteLine("Balansinizda yeterince mebleg yohdur !!!");
        }
    }
}
