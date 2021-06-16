using System;
using CarHandler;
using System.Collections.Generic;

namespace EX17Objects_
{
    class Program
    {

        



        static void Main(string[] args)
        {


            Car car1 = new Car("ford", "Mustang", 1966, "rød");
            Car car2 = new Car("porsche", "911", 2004, "sølv");

            List<Car> cars = new List<Car>();

            cars.Add(car1);
            cars.Add(car2);


            Console.WriteLine("\n\nVelkommen til biladminstrationen");
            Console.WriteLine("Ønsker du \n(1) at indtaste en ny bil?\n(2) se information om alle biler?\n(3) søge efter bilmærke?\n(4) se hvor god en bil er til at starte");

            Console.Write("Indtast nu tallet på den function du vil køre: ");

            string valg = Console.ReadLine();
            
            if(valg == "1")
            {
                Console.Write("Indtast bil producent: ");
                string producent = Console.ReadLine();
                Console.Write("Indtast bil model: ");
                string model = Console.ReadLine();
                Console.Write("Indtast bilens årgang: ");
                int årgang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast bilens farve");
                string farve = Console.ReadLine();

                Car car3 = new Car(producent, model, årgang, farve);

                cars.Add(car3);

                Console.WriteLine(car3.GetInfo());

                

            }
            else if(valg == "2")
            {
                foreach (Car c in cars)
                {
                    Console.WriteLine(c.GetInfo());
                }
            }
            else if(valg == "3")
            {
                Console.WriteLine("Indtast mærket du vil søge efter");
                string search = Console.ReadLine();

                foreach (Car c in cars)
                {
                    if (search == c.Make)
                    {
                        Console.WriteLine(c.GetInfo());
                    }
                    else
                    {
                        Console.WriteLine($"{c} er ikke en {search}");
                    }
                }

            }
            else if(valg == "4")
            {
                Console.WriteLine("Indtast tallet på den bil du vil søge efter");
                
                foreach(Car c in cars)
                {
                    Console.WriteLine(c.GetInfo());
        
                }
                Console.WriteLine("Skriv hvilket nummer den bil du vil starte har i listen");
                int bilvalg = Convert.ToInt32(Console.ReadLine()) - 1;


                if(cars[bilvalg].StartCar() == true)
                {
                    Console.WriteLine("Blien startede på første forsøg");
                }
                else
                {
                    Console.WriteLine("bilen startede ikke");
                }

            }





        }

    }
}
