namespace ConsoleApp1.User
{
    class Class
    {
        class User
        {
            public string Name;
            public decimal Balance;
            public int sebetdekiBiletSayi;
        }

        private List<User> Users;
        private User onlineUser;

        public bool Giris(ref bool islActive)
        {
            Console.WriteLine("Adinizi dahil edin :");
            string name = Console.ReadLine();

            Console.WriteLine("Pini dahil edin :");
            int pin = int.Parse(Console.ReadLine());

            if (name == "admin" && pin == 123)
            {
                onlineUser = new User { Name = "admin", Balance = 500 };
                Console.WriteLine("Super admin olarak giris yaptiniz !!!");
                islActive = true;
            }
            else
            {
                onlineUser = new User { Name = name, Balance = 500 };
                Console.WriteLine($"{name} adi giris yaptiniz. Balansiniz: {onlineUser.Balance}");
                islActive = false;
            }
            return islActive;
        }

        public bool BiletCount()
        {
            if (onlineUser.sebetdekiBiletSayi > 0)
            {
                return true;
            }
            return false;
        }


        public void BiletIade(int price)
        {
            if (onlineUser.sebetdekiBiletSayi != 0)
            {
                Console.WriteLine("Bilet iade edildi!");
                onlineUser.Balance += price;
                onlineUser.sebetdekiBiletSayi -= 1;
            }
        }
        public void Balance()
        {
            Console.Write("Yatirmak istediginiz miktarı girin: ");
            decimal NewBalance = decimal.Parse(Console.ReadLine());
            onlineUser.Balance += NewBalance;
            Console.WriteLine($"Yeni bakiyeniz: {onlineUser.Balance}");
        }

        public void VievBalance()
        {
            Console.WriteLine($"Sizin balansiz : {onlineUser.Balance}");
        }

        public void Decrement()
        {

            if (onlineUser.sebetdekiBiletSayi != 0)
            {
                onlineUser.sebetdekiBiletSayi--;
            }
        }

        public int BiletAdd(int price)
        {
            if (onlineUser.Balance != 0)
            {
                onlineUser.sebetdekiBiletSayi++;
                onlineUser.Balance -= price;
            }
            return price;
        }

    }
}
