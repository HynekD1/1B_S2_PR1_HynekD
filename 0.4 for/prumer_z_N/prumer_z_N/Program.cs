using System.Numerics;

namespace prumer_z_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet_cisel = 0;
            int soucet = 0;
            Console.WriteLine("Kolik chceš vložit čísel(Budeš je muset zadat, tak si to rozmysli)");
            while (!int.TryParse(Console.ReadLine(), out pocet_cisel))
            {
                Console.WriteLine("Zadej celé číslo!!");
            }
            for (int i = 0; i < pocet_cisel; i++)
            {
                int zadane_cislo = 0;
                Console.WriteLine($"Zadej mi {i + 1}. číslo");
                while (!int.TryParse(Console.ReadLine(), out zadane_cislo)) ;
                {
                    Console.WriteLine("Zadej mi celé číslo");
                }
                soucet += zadane_cislo;
            }
            Console.WriteLine($"Průměr ze zadaných čísel je {soucet/pocet_cisel}");

            
            

            


        }
    }
}
