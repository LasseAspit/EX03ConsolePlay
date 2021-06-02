using System;

namespace EX07SelectionIfElse_
{
    class Program
    {
        static void Main(string[] args)
        {
            //rabat
            /*
            Console.Write("indtast det beløb du vil handle for: ");
            double pris = Convert.ToDouble(Console.ReadLine());
            double rabat = 0;
            if (pris > 1000)
            {
                rabat = pris * 0.05;
            }
            Console.WriteLine($"du får {rabat} i rabat");


            // ens tal
            Console.WriteLine("velkommen til ens tal :) intast venligst to tal for at få dem sammenlignet");
            Console.Write("indtast venligst det første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("indtast venligst det næste tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            if(tal1 == tal2)
            {
                Console.WriteLine("de to tal er ens");
            }
            else
            {
                Console.WriteLine("de to tal er ikke ens");
            }


            //division
            Console.WriteLine("indtast to tal for at dividere");
            Console.Write("indtast tal 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("indtast tal 2: "); 
            int input2 = Convert.ToInt32(Console.ReadLine());

            if (input2 == 0)
            {
                Console.WriteLine("du kan ikke dividere med 0");
            }
            else
            {
                Console.WriteLine($"hvis du dividerer de to tal får du: {input1 / input2}");
            }

            //største tal

            Console.WriteLine("velkommen til største tal, indtast venligst to tal for at se hvilket der er størst");
            Console.WriteLine("indtast det først tal: ");
            int Biggest1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("indast velingt the næste tal: ");
            int Biggest2 = Convert.ToInt32(Console.ReadLine());

            if(Biggest1 > Biggest2)
            {
                Console.WriteLine($"det største tal er {Biggest1}");
            }
            else if (Biggest2 > Biggest1)
            {
                Console.WriteLine($"det største tal er {Biggest2}");
            }
            else if(Biggest1 == Biggest2)
            {
                Console.WriteLine("de to tal er ens");
            }


            //stigende orden

            Console.WriteLine("velkommen til stigende tal. Skriv to heltal så sætter vi dem i stigende rækkefølge for dig");
            Console.Write("indtast det første tal: ");
            int stigende1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("indtast det andet tal: ");
            int stigende2 = Convert.ToInt32(Console.ReadLine());


            if(stigende1 > stigende2)
            {
                Console.WriteLine(stigende2);
                Console.WriteLine(stigende1);
            }
            else
            {
                Console.WriteLine(stigende1);
                Console.WriteLine(stigende2);
            }

            //plus minus
            Console.WriteLine("velkommen til plus minus. Indtast et tal så checkker vi om det er over eller under 0");
            Console.Write("indtast dit tal: ");
            int plusminus = Convert.ToInt32(Console.ReadLine());

            if(plusminus > 0)
            {
                Console.WriteLine($"{plusminus} er et plus tal");
            }
            else if(plusminus == 0)
            {
                Console.WriteLine("dit tal er nul");
            }
            else
            {
                Console.WriteLine($"{plusminus} er et negativt tal");
            }

            */
            //porto
            
            Console.WriteLine("velkommen til porto beregneren. indtast dit brevs vægt (gram) så regner vi ud hvor meget du skal betal");
            int vægt = Convert.ToInt32(Console.ReadLine());
            int pris;
            if(vægt < 20)
            {
                pris = 5;
            }
            else if (vægt > 20  && vægt < 50)
            {
                pris = 7;
            }
            else if (vægt > 50 && vægt < 100)
            {
                pris = 10;
            }
            else if (vægt > 100 && vægt < 150)
            {
                pris = 15;
            }
            else if (vægt > 150 && vægt < 200)
            {
                pris = 20;
            }
            else if(vægt < 200)
            {
                pris = 30;
            }
            
            Console.WriteLine("vil du have express levering?");
            Console.WriteLine("tast no for nej eller yes for ja");
            string yesno = Console.ReadLine();
            if (yesno == "yes")
            {
                Console.WriteLine($"det bliver {pris}");
            }
            else
            {
                Console.WriteLine($"det bliver {pris}");
            }




        }
    }
}
