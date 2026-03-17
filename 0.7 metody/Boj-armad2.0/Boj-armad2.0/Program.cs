namespace Boj_armad2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();

            int[] armadaMoje = { 0, 0, 0 };
            int[] armadaEnemy = GenerujEnemy(gen);

            NakupArmadu(armadaMoje);
            Boj(armadaMoje, armadaEnemy, gen);
        }

        // ================= NÁKUP =================
        static void NakupArmadu(int[] armada)
        {
            int body = 100;

            while (body >= 5)
            {
                Console.WriteLine($"\nTvoje armáda: P {armada[0]} | S {armada[1]} | J {armada[2]}");
                Console.WriteLine($"Máš {body} bodů");
                Console.WriteLine("P (5) | S (10) | J (10) | N = konec");

                string volba = Console.ReadLine().ToUpper();

                if (volba == "P" && body >= 5)
                {
                    armada[0]++;
                    body -= 5;
                }
                else if (volba == "S" && body >= 10)
                {
                    armada[1]++;
                    body -= 10;
                }
                else if (volba == "J" && body >= 10)
                {
                    armada[2]++;
                    body -= 10;
                }
                else if (volba == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná volba nebo málo bodů.");
                }
            }
        }

        // ================= BOJ =================
        static void Boj(int[] moje, int[] enemy, Random gen)
        {
            Console.WriteLine("\n=== ZAČÍNÁ BITVA ===");
            int kolo = 1;

            while (JeZiva(moje) && JeZiva(enemy))
            {
                Console.WriteLine($"\n--- Kolo {kolo} ---");
                VypisStav(moje, enemy);

                Console.WriteLine("Rozkaz: 1-Pěchota 2-Střelci 3-Jízda");
                int rozkaz = int.Parse(Console.ReadLine());

                ProvedUtok(rozkaz, moje, enemy, gen);

                if (!JeZiva(enemy)) break;

                int rozkazEnemy;
                do
                {
                    rozkazEnemy = gen.Next(1, 4);
                } while (enemy[rozkazEnemy - 1] == 0);

                ProvedUtok(rozkazEnemy, enemy, moje, gen);

                kolo++;
            }

            Console.WriteLine("\n=== KONEC BITVY ===");
            Console.WriteLine(JeZiva(moje) ? " Vyhrál jsi!" : " Prohrál jsi...");
        }

        // ================= ÚTOK =================
        static void ProvedUtok(int typ, int[] utocnik, int[] obrance, Random gen)
        {
            int pocet = utocnik[typ - 1];

            for (int i = 0; i < pocet; i++)
            {
                int cil = NajdiCil(typ, obrance);
                if (cil == -1) return;

                if (gen.NextDouble() < VratSanci(typ, cil))
                    obrance[cil]--;
            }
        }

        static int NajdiCil(int typ, int[] obrance)
        {
            int[][] poradi =
            {
                new int[]{0,2,1},
                new int[]{0,1,2},
                new int[]{2,1,0}
            };

            foreach (int i in poradi[typ - 1])
                if (obrance[i] > 0)
                    return i;

            return -1;
        }

        static double VratSanci(int utok, int cil)
        {
            if (utok == 1)
                return cil switch { 0 => 0.1, 2 => 1.0 / 6, 1 => 1.0 / 3, _ => 0 };

            if (utok == 2)
                return 1.0 / 6;

            return cil switch { 0 => 0.25, 2 => 0.125, 1 => 0.5, _ => 0 };
        }

        // ================= POMOCNÉ =================
        static bool JeZiva(int[] a)
        {
            return a[0] > 0 || a[1] > 0 || a[2] > 0;
        }

        static void VypisStav(int[] m, int[] e)
        {
            Console.WriteLine($"Ty:    P {m[0]} | S {m[1]} | J {m[2]}");
            Console.WriteLine($"Enemy: P {e[0]} | S {e[1]} | J {e[2]}");
        }

        static int[] GenerujEnemy(Random gen)
        {
            return new int[]
            {
                gen.Next(5,13),
                gen.Next(2,7),
                gen.Next(2,7)
            };
        }
    }
}
