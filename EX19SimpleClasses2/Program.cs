using System;

namespace EX19SimpleClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Dacia", "Logan", "Beige", 170000, false);
            Car car2 = new Car("Toyota", "Yaris", "Rød", 89000, true);
            Car car3 = new Car("Honda", "Civic", "Hvid", 199000, false);


            Console.WriteLine(car3);

            car1.PutOnSale();

            car1.PrintInfo();
            car2.PrintInfo();



        }
    }
}
