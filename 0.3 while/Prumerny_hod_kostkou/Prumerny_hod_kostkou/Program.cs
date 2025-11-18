namespace Prumerny_hod_kostkou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steny_kostky = 0;
            int pocet_hodu = 0;
            Random kostka = new Random();

            Console.WriteLine("Zadej mi kolik má kostka mít stěn");
            while(!int.TryParse(Console.ReadLine(), out steny_kostky))
            {
                Console.WriteLine("Zadej číslo");
            }

            Console.WriteLine("Zadej mi kolikrát mám hodit kostkou");
            while(!int.TryParse(Console.ReadLine(), out pocet_hodu))
            {
                Console.WriteLine("Zadej číslo");
            }

            double soucet_hodu = 0;
            double pocet_hodu2 = 0;
            
            while(pocet_hodu2 < pocet_hodu)
            {
                soucet_hodu += kostka.Next(1, steny_kostky);
                pocet_hodu2++;
            }
            Console.WriteLine($"Průměrný hod je {soucet_hodu/pocet_hodu2} z {pocet_hodu} hodů {steny_kostky} stěnnou kostkou!");
        }
    }
}
