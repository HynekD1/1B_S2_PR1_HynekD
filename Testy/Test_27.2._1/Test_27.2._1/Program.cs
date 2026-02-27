namespace Test_27._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volne_misto = 0;
            int plne_misto = 0;
            int[,] sedala = new int[5, 8];
            Random gen = new Random();
            for (int i = 0; i < sedala.GetLength(0); i++)
            {
                for (int j = 0; j < sedala.GetLength(1); j++)
                {
                    sedala[i, j] = gen.Next(0, 2);
                    if (sedala[i, j] == 1)
                    {
                        plne_misto++;
                    }
                    else
                    {
                        volne_misto++;
                    }
                }
            }

            VypisSedacek(sedala);
            Console.WriteLine($"Počet volných míst:{volne_misto}");
            Console.WriteLine($"Počet plných míst:{plne_misto}");

            NapukListu(sedala);
            

            VypisSedacek(sedala);

            Console.ForegroundColor = ConsoleColor.Black;
        }
        static int[,] NapukListu(int[,] sedala)
        {
            int radek = 0;
            int sloupek = 0;
            Console.WriteLine("Zadej řádek pro rezervaci (0-4)");
            radek = BezpecnyVstup(radek);
            Console.WriteLine("Zadej sloupec pro rezervaci (0-7)");
            sloupek = BezpecnyVstup(sloupek);
            if (sedala[radek, sloupek] == 1)
            {
                Console.WriteLine("Toto místo je plné");
            }
            else if (sedala[radek, sloupek] == 0)
            {
                sedala[radek, sloupek] = 1;
                Console.WriteLine("Reservace byla úspěšná");
            }
            return sedala;
        }

        static int[,] VypisSedacek(int[,] sedala)
        {
            for (int i = 0; i < sedala.GetLength(0); i++)
            {
                for (int j = 0; j < sedala.GetLength(1); j++)
                {
                    Console.Write(sedala[i,j]);
                    if (sedala[i,j] == 1)
                    {
                        //sedala[i, j] == "[X]";
                    }
                    else
                    {
                        //sedala[i, j] == "[ ]";
                    }
                }
                Console.WriteLine();
            }
            return sedala;
        }

        static int BezpecnyVstup(int vstup)
        {
            while (!int.TryParse(Console.ReadLine(), out vstup))
            {
                Console.WriteLine("Zadej mi opravdu číslo");
            }
            return vstup;
        }
    }
}
