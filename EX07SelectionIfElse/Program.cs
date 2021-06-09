using System;

namespace EX07SelectionIfElse_
{
    class Program
    {
        static void Main(string[] args)
        {



            void rabat()
            {


                //rabat

                Console.Write("indtast det beløb du vil handle for: ");
                double pris = Convert.ToDouble(Console.ReadLine());
                double rabat = 0;
                if (pris > 1000)
                {
                    rabat = pris * 0.05;
                }
                Console.WriteLine($"du får {rabat} i rabat");

            }


            void enstal()
            {
                // ens tal
                Console.WriteLine("velkommen til ens tal :) intast venligst to tal for at få dem sammenlignet");
                Console.Write("indtast venligst det første tal: ");
                double tal1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("indtast venligst det næste tal: ");
                double tal2 = Convert.ToDouble(Console.ReadLine());

                if (tal1 == tal2)
                {
                    Console.WriteLine("de to tal er ens");
                }
                else
                {
                    Console.WriteLine("de to tal er ikke ens");
                }

            }


            void division()
            {
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
            }


            void biggest()
            {

                //største tal

                Console.WriteLine("velkommen til største tal, indtast venligst to tal for at se hvilket der er størst");
                Console.WriteLine("indtast det først tal: ");
                int Biggest1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("indast velingt the næste tal: ");
                int Biggest2 = Convert.ToInt32(Console.ReadLine());

                if (Biggest1 > Biggest2)
                {
                    Console.WriteLine($"det største tal er {Biggest1}");
                }
                else if (Biggest2 > Biggest1)
                {
                    Console.WriteLine($"det største tal er {Biggest2}");
                }
                else if (Biggest1 == Biggest2)
                {
                    Console.WriteLine("de to tal er ens");
                }

            }




            Console.WriteLine("velkommen tíl mit program :) \n vælg venligst en funktion for at starte");

            Console.WriteLine("tast bogstavet på det program du ønsker at starte \nA) velkomst \nB) porto \nC) plusminus \nD) stigende \nE) BMI udregner");


            string chosen = Console.ReadLine();
            //velkomst
            if (chosen == "a")
            {
                Console.WriteLine("skriv venligst dit fornavn");
                string fornavn = Console.ReadLine();
                Console.WriteLine("skriv venligst dit efternavn");
                string efternavn = Console.ReadLine();

                Console.WriteLine($"velkommen {fornavn} {efternavn}");

            }
            // porto
            else if (chosen == "b")
            {
                int price = 0;


                Console.WriteLine("velkommen til porto beregneren. indtast dit brevs vægt (gram) så regner vi ud hvor meget du skal betal");
                double weight = Convert.ToDouble(Console.ReadLine());



                if (weight < 20)
                {
                    price = 5;
                }
                else if (weight > 20 && weight < 50)
                {
                    price = 7;
                }
                else if (weight > 50 && weight < 100)
                {
                    price = 10;
                }
                else if (weight > 100 && weight < 150)
                {
                    price = 15;
                }
                else if (weight > 150 && weight < 200)
                {
                    price = 20;
                }
                else if (weight > 200 || weight == 200)
                {
                    price = 30;
                }
                else
                {
                    price = 123;
                    Console.WriteLine($"det bliver {price}");
                    Console.WriteLine("du har valvgt en ikke gylding vægt");
                }
                Console.WriteLine("vil du have express levering?");
                Console.WriteLine("tast no for nej eller yes for ja");
                string yesno = Console.ReadLine();
                if (yesno == "yes")
                {
                    double prisMedPorto = price * 1.5;

                    Console.WriteLine($"det bliver {prisMedPorto}");
                }
                else
                {
                    Console.WriteLine($"det bliver {price}");
                }
            }
            //plusminus
            else if(chosen == "c")
            {
                //plus minus
                Console.WriteLine("velkommen til plus minus. Indtast et tal så checkker vi om det er over eller under 0");
                Console.Write("indtast dit tal: ");
                int plusminus = Convert.ToInt32(Console.ReadLine());

                if (plusminus > 0)
                {
                    Console.WriteLine($"{plusminus} er et plus tal");
                }
                else if (plusminus == 0)
                {
                    Console.WriteLine("dit tal er nul");
                }
                else
                {
                    Console.WriteLine($"{plusminus} er et negativt tal");
                }
            }
            // stigende
            else if(chosen == "d")
            {
                //stigende orden

                Console.WriteLine("velkommen til stigende tal. Skriv to heltal så sætter vi dem i stigende rækkefølge for dig");
                Console.Write("indtast det første tal: ");
                int stigende1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("indtast det andet tal: ");
                int stigende2 = Convert.ToInt32(Console.ReadLine());


                if (stigende1 > stigende2)
                {
                    Console.WriteLine(stigende2);
                    Console.WriteLine(stigende1);
                }
                else
                {
                    Console.WriteLine(stigende1);
                    Console.WriteLine(stigende2);
                }

            }
            //BMI
            else if(chosen == "e")
            {
                Console.WriteLine("velkommen til BMI udregneren");

                Console.WriteLine("indtast venligst din vægt: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("indatast venligst din højde i meter: ");
                double height = Convert.ToDouble(Console.ReadLine());


                double BMI = weight / (height * height);


                if(BMI < 18.5)
                {
                    Console.WriteLine("du vejer for lidt");
                }
                else if(BMI > 18.5 && BMI < 25)
                {
                    Console.WriteLine("din vægt er passende");
                }
                else if (BMI > 25 && BMI < 30)
                {
                    Console.WriteLine("du er overvægtig");
                }
                else if (BMI > 30)
                {
                    Console.WriteLine("du er overvægtig");
                }
                else
                {
                    Console.WriteLine("svar ikke glydigt");
                }
            }


            else
            {
                Console.Write("indtast venligt et gyldigt bostav");

            }

        }
    }
}
