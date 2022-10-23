using System;

namespace Uppgift4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en ett tal");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ord slut om du vill avsluta eller ord fort om du vill fortsata");
            string svar = Console.ReadLine();

            if (svar == "fort")
            {
                Console.WriteLine("Skriv en ett tal");
                int tal2 = int.Parse(Console.ReadLine());

                while (svar == "fort")
                {

                 Console.WriteLine("Skriv in ord slut om du vill avsluta eller ord fortsat om du vill fortsata");
                    svar = Console.ReadLine();

                 if (svar == "fort")
                 {
                        Console.WriteLine("Skriv en ett tal");
                            tal2 = int.Parse(Console.ReadLine());
                 }
                 else if(svar == "slut")
                 {
                     break;
                 }

                }
                 if(tal2 > tal)
                 {
                     Console.WriteLine("Den storsta tall ar " + tal2 + ".");
                 }
                 else if (tal2 < tal)
                 {
                     Console.WriteLine("Den storsta tall ar " + tal + ".");
                 }
            }
            else if (svar == "slut")
            {
               Console.WriteLine("Den storsta tall ar " + tal + ".");
            }
        }
    }
}
