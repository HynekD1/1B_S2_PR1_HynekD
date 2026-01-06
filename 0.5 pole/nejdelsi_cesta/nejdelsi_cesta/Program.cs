namespace nejdelsi_cesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] jizdy = {
            247,
            135,
            15,
            23,
            428,
            63,
            26,
            7
            };

            string[] ridici = {
            "Petr",
            "Pavel",
            "Jaroslav",
            "Pavel",
            "Jaroslav",
            "Petr",
            "Pavel",
            "Petr"
            };


            //Najít nejdelší jízdu
            int nej_jizda = int.MinValue;

            foreach (int jizda in jizdy)
            {
                if (jizda > nej_jizda)
                {
                    nej_jizda = jizda;
                }

            }
            Console.WriteLine("Nejdelší jízda byla" + nej_jizda);

            //Najít řidiče nejdelší jízdy

            nej_jizda = 0;
            int index_nej_jizdy = 0;

            for (int i = 0; i < jizdy.Length; i++)
            {
                if(nej_jizda < jizdy[i])
                {
                    nej_jizda = jizdy[i];
                    index_nej_jizdy = i;
                }
            }
            Console.WriteLine($"Nejdelší jízda je {nej_jizda} a je uložena a indexu {index_nej_jizdy} v poli jízdy");
            Console.WriteLine($"Nejdelší jízdu jel řidič {ridici[index_nej_jizdy]} na indexu {index_nej_jizdy} v poli ridiči.");

            //Najít řidiče nejkratší jízdy

            nej_jizda = int.MaxValue;
            index_nej_jizdy = 0;

            for (int i = 0; i < jizdy.Length; i++)
            {
                if (nej_jizda > jizdy[i])
                {
                    nej_jizda = jizdy[i];
                    index_nej_jizdy = i;
                }
            }

            Console.WriteLine($"Nejkratší jízda je {nej_jizda} a je uložena na indexu {index_nej_jizdy} v poli jizdy.");
            Console.WriteLine($"Nejkratší jízdu jel řídič {ridici[index_nej_jizdy]} na indexu {index_nej_jizdy} v poli ridici.");
        }
    }
}
