namespace ConsoleApp1.User
{
    class Class
    {
        class User
        {
            public string Name;
            public decimal Balance;
            public int bilet;
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
                onlineUser = new User { Name = "admin", Balance = 100 };
                Console.WriteLine("Super admin olarak giris yaptiniz !!!");
                islActive = true;
            }
            else
            {
                onlineUser = new User { Name = name, Balance = 100 };
                Console.WriteLine($"{name} adi giris yaptiniz. Balansiniz: {onlineUser.Balance}");
                islActive = false;
            }
            return islActive;
        }

        public void BiletAlmag()
        {
            if(onlineUser.Balance != 0)
            {
                Console.WriteLine("Bilet satin alindi!");
                onlineUser.Balance -= 100;

                Console.WriteLine("Sebete elave etmek y/n");
                string sebet = Console.ReadLine();

                if (sebet == "y")
                {
                    onlineUser.bilet += 1;
                    Console.WriteLine($"{onlineUser.bilet} BiletSebete elave edildi");
                }
            }
            else
            {
                Console.WriteLine("balansinizda kifayet geder balans yoxdur");
            }
        }
        public void BiletIade()
        {
            if(onlineUser.bilet != 0)
            {
                Console.WriteLine("Bilet iade edildi!");
                onlineUser.Balance += 100;
                onlineUser.bilet -= 1;
            }
            else
            {
                Console.WriteLine("Sizde biletiniz yoxdur !!!");
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
    }
}
