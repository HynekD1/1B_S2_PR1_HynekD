using System.Net.Security;

namespace podmineni_soucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soucet = 0;
            int[] cisla = { 10, 25, -5, -30, 40, 8, 2, 0, -15 };
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] >= -10 && cisla[i] <= 10)
                {
                    soucet += cisla[i];
                }
            }
            Console.WriteLine(soucet);

            soucet = 0;

            foreach (int cislo in cisla)
            {
                if (cislo >= -10 && cislo <= 10)
                {
                    soucet += cislo;

                }
            }
            Console.WriteLine(soucet);
        }
    }
}
