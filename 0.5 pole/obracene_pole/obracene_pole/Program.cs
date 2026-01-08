namespace obracene_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { -10, -3, 0, 2, 3, 15 };
            int[] obracena_cisla = new int[cisla.Length];
            int pocitadlo = 0; 
            for (int i = cisla.Length-1; i >= 0; i--)
            {
                obracena_cisla[pocitadlo] = cisla[i];
                pocitadlo++;
            }
            foreach (int cislo in obracena_cisla)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
