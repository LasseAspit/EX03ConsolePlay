using System;

namespace EX15Time_
{
    class Program
    {
        static void Main(string[] args)
        {

     
            bool exit = false;
            int år = DateTime.Now.Year;
            DateTime Jul = new DateTime(år, 12, 24);

            if (DateTime.Now.Month >= 6)
            {
                år = år + 1;
            }


            DateTime fødselsdag = new DateTime(år, 6, 12);


 
            while (exit == false)
            {

                
                DateTime tidTimer = DateTime.Now;

                Console.WriteLine($"det er i dag den: {tidTimer.ToShortDateString()}");
                Console.WriteLine($"klokken er nu: {tidTimer.ToShortTimeString()}\n");

                Console.WriteLine("vælg et program at køre: \n");

                Console.WriteLine("A) tid til jul \nB) tid til fødselsdag\nC) tid til specifikt tidspunkt");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "a":
                        TimeSpan tidTilJul = Jul.Subtract(DateTime.Now);
                        Console.WriteLine(tidTilJul);
                        break;

                    case "b":
                        TimeSpan tidtilfødselsdag = fødselsdag.Subtract(DateTime.Now);
                        Console.WriteLine(tidtilfødselsdag);
                        break;

                    case "c":
                        Console.WriteLine("skriv venligst den dato du vil vide hvor lang tid der er til, (YYYY, MM, DD)");
                        DateTime brugerTid = DateTime.Parse(Console.ReadLine());
                        TimeSpan brugerTidMath = brugerTid.Subtract(DateTime.Now);
                        Console.WriteLine(brugerTidMath);


                        break;

                    default:
                        Console.WriteLine("unexpected input.... please try again");
                        break;
                }


                exit = true;
            }
        }
    }
}
