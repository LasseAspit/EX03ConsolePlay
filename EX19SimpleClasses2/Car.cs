using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19SimpleClasses2
{
    class Car
    {
        public string Make { get; set; }  
        private string Model { get; set; }
        private string Color { get; set; }
        private int Price { get; set; }
        private bool IsSold { get; set; }

        private bool IsOnSale;

        public Car(string make, string model, string color, int price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }



        public void PrintInfo()
        {
            if (IsSold)
            {
                Console.WriteLine($"SOLGT! bilen er en {Make} {Model} i farven {Color}. prisen er {Price}");
            }

            else
            {
                Console.WriteLine($"bilen er en {Make} {Model} i farven {Color}. prisen er {Price}");
            }
        }


        public void PutOnSale()
        {
            IsOnSale = true;
            Price = Price - (Price / 10);
        }


    }
}
