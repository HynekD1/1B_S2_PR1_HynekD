namespace PocetSousedu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa =
            {

            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
            
            };

            Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
            Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
            Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

        }

        static int PocetSousedu(bool[,] mapa, int x, int y)
        {
            int pocetsousedu = 0;
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j  = 0; j < mapa.GetLength(1); j++)
                {
                    if ((j == x - 1 || j == x + 1) && (i == y - 1 || i == y + 1 ) == true) 
                    {
                        pocetsousedu++;
                    }
                }
            }
            return pocetsousedu;

            
        }
    }
}
