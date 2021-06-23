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




            /*


            double sum = 0;
            double counter = 0;

            List<double> values = new List<double>();
            

            using (StreamReader sr = new StreamReader("Values.txt"))
            {

                string line;

                while(sr.EndOfStream != true)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);

                    double lineDouble = Convert.ToDouble(line);
                    values.Add(lineDouble);


                    
                    counter++;
                    sum = sum + Convert.ToDouble(line);
                    
                }



            }
            
            Console.WriteLine("");
            Console.WriteLine($"Summen er: {sum}");
            Console.WriteLine($"Gennemsnittet er: {sum / counter}");
            

            foreach(double value in values)
            {
                sum = sum + value;
                counter++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum /counter);

            */


            List<double> list = getNumbers("Values.txt");

            foreach(double value in list)
            {
                Console.WriteLine(value);
            }



        }
    }
}
