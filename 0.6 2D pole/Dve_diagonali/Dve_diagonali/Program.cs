namespace Dve_diagonali
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[,] diagonaly = 
            { { "#", " ", " ", " ", "#" },
              { " ", "#", " ", "#", " " },
              { " ", " ", "#", " ", " " },
              { " ", "#", " ", "#", " " },
              { "#", " ", " ", " ", "#" },
            };


            string[,] pole = new string[20, 20];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                pole[i, i] = "#";
            }


            
            

            // zde vytvořte proměnnou typu 2D pole řetězců o rozměrech 5 x 5 prvků
            // promennou nazvete diagonaly
            // uložt do všechn prvků pole mezery, jen do diagonál vložte #
            // je mnoho způsobů, jak to provést, vyberte si ten svůj


            //zde pole vypíšeme - vypisovací metoda už je připravena
            Vypis2DPole(diagonaly);

            

        }
        public static void Vypis2DPole(string[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
