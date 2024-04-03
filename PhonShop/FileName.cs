//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.PhonShop;

//public class FileName
//{
//    public delegate void PhonEvent(Phon titel);
//    static void Main()
//    {
//        List<Phon> phons = new List<Phon>();

//        Xiaomi xiaomi = new Xiaomi("Xiaomi 13T" , 1800 , 31);
//        Samsung samsung = new Samsung("Samsung Z Fold 5" , 4099 , 31);
//        Iphone iphone = new Iphone("Iphone 15 pro" , 3800 , 31);

//        phons.Add(xiaomi);
//        phons.Add(samsung);
//        phons.Add(iphone);

//        Person person = new Person("Thorfin" , 4000);
//        Person person1 = new Person("Askelad" , 3000);
//        Person person2 = new Person("Thors", 2000 );
        

//        foreach (var phon in phons)
//        {
//            if (phon is Xiaomi xiaomis)
//            {
//                phon.phonEvent += person.BuyPhon;
//                person.BuyPhon(phon);
//            }
//            else if (phon is Samsung samsungs)
//            {
//                phon.phonEvent += person1.BuyPhon;
//                person1.BuyPhon(phon);
//            }
//            else if (phon is Iphone iphones)
//            {
//                phon.phonEvent += person2.BuyPhon;
//                person2.BuyPhon(phon);
//            }
//        }
//    }
//}
