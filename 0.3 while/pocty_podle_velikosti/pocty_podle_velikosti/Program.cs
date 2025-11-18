using System.Net.Security;

namespace pocty_podle_velikosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jedna_cifra = 0;
            int dve_cifry = 0;
            int troj_cifra = 0;
            int vetsi_cifra = 0;

            double vstup = 0;
            do
            {
                Console.WriteLine("Zadej mi číslo. Pro ukončení zadej 0, čí záporné číslo");
                while (!double.TryParse(Console.ReadLine(), out vstup))
                {
                    Console.WriteLine("Zadej číslo");
                }

                switch (vstup)
                {
                    case double v when v > 0 && v < 10:
                        jedna_cifra++;
                        break;
                    case double v when v > 9 && v < 100:
                        dve_cifry++;
                        break;
                    case double v when v > 99 && v < 1000:
                        troj_cifra++;
                        break;
                    case double v when v > 999:
                        vetsi_cifra++;
                        break;
                }

            } while (vstup > 0);
            Console.WriteLine($"Počet jednociferných čísel byl {jedna_cifra} \nPočet dvouciferných čísel byl {dve_cifry} \nPočet trojciferných čísel byl {troj_cifra} \nPočet víc jak trojciferných čísel byl {vetsi_cifra}");
        }
    }
}
