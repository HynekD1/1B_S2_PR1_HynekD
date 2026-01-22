namespace Zkouska_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[] staty = new int [4] ;
            staty[0] = gen.Next(5,11);
            staty[1] = gen.Next(1,4);
            staty[2] = gen.Next(1, 4);
            staty[3] = 1;
            while (staty[0] > 0)
            {
                Console.Write("Toto jsou tvoje staty: (životy, obrana, utok, level) ");
                foreach (int stat in staty)
                {
                    Console.Write(stat + " ");
                }
                Console.WriteLine();
                int volba = 0;
                Console.WriteLine("1 - Cvičiště");
                Console.WriteLine("2 - Felčar");
                Console.WriteLine("3 - Zabít bestii");

                while(!int.TryParse(Console.ReadLine(), out volba))
                {
                    Console.WriteLine("Zadej jednu z možností!!");
                }

                if (volba == 1)
                    staty = cviciste(staty);
                else if (volba == 2)
                    staty = felcar(staty);
                else if (volba == 3)
                    staty = bestie(staty);

                
                
                
            }
            Console.WriteLine();
            Console.WriteLine("Zabila tě bestie");
        }

        static int[] cviciste(int[] stats)
        {
            Random gen = new Random();
            int nahoda = gen.Next(1, 4);

            if (nahoda == 1)
            {
                if (gen.Next(0, 2) == 0)
                    stats[1]++; // obrana
                else
                    stats[2]++; // útok
            }
            else
            {
                stats[0]--; // zranění
            }

            return stats;

        }

        static int[] felcar(int[] stats)
        {
            if (stats[3] > 1)
            {
                stats[3]--;
                stats[0] += 10;
            }
            return stats;
        }

        static int[] bestie(int[] stats)
        {
            Random gen = new Random();

            int bestieZivot = gen.Next(1, 11) * stats[3];
            int bestieUtok = gen.Next(1, 4) * stats[3];

            while (bestieZivot > 0 && stats[0] > 0)
            {
                // hrdina útočí
                bestieZivot -= stats[2];

                if (bestieZivot <= 0)
                    break;

                // bestie útočí
                int dmg = bestieUtok - stats[1];
                if (dmg < 0) dmg = 0;

                stats[0] -= dmg;
            }

            if (stats[0] > 0)
            {
                stats[3]++; // level up
                stats[0]++; // +1 život
            }

            return stats;
        }
    }
}
