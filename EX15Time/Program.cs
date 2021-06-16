using System;

namespace EX15Time_
{
    class Program
    {
        static void Main(string[] args)
        {

     
            bool exit = false;
            int år = DateTime.Now.Year;
            DateTime Jul = new DateTime(år, 12, 24, 18, 00, 00);

            if (DateTime.Now.Month >= 6)
            {
                år = år + 1;
            }


            DateTime fødselsdag = new DateTime(år, 6, 12);


 
            while (exit == false)
            {

                
                DateTime tidTimer = DateTime.Now;


                Console.WriteLine("vælg et program at køre: \n");

                Console.WriteLine("A) tiden nu\nB) tid til jul \nC) tid til fødselsdag\nD) tid til specifikt tidspunkt");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "a":
                        Console.WriteLine($"det er i dag den: {tidTimer.ToShortDateString()}");
                        Console.WriteLine($"klokken er nu: {tidTimer.ToShortTimeString()}\n");
                        break;

                    case "b":
                        /*
                        TimeSpan tidTilJul = Jul.Subtract(DateTime.Now);
                        Console.WriteLine(tidTilJul);
                        */

                        TimeSpan tidTilJul = Jul - DateTime.Now;
                        Console.WriteLine($"Der er nu {tidTilJul.Days} dage, {tidTilJul.Hours} timer, {tidTilJul.Minutes} minutter og {tidTilJul.Seconds} sekunder til jul");
                        break;


                    case "c":
                        TimeSpan tidtilfødselsdag = fødselsdag.Subtract(DateTime.Now);
                        Console.WriteLine($"Der er {tidtilfødselsdag.Days} dage og {tidtilfødselsdag.Hours} timer til min fødselsdag.");
                        break;

                    case "d":
                        Console.WriteLine("Skriv venligst den dato du vil vide hvor lang tid der er til, (YYYY, MM, DD)");
                        DateTime brugerTid = DateTime.Parse(Console.ReadLine());
                        TimeSpan brugerTidMath = brugerTid.Subtract(DateTime.Now);
                        Console.WriteLine($"der er {brugerTidMath.Days} dage og {brugerTidMath.Hours} timer til den dato du har skrevet");

                        
                        break;

                    default:
                        Console.WriteLine("unexpected input.... please try again");
                        break;
                }

                Console.WriteLine("Vil du fortsætte? Y/N");
                string fortsæt = Console.ReadLine();
                if (fortsæt == "Y" || fortsæt == "y" || fortsæt == "yes")
                {
                    Console.WriteLine("");
                }
               else
                {
                    exit = true;
                }
               
            }
        }
    }
}
