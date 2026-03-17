using System.Security.Cryptography;
namespace bludiste
{
    internal class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            //mapa
            string[,] bludiste =
            {
                {"P", "#", "#", "#", "#", "#", "#", "#"},
                {"V", "V", "V", "V", "V", "#", "X", "#"},
                {"#", "#", "V", "#", "V", "#", "V", "#"},
                {"#", "#", "#", "V", "V", "#", "V", "#"},
                {"#", "#", "V", "V", "V", "V", "V", "#"},
                {"#", "V", "V", "#", "#", "#", "V", "#"},
                {"#", "#", "V", "V", "V", "#", "V", "#"},
                {"#", "#", "#", "#", "#", "#", "#", "#"}
            };

            PohybHrace(bludiste);
        }

        //metoda na pohyb
        static void PohybHrace(string[,] mapa)
        {
            bool konec = false;

            while (!konec)
            {
                Console.Clear();
                VypisMapy(mapa);

                Console.WriteLine("Kam chceš jít?");
                Console.WriteLine("W = nahoru | S = dolu | A = doleva | D = doprava");

                string vstup = Console.ReadLine().ToUpper();

                int hracX = 0;
                int hracY = 0;

                // Najdeme hráče
                for (int i = 0; i < mapa.GetLength(0); i++)
                {
                    for (int j = 0; j < mapa.GetLength(1); j++)
                    {
                        if (mapa[i, j] == "P")
                        {
                            hracX = i;
                            hracY = j;
                        }
                    }
                }

                int novyX = hracX;
                int novyY = hracY;

                // Směr pohybu
                if (vstup == "W") novyX--;
                else if (vstup == "S") novyX++;
                else if (vstup == "A") novyY--;
                else if (vstup == "D") novyY++;
                else
                {
                    Console.WriteLine("Neplatný vstup!");
                    Console.ReadKey();
                    continue;
                }

                // Kontrola hranic
                if (novyX < 0 || novyX >= mapa.GetLength(0) ||
                    novyY < 0 || novyY >= mapa.GetLength(1))
                {
                    Console.WriteLine("TAM NEMŮŽEŠ!");
                    Console.ReadKey();
                    continue;
                }

                // Kontrola pole
                if (mapa[novyX, novyY] == "V")
                {
                    mapa[hracX, hracY] = "V";
                    mapa[novyX, novyY] = "P";
                }
                else if (mapa[novyX, novyY] == "X")
                {
                    mapa[hracX, hracY] = "V";
                    mapa[novyX, novyY] = "P";
                    Console.Clear();
                    VypisMapy(mapa);
                    Console.WriteLine("VYHRÁL JSI!");
                    konec = true;
                }
                else
                {
                    Console.WriteLine("TAM NEMŮŽEŠ!");
                    Console.ReadKey();
                }
            }
        }

        //matoda na výpis mapy
        static void VypisMapy(string[,] mapa)
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    
                    //NASTAVENÍ BARVY PODLE ZNAKŮ
                    if (mapa[i, j] == "#")
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (mapa[i, j] == "V")
                        Console.ForegroundColor = ConsoleColor.White;
                    else if (mapa[i, j] == "P")
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (mapa[i, j] == "X")
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    //VÝPIŠ ZNAKŮ
                    Console.Write(mapa[i, j] + " "); 
                    //VYRESETUJE BARVU ABY POKAZDY MOHLA DAT TU SPRAVNOU PRO JISTOTU
                    Console.ResetColor();
                }
                Console.WriteLine();
            }


        }
    }
}
