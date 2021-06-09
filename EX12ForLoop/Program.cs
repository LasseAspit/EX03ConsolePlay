using System;

namespace EX12ForLoop
{
    class Program
    {

        static Random rand = new Random();


        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 2);
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 2 - 1);
            }


            Console.WriteLine("\n");

            Console.WriteLine("indsæt venligst det nummer du vil have tabbellen på \n");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x * i);
            }




            Console.WriteLine("\n");

            x = 1;


            for(int i = 1; i <= 10; i++)
            {
                
                Console.Write($"{i * x} \t");
                if (i == 10 && x < 10)
                {
                    x++;
                    Console.WriteLine();
                    i = 0;
                }
            }

            Console.WriteLine("\n");

            for (int i = 1; i < 2;)
            {
                int random = rand.Next(1, 7);
                Console.WriteLine(random);

               if(random == 6)
                {
                    i++;
                }
                

                

            }




        }
    }
}

