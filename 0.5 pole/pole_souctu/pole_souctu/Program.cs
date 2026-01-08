namespace pole_souctu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 10, 15, 35, 10, 50, 12, 5 };
            int[] pole_souctu = new int[cisla.Length];
            for (int i = 0; i < cisla.Length; i++)
            {
                /*
                for (int j = 0; j <= i; j++)
                {
                    pole_souctu[i] += cisla[j]; 
                }
                */
                if (i == 0)
                {
                    pole_souctu[i] = cisla[i];
                }
                else
                {
                    pole_souctu[i] = cisla[i] + pole_souctu[i - 1];
                }
                    
            }
            foreach ( int cislo in pole_souctu)
            {
                Console.WriteLine(cislo);
            }

            

            



        }
    }
}
