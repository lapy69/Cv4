using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
            + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
            + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
            + "Toto je jen zkratka zkr. covid ale ne konec vety. A toto je\n"
            + "posledni veta!";

            StringStatistics test = new StringStatistics(testovaciText);

            Console.WriteLine("Number of words: {0}\n", test.Wordn());

            Console.WriteLine("Number of rows: {0}\n", test.Rown());

            Console.WriteLine("Number of senteces: {0}\n", test.Sentencen());

            Console.WriteLine("Longest word(s): ");
            Console.WriteLine(test.Longest());
            Console.WriteLine("\n");

            Console.WriteLine("Shortest word(s): ");
            Console.WriteLine(test.Shortest());
            Console.WriteLine("\n");

            Console.WriteLine("Most used word(s): ");
            Console.WriteLine(test.Most());
            Console.WriteLine("\n");

            Console.WriteLine("Words in alphabetical order: ");
            Console.WriteLine(test.Sortw());
            Console.WriteLine("\n");

            Console.WriteLine("Is string infected with covid-19? ");
            Console.WriteLine(test.IsInfected());
            Console.ReadLine();
        }
    }
}
