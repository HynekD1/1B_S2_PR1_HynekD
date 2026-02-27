using System.Collections.Concurrent;

namespace PruzkumTolerance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sousedi = { "Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {

            {  true, false, false, false,  true,  true, true,  true },
            {  true,  true,  true,  true,  true, false, true,  true },
            {  true,  true, false,  true,  true,  true, true, false },
            { false,  true,  true,  true,  true, false, true,  true },
            {  true, false, false,  true, false, false, true, false },
            {  true, false, false,  true,  true, false, true, false },
            {  true, false, false,  true, false, false, true,  true },
            
            };


            Console.WriteLine(Nejtolerantnejsi(respondenti, vysledky, true));
            Console.WriteLine(Nejtolerantnejsi(respondenti, vysledky, false));
        }


        static string Nejtolerantnejsi(string[] jmena, bool[,] vysledky, bool podleceho)
        {

            int max = int.MinValue;
            int indexRadku = 0;
            for (int i = 0; i < vysledky.GetLength(0); i++)
            {
                int radek = int.MinValue;
                for (int j = 0; j < vysledky.GetLength(1); j++)
                {
                    if (vysledky[i,j] == podleceho)
                    {
                        radek++;
                    }
                    
                }
                if (max < radek)
                {
                    max = radek;
                    indexRadku = i;
                }
            }

            return jmena[indexRadku];
                         

        }
    }
}
