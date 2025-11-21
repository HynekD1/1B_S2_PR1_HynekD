using System.Net.Security;

namespace soucet_sudych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soucet = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Zadej mi {i}. číslo");
                int cislo = 0;
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej opravdu číslo!!!");
                }
                if (cislo % 2 == 0)
                {
                    soucet += cislo; 
                }
            }
            Console.WriteLine($"součet sudých čísel je {soucet}");
        }
    }
}
