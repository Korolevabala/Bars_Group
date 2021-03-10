using System;
using Class_Car_Bars_group;

namespace exechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            car.Body = "3";
            car.Motor = "120 л.с.";
            car.Oil = "95";
            car.Show();
            Console.ReadKey();
        }
    }
}
