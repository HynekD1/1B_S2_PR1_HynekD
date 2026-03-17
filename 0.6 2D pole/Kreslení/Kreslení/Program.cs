namespace Kreslení
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
            {
               { true, false, false,  true, false, false,  true},
               { false,  true, false,  true, false,  true, false},
               { false, false,  true,  true,  true, false, false},
               { false, false, false,  true, false, false, false},
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    
                }
            }
            
        }

        static string[,] VykresliPole (bool mapa[,])
        {
            string[,] mapa2 = new string[4, 7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (mapa2[i,j] == "true")
                    {
                        mapa2[i, j] = "#";
                    }
                    else if (mapa2[i, j] == "true")
                    {
                        mapa2[i, j] = " ";
                    }
                }
            }
        }
    }
}
