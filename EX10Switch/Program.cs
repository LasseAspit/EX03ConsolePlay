using System;

namespace EX10Switch_
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("velkommen til dyrpedia");
            Console.WriteLine("skriv venligst takllet ud for det dyr du gerne vil lære mere om");

            Console.WriteLine("1: gris \n2: Undulat \n3: papegøje \n4: hund \n5: kat");

            string animal;

            animal = Console.ReadLine();


            switch (animal)
            {
                case "gris":
                    Console.WriteLine("https://da.wikipedia.org/wiki/Tamsvin");
                    break;

                case"undulat":
                    Console.WriteLine("https://www.plantorama.dk/guide/dyr/fugle-og-hoens/undulat");
                    break;

                case "papegøje":
                    Console.WriteLine("https://da.wikipedia.org/wiki/Papeg%C3%B8je");
                    break;

                case "hund":
                    Console.WriteLine("https://da.wikipedia.org/wiki/Hund");
                    break;

                case "kat":
                    Console.WriteLine("https://da.wikipedia.org/wiki/Kat");
                    break;

                default:
                    Console.WriteLine("vælg venligst et gyldigt nummer");
                    break;
            }


            Console.WriteLine("skriv en karakter for at få en beskrivelse");

            Console.WriteLine("de danske karakterer er: \n12 \n10 \n7 \n4 \n02 \n00 \n-3");

            int karakter = Convert.ToInt32(Console.ReadLine());

            switch (karakter)
            {
                case 12:
                    Console.WriteLine("12: For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
                    break;
                case 10:
                    Console.WriteLine("10: For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
                    break;
                case 7:
                    Console.WriteLine("7: For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler.");
                    break;
                case 4:
                    Console.WriteLine("4: For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
                    break;
                case 02:
                    Console.WriteLine("02: For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case 00:
                    Console.WriteLine("00: For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case -3:
                    Console.WriteLine("-3: For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
                    break;
                default:
                    Console.WriteLine("ikke gyldigt input");
                    break;
            }




        }
    }
}
