//using System;
//using System.Collections.Generic;

//namespace ConsoleApp1.Cars
//{
//    public class FileName
//    {
//        public static void Main()
//        {
//            List<Car> Cars = new List<Car>();

//            Audi audi = new Audi();
//            audi.Model = "i8";
//            audi.Color = "Black";
//            audi.Speed = 250;
//            audi.NumberOfDoors = 2;
//            audi.QuattroModel = true;

//            Bmw bmw = new Bmw();
//            bmw.Model = "m5 f90";
//            bmw.Color = "Black";
//            bmw.Speed = 308;
//            bmw.NumberOfDoors = 4;
//            bmw.HasXDrive = true;

//            Cars.Add(audi);
//            Cars.Add(bmw);

//            foreach (var car in Cars)
//            {
//                Console.WriteLine(car.ToString());

//                if (car is Audi)
//                {
//                    var audiCar = (Audi)car;
//                    Console.WriteLine($"QuattroModel: {audiCar.QuattroModel}");
//                }
//                else if (car is Bmw)
//                {
//                    var bmwCar = (Bmw)car;
//                    Console.WriteLine($"HasXDrive: {bmwCar.HasXDrive}");
//                }

//                Console.WriteLine(); // Boş bir satır ekleyelim
//            }
//        }
//    }
//}
