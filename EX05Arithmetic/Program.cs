using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velkommen til lommeregner v1 \nvenligst indtast de 2 numre du vil have lagt sammen\n");
            Console.Write("intast tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("intast tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nresultatet af at lægge de to tal sammen er: {tal1 + tal2}");
            Console.WriteLine($"resultatet af at trække de to tal fra hinanden er: {tal1 - tal2}");
            Console.WriteLine($"resultatet af at gange de to tal er: {tal1 * tal2}");
            Console.WriteLine($"resultatet af at dividere de to tal er : {tal1 / tal2}");
            Console.WriteLine($"resultatet af at modulo de to tal er : {tal1 % tal2}");


        }
    }
}
