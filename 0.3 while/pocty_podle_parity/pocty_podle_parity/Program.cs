using System.Globalization;

namespace pocty_podle_parity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            int sude = 0;
            int liche = 0;
            do
            {
                Console.WriteLine("Zadej číslo, pro ukončení zadej nulu nebo záporné číslo");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo!!!!!");
                }

                if (cislo % 2 == 0 && cislo > 0)
                {
                    sude++;
                }else if (cislo % 2 == 1 && cislo > 0)
                {
                    liche++;
                }
            } while (cislo > 0);
            Console.WriteLine($"Celkem jsi zadal {sude} sudích čísel a {liche} lihích čísel");
        }
    }
}
