namespace Lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //předem nastavená velikost hrací plochy
            int velikost = 8;

            //vytvoření tří poli pro hru
            int[,] hrac = new int[velikost, velikost];
            int[,] hrac_strely = new int[velikost, velikost];
            int[,] souper = new int[velikost, velikost];

            //naplnění polí vodou (0)
            hrac = NaplnPole(hrac);
            hrac_strely = NaplnPole(hrac_strely);
            souper = NaplnPole(souper);

            

            //defaultní počet lodí
            int pocet_lodi = 3;
            for (int i = 0; i < pocet_lodi; i++)
            {
                //Výpis pole
                VypisPole(hrac);
                hrac = VlozLod(hrac);
                //ssouper = GenerujLod(souper);
                Console.Clear();
            }
            
            VypisPole(hrac);

            //Herní smyčka
            while(PocetLodi(hrac) > 0 && PocetLodi(souper) > 0 )
            {
                Console.Clear();
                Console.WriteLine("Vaše pole:");
                VypisPole(hrac);
                Console.WriteLine("Vaše pole střel:");
                VypisPole(hrac_strely);
            }
        }


        //Metoda na počet lidí
        static int PocetLodi(int[,] pole)
        {
            int pocet = 0;
            foreach (int policko in pole)
            {
                if (policko == 1)
                {
                    pocet++;

                }
            }
            return pocet;
            
        }






        //Metoda na generovaní lidí soupeře(AI)
        static int[,] GenerujLod(int[,] pole)
        {
            Random gen = new Random();
            int x = 0;
            int y = 0;

            do
            {
                x = gen.Next(0, pole.GetLength(1));
                y = gen.Next(0, pole.GetLength(0));
                
            } while (!JeVoda(x, y, pole)); //cyklus se zastaví, když na poli je voda

            pole[y, x] = 1; //1 - Loď
            return pole;
        }

        //Metoda pro vložení lodě
        //Todo upravit potom na větší lodě
        static int[,] VlozLod(int[,] pole)
        {
            int x = 0;
            int y = 0;

            do
            {
                do
                {
                    Console.WriteLine("Na jakou souřadnici X chceš vložit loď");
                    x = OverTyp();
                    Console.WriteLine("Na jakou souřadnici Y chceš vložit loď");
                    y = OverTyp();
                } while (JeMimo(x, y, pole)); //cyklus se zastaví, když není mimo
            } while (!JeVoda(x, y, pole)); //cyklus se zastaví, když na poli je voda

            pole[y, x] = 1; //1 - Loď
            return pole;
        }
        //Metoda ověřující, že dané souřadnice mohou v poli existovat (nejsou mimo)
        static bool JeMimo(int x, int y, int[,] pole)
        {
            if (y < 0 || y > pole.GetLength(0) || x < 0 || x > pole.GetLength(1))
            {
                return true;
            }
            return false;
        }

        //Metoda ověřující, že na daných souřadnicích předaných do paramteru se v poli nachází voda (0)
        static bool JeVoda(int x, int y, int[,] pole)
        {
            if (pole[y, x] == 0)
            {
                return true;
            }
            return false;
        }

        //Metoda ověřující, že vstup od uživatele je číslo, které vrátí!
        static int OverTyp()
        {
            int cislo = 0;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadej mi opravdu číslo!");
            }
            return cislo;
        }

        //Metoda na výpis hracího pole
        static void VypisPole(int[,] pole)
        {
            //Výpis indexů sloupců
            Console.Write(" "); //mezera kvůli posunu
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                //Vypíšu index řádku
                Console.Write(i); //kdybych chtěl začít 1, tak i+1
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    switch (pole[i, j])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write('L');
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write('X');
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write('O');
                            break;
                    }
                    Console.ResetColor(); //vyresetuje barvu konzole
                }
                Console.WriteLine();
            }
        }

        //Metoda na naplnění pole, defaultní hodnota náplně je 0
        static int[,] NaplnPole(int[,] pole, int napln = 0)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = napln;
                }
            }
            return pole;
        }
    }
}