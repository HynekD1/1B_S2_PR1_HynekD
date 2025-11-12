using System.Xml.Serialization;

namespace hra_nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sirky = 21;
            char hrac = 'A';
            int pocet_sirek = 0;
            while (sirky > 0)
            {

                Console.WriteLine($"na tahu je hrač: {hrac}");
                Console.WriteLine($"zbývá {sirky} sirek, kolik jich chceš vytáhnout? (1-3)");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out pocet_sirek))
                    {
                        Console.WriteLine("Zadej číslo!!!");

                    }
                } while (!((pocet_sirek >= 1 && pocet_sirek <= 3) && pocet_sirek <= sirky));

                sirky -= pocet_sirek;
                if (hrac == 'A')
                {
                    hrac = 'B';
                }
                else
                {
                    hrac = 'A';
                }

            }
            Console.WriteLine($"Vyhrál hráč {hrac}");
        }
    }
}
