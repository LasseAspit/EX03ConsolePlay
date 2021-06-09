using System;

namespace EX09BooleanIf_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            int a = 1;

            int b = 2;

            int c = 3;
           
            if( a == 1)
            {
                x = 1;
            }
            if (b == 1)
            {
                x = 2;
            }
            if(c == 3)
            {
                x = 3;
            }
            // x er 3 da det er den sidste value den blev assigned
            Console.WriteLine($"x er: {x}");

            x = 0;

            if(a != 1)
            {
                x = 1;
            }
            else if (b == 2)
            {
                x = 2;
            }
            else if (c == 3)
            {
                x = 3;
            }

            // x er 2 da det er den første true value i else if kæden

            Console.WriteLine($"x er: {x}");

            x = 0;

            if (a == 2)
            {
                x = 1;
                if (b == 2)
                {
                    x = 2;
                }
            }
            else if (c == 1)
            {
                x = 3;
            }

            // x er 0 da ingen statements are true

            Console.WriteLine($"x er: {x}");


            x = 0;


            if( a + b == b)
            {
                x = 1;
            }
            else
            {
                if(b - a == a)
                {
                    x = 2;
                }
                if(c - b == b)
                {
                    x = 3;
                }
            }
            // x er 2 da b - a = a
            Console.WriteLine($"x er: {x}");



        }
    }
}
