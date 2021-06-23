using System;
using System.IO;
using System.Collections.Generic;

namespace EX20StreamReader_
{
    class Program
    {
            

       

        static void Main(string[] args)
        {
            
            static List<double> getNumbers(string url)
            {
                List<double> longList = new List<double>();

                using (StreamReader sr = new StreamReader(url))
                {

                    string line;

                    while (sr.EndOfStream != true)
                    {
                        line = sr.ReadLine();

                        double lineDouble = Convert.ToDouble(line);
                        longList.Add(lineDouble);


                        /*
                        counter++;
                        sum = sum + Convert.ToDouble(line);
                        */
                    }



                }
                return longList;
            }

            

            List<double> list = getNumbers("Values.txt");

            foreach(double value in list)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("");

            List<string> list2 = new List<string>();
            using (StreamReader sr = new StreamReader("Boxes.txt"))
            {

                string line;
                List<Box> boxlist = new List<Box>();
                while (sr.EndOfStream != true)
                {
                    line = sr.ReadLine();
                    list2.Add(line);
                    Console.WriteLine(line);
                    foreach (string value in list2)

                    {
                        string[] arr = value.Split(',');
                        Box box = new Box(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
                        boxlist.Add(box);
                    }
                } 

            foreach(Box value in boxlist)
                {
                    value.PrintInfo();
                    Console.WriteLine("");
                }
            }


            


        }
    }
}
