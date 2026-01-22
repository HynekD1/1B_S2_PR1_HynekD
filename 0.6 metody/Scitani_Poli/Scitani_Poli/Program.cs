namespace Scitani_Poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cislaA = { 5, 4, 8 };
            int[] cislaB = { 1, 6, 10 };

            int[] cislaSoucet = SpojPole(cislaA, cislaB);
            foreach (int cislo in cislaSoucet)
            {
                Console.WriteLine(cislo);
            }
        }

        static int[] SpojPole(int[] poleA, int[] poleB)
        {
            int[] vysledek = new int[poleA.Length + poleB.Length];
            int pomocID = 0;
            for (int i = 0; i < poleA.Length; i++)
            {
                vysledek[i] = poleA[i];
                pomocID = i; //pomocID++;
            }
            for (int i = 0; i < poleB.Length; i++)
            {
                vysledek[pomocID + 1 + i] = poleB[i];
            }

            for (int i = 0; i < vysledek.Length; i++)
            {
                int min = int.MaxValue;
                int minID = 0;
                for (int j = i; j < vysledek.Length; j++)
                {
                    if (vysledek[j] < min)
                    {
                        min = vysledek[j];
                        minID = j;
                    }
                }
                int pomoc = 0;
                pomoc = vysledek[i];
                vysledek[i] = min;
                vysledek[minID] = pomoc;
            }

            return vysledek;
        }
    }
}
