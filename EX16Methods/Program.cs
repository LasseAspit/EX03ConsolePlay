using System;

namespace EX16Methods_
{
    class Program
    {


        private static void sigHej(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        private static void sigFarvel(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
        }

        private static int dobbelt(int number)
        {
            return number * 2;
        }
        
        private static int addition(int a, int b)
        {
            return a + b;
        }

        private static int størst(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        private static string arrPrint(string[] strings)
        {
            foreach(string value in strings)
            {
                Console.WriteLine(value);
            }
            return "";
        }

        
            

        static void Main(string[] args)
        {

            sigHej("Daniel");
            sigFarvel("Kristian");
            Console.WriteLine($"Det dobbelte af 10 er: {dobbelt(10)}");
            Console.WriteLine($"Summen af de to tal er: {addition(2, 5)}");
            Console.WriteLine($"Det største af de to tal er {størst(2, 5)}");

            string[] str = {"hello", "hi", "goodbye"};

            arrPrint(str);


        }
    }
}
