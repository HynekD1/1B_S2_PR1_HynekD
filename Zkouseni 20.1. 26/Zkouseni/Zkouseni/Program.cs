namespace Zkouseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mapa = { 1, 0, 0, 0, 0, 0 };

            mapa = Postavicka(2, mapa);
            foreach (int maps in mapa)
            {
                Console.Write(maps);
            }
        }

        static int[] Postavicka(int pohyb, int[] mapa)
        {
            int postava = 0;
            
            for (int i = 0; i < mapa.Length -1 ; i++)
            {
                if (mapa[i] == 1)
                {
                    postava = i;
                    break;
                }
            }
            mapa[postava] = 0;
            if (postava + pohyb >= 0 && postava + pohyb <= mapa.Length - 1)
            {
                mapa[postava + pohyb] = 1;
            }else if (postava + pohyb < 0)
            {
                mapa[0] = 1;
            }else if(postava + pohyb > mapa.Length - 1)
            {
                mapa[mapa.Length - 1] = 1;
            }
            return mapa;
        }
    }
}
