namespace kdyz_padne_sestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program hází kostkou k6 a hází, dokud nehodí 6!");
            Random kostka = new Random();

            //proměnná pro ukládání hodů
            int hod = 0;

            char opak = 'a';

            while(opak == 'a')
            {
                //proměnná pro pocet hodů
                int pocet_hodu = 0;
                do
                {
                    hod = kostka.Next(1, 7);
                    Console.WriteLine(hod + ", ");
                    pocet_hodu++;
                } while (hod != 6);

                Console.WriteLine();
                Console.WriteLine($"Celkové jsem hodil kostkou {pocet_hodu} krát, než jsem hodil 6");
                Console.WriteLine("Pokud chceš házení opakovat stistkni tlačítko 'a' jinak 'n' ");
                opak = Console.ReadKey().KeyChar;
                Console.WriteLine("   ");
            }
            Console.ForegroundColor = ConsoleColor.Black;        
        }
    }
}
