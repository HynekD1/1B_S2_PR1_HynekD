namespace serie_sestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Kolikrát mam hodit kostkou? (šestistranou)");
            int pocet = 0;
            int serie_sestek = 0;
            int akt_serie = 0;
            int hod = 0;

            while (!int.TryParse(Console.ReadLine(),out pocet))
            {
                Console.WriteLine("Zadej císlo!");
            }
            while (hod < pocet )
            {
                int kostka = rnd.Next(1, 7);
                Console.WriteLine(kostka + " ");
                if(kostka == 6)
                {
                    akt_serie++;
                    if (akt_serie > serie_sestek)
                    {
                        serie_sestek++;
                    }
                }
                else
                {
                    akt_serie = 0;
                }
                    hod++;
            }

            Console.WriteLine($"V počtu hodů {pocet} byla nejdelší serie šestek {serie_sestek}");
            
           

        }
    }
}
