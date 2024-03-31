using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ConsoleApp1.PhonShop.FileName;

namespace ConsoleApp1.PhonShop;

public abstract class Phon
{

    public Phon(string marka, int price, int comingTime)
    {
        Marka = marka;
        Price = price;
        this.ComingTime = comingTime;
    }
    public string Marka { get; set; }
    public int Price { get; set; }
    public abstract int ComingTime { get; set; }
    public abstract event PhonEvent phonEvent;
    public abstract void Buy(int price);
    public abstract string GetPhoneInfo();


}
