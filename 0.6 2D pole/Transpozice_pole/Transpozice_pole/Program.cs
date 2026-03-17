using System;

class MainClass
{
    public static void Main(string[] args)
    {

        int[,] tabulka1 =
        {
            {3, 4, 7},
            {5, 9, 1},
            {1, 3, 2}
        };

        Console.WriteLine();

        int[,] tabulka2 =
        {
            {3, 1, 0},
            {2, 4, 5},
            {6, 7, 1},
            {0, 1, 2}
        };

        Console.WriteLine();

        int[,] transpozice1 = Transponuj(tabulka1);
        Vypis2DPole(transpozice1);

        Console.WriteLine();

        int[,] transpozice2 = Transponuj(tabulka2);
        Vypis2DPole(transpozice2);

        Console.WriteLine();

        //tohle by mělo vypsat nezměněné pole tabulka1 - jsou tam 2 transpozice za sebou
        Vypis2DPole(Transponuj(Transponuj(tabulka1)));
    }

    //sem přijde kód vaší metody Transponuj


    //konec vašeho kódu

    public static void Vypis2DPole(int[,] pole)
    {
        //do kódu této metody nezasahujte
        for (int y = 0; y < pole.GetLength(0); y++)
        {
            for (int x = 0; x < pole.GetLength(1); x++)
            {
                Console.Write(pole[y, x]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static int[,] Transponuj(int[,] tabulka)
    {
        int radky = tabulka.GetLength(0);
        int sloupce = tabulka.GetLength(1);

        int[,] vysledek = new int[sloupce, radky];

        for (int y = 0; y < radky; y++)
        {
            for (int x = 0; x < sloupce; x++)
            {
                vysledek[x, y] = tabulka[y, x];
            }
        }

        return vysledek;
    }
}