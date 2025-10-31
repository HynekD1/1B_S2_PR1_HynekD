using System.Text.RegularExpressions;

namespace generovani_random_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generace náhodných čísel

            //Musíte si vytvořit generátor
            //Generator stačí v jendom kodu jen jednou
            //dle jaho názvu (Random nazev = new Random()) se volá v kodu
            Random generator = new Random();

            //Jak s generátorem generovat náhodná čísla?
            //název.Next(spodní hranice (včetně), horní hranice (bez))
            Console.WriteLine(generator.Next(0, 2)); //0-1
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));

            int kostka = generator.Next(1,7);  // 1-6
            Console.WriteLine($"Hod 6stěnné kostky má výsledek {kostka}");

            //Zvláštnosti
            Console.WriteLine(generator.NextDouble()); // 0-1 (double)

        }
    }
}
