namespace Test_27._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] paluba = new int[4, 6];
            Random gen = new Random();
            for (int i = 0; i < paluba.GetLength(0); i++)
            {
                for (int j = 0; j < paluba.GetLength(1); j++)
                {
                    paluba[i, j] = gen.Next(0, 9);

                }
            }
            KontrolaStability(paluba);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void KontrolaStability(int[,] paluba)
        {
            int pravaCast = 0;
            int levaCast = 0;
            for (int i = 0; i < paluba.GetLength(0); i++)
            {
                for (int j = 0; j < paluba.GetLength(1) / 2; j++)
                {
                    levaCast += paluba[i, j];
                }
                for (int y = 3; y < 6; y++)
                {
                    pravaCast += paluba[i, y];
                }

            }

            Console.WriteLine($"Váha pravé  části:{pravaCast}");
            Console.WriteLine($"Váha levé  části:{levaCast}");

            Console.Write("Vyhodnocení: ");
            if (levaCast - pravaCast >= 10 && pravaCast - levaCast <= 10)
            {
                Console.Write("Pozor: Lod je nakoněmá moc");
            }
            else
            {
                Console.Write("Lod je v poho");
            }


                
            


            
        }
    }
}
