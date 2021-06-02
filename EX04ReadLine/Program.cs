using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {


            //navn
            Console.WriteLine("skriv venligst dit fornavn");
            string firstName = Console.ReadLine();
            Console.WriteLine("skriv  venligst dit efternavn");
            string lastName = Console.ReadLine();
            Console.WriteLine("srkiv venligst din alder");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"velkommen {firstName} {lastName} du er {age} gammel");


            //areal
            Console.WriteLine("intast de to sider du vil have arealet af");
            Console.WriteLine("intast side 1");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("intast side 2");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"arealet af figuren er {int1 * int2}");


            //ABC

            Console.WriteLine("     AA     \n    A  A    \n   A    A   \n  AAAAAAAA  \n A        A \nA          A");

            Console.WriteLine("BB \nB B\nB  B\nB B\nBB\nB B\nB  B\nB B\nBB");

            Console.WriteLine("     CC\n   CC\n CC\nCC\n CC\n   CC\n     CC");

        }
    }
}
