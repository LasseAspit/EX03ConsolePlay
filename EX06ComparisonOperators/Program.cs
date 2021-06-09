using System;

namespace EX06ComparisonOperators_
{
    class Program
    {
        static void Main(string[] args)
        {

            string exit = "haha";

            while (exit != "exit")
            {



                int a = 2;
                int b = 4;
                Console.WriteLine("are the two values different?");
                Console.WriteLine(a != b);
                Console.WriteLine("is a bigger than b?");
                Console.WriteLine(a > b);
                Console.WriteLine("is b bigger or equal to a");
                Console.WriteLine(a <= b);
                Console.WriteLine("is a+b bigger than 0");
                Console.WriteLine(a + b > 0);
                Console.WriteLine("is a bigger than 1-b");
                Console.WriteLine(a > 1 - b);


                Console.WriteLine("type 'exit' to exit the program, or anything else to continue");
                exit = Console.ReadLine();


            }
        }
    }
}
