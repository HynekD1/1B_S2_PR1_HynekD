namespace Pod_Limitem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { -5, -3, 2, -0, 5, 2, 4, 8, 6, 3, 10 };
            HodnotyPodLimitem(cisla, 3.6);
            HodnotyPodLimitem(cisla, -4);
            HodnotyPodLimitem(cisla, 2.5);

            double[] CislaNadLimitem = HodnotyNadLimitem(cisla, 0);
            foreach (double cislo in CislaNadLimitem)
            {
                Console.WriteLine(cislo);
            }
        }

        static double[] HodnotyNadLimitem(double[] Pole1, double limit)
        {
            double[] vysledky = new double[0];
            for (int i = 0; i < Pole1.Length; i++)
            {
                if (Pole1[i] >= limit)
                {
                    Array.Resize(ref vysledky, vysledky.Length +1 );
                    vysledky[vysledky.Length - 1] = Pole1[i];
                }

            }
            return vysledky;
        }


        static void HodnotyPodLimitem(double[] pole, double limit)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] <= limit)
                {
                    Console.Write(pole[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
