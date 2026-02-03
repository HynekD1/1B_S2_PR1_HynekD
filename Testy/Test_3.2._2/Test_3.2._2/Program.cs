namespace Test_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pocitadlo = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                Hod(100, pocitadlo);
                foreach (int pocet in pocitadlo)
                {
                    Console.Write(pocet + "  ");
                }
                Console.WriteLine();
            }

        }

        static int[] Hod(int pocetH, int[] stat)
        {
            int kostka = 0;
            Random gen = new Random();
            for (int i = 0; i < pocetH; i++)
            {
                kostka = gen.Next(1, 7);

                if (kostka == 1)
                {
                    stat[0]++;
                }
                else if (kostka == 2)
                {
                    stat[1]++;
                }
                else if (kostka == 3)
                {
                    stat[2]++;
                }
                else if (kostka == 4)
                {
                    stat[3]++;
                }
                else if (kostka == 5)
                {
                    stat[4]++;
                }
                else if (kostka == 6)
                {
                    stat[5]++;
                }
            }

            //stat[gen.Next(1, 7) - 1] += 1;
            return stat;
        }
    }
}
