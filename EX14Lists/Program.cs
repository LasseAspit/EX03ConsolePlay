using System;
using System.Collections.Generic;

namespace EX14Lists_
{
    class Program
    {
        static void Main(string[] args)
        {
            // opg 14.1

            List<int> ages = new List<int>();

            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);



            List<String> names = new List<string>();

            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");


            // opg 14.2

            List<double> percentage = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            List<bool> isMarried = new List<bool>() { true, false, false, true, true };

            // opg 14.3

            foreach (Double value in percentage)
            {
                Console.WriteLine("Age is: " + value);
            }

            foreach (bool value in isMarried)
            {
                Console.WriteLine("is married?: " + value);
            }



            // opg 14.4

            List<string> navne = new List<string>() {"Hans", "Kristian", "Jens", "Karsten", "Ib"};

            foreach(string value in navne)
            {
                Console.Write(value + "    ");
            }

            Console.WriteLine("");

            navne.Insert(3, "Anders");

            navne.Insert(2, "Lars");

            foreach (string value in navne)
            {
                Console.Write(value + "    ");
            }

            Console.WriteLine("");



            // opg 14.5

            List<int> aldre = new List<int>() {13, 14, 13, 15, 13, 14, 14, 15};

            foreach (int value in aldre)
            {
                Console.Write(value + "    ");
            }
            Console.WriteLine("");

            aldre.Remove(13);
            aldre.Remove(15);

            foreach (int value in aldre)
            {
                Console.Write(value + "    ");
            }

            Console.WriteLine("");

            aldre.RemoveAt(2);


            foreach (int value in aldre)
            {
                Console.Write(value + "    ");
            }
        }
    }
}
