namespace Uvod_2DPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jednorozměrné pole
            int[] jCisla = { 1, 5, 6 }; //inićializace pole s konkrétnímí hodnotami
            string[] jPrazdnePole = new string[10]; //vytvoření string pole, které je prázdné

            //dvourozměrné pole 2D
            int[,] cisla = 
            { { 10, 5, 1 },
              { 8, 12, 6 },
              { 7, 11, 3 }
            };

            string[,] prazdnePole = new string[10, 5]; //10řádků a 5 sloupců

            //výpis z 2D pole
            //1 řádek (bacha 1 index, tzn, druhý řádek v pořadí) a 1 sloupec
            Console.WriteLine(cisla[1,1]); //12
            Console.WriteLine(cisla[1, 2]);//6
            Console.WriteLine(cisla[2, 0]);//7

            prazdnePole[8, 4] = "Pepa";//přidá Pepu na 8. index řádku do 4. indexovaného sloupce
            Console.WriteLine(prazdnePole[8,4]);


            //Průchod 2D polem

            //foreach - vypíše vždy obsah jednoho řádku od 0. a pak pokračuje na další řádek
            foreach (int cislo in cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            //for - pro výpis jako matice/tabulka
            Console.WriteLine(prazdnePole.GetLength(0)); //vrací počet řádků
            Console.WriteLine(prazdnePole.GetLength(1)); //vrací počet sloupců


            //vnější for ciklus jde po řádcích
            for (int i = 0; i < cisla.GetLength(0); i++)
            {
                for (int j = 0; j < cisla.GetLength(1); j++)
                {
                    Console.Write(cisla[i,j] +  " ");
                }
                Console.WriteLine();
            }
        }
    }
}
