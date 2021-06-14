using System;

namespace EX13Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = {25, 28, 15, 35, 14};


            // udskriv heltal
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(heltal[i]);
            }

            string[] navne = new string[4] {"Lasse", "Dima", "Kasper", "Kristian" };

            // udsrkiv navne
            for (int i = 0; i < navne.Length; i++)
            {
                Console.Write(navne[i] + "\t");
            }

            navne[3] = "kong kristian";
            Console.WriteLine("");

            // udskriv navne + kong
            for (int i = 0; i < navne.Length; i++)
            {
                Console.Write(navne[i] + "\t");
            }

            Console.WriteLine("");
            int[] numbers = new int[10]{ 7, 79, 95, 73, 78, 18, 76, 80, 60, 21};
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }


        }
    }
}
