namespace MapaSvahu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VypisPole(Svah(10));
            Console.WriteLine();
            VypisPole(Svah(5));
            Console.WriteLine();
            VypisPole(SikmiSvah(5));
        }

        static int[,] Svah(int x)
        {
            int[,] pole = new int[x, x];
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = j;
                }
            }
            return pole;
        }

        static void VypisPole(int[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        static int[,] SikmiSvah(int x)
        {

            int[,] pole = new int[x, x];
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = j + i;
                }
            }

            return pole;
        }
    }
}
