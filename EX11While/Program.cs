using System;

namespace EX11While
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            

            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\n");

            i = 10;

            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("\n");

            i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i * 2);
                i++;
            }

            i = 1;

            Console.WriteLine("\n");

            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 2;
            }

            Console.WriteLine("\n");
            i = 1;

            Console.WriteLine("indtast nummeret på den tabel du vil have");
            int x = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine(i * x);
                i++;
            }

            i = 1;
            x = 1;





            while (i <= 1 || i > 10)
            {
                Console.WriteLine("indtast et nummer mellem 1 og 10");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
