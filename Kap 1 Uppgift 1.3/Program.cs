using System;
namespace Uppgift1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriver ut triangeln
            Console.WriteLine(
                "   /\\ \n" + //\n skapar en ny rad i texten
                "  /  \\ \n" +
                " /    \\ \n" +
                "/______\\ \n"
                );

            //Läser av en tangent
            Console.ReadKey();
        }
    }
}