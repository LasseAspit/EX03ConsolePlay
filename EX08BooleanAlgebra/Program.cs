﻿using System;

namespace EX08BooleanAlgebra_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Console.WriteLine(a == b || a > 0); // true
            Console.WriteLine(a + b > 0 && a > 0 ); // true
            Console.WriteLine(a != 5 && a + b > 0); // true
            Console.WriteLine((true || false) && a > b); // false
            Console.WriteLine(3 > 5 && true || a == b); // false
            Console.WriteLine(b > a && true || false || b > 4); // true
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true); // true
            Console.WriteLine(true && false && true); // false
            Console.WriteLine(true || false || false); // true
            Console.WriteLine(false && false); // true
            Console.WriteLine(a == 3 && b > 4 || a + 3 > b ); // true
            Console.WriteLine(a > b && b < a && a + a == b); //false








        }
    }
}
