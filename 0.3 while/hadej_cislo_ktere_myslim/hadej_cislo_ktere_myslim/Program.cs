namespace hadej_cislo_ktere_myslim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random cislo = new Random();
            int hadane_cislo = cislo.Next(0,101);
            int tip = 0;
            int pokusi = 0;
            do
            {
                Console.WriteLine("Hádej jaký číslo mám na mysli");
                while(!int.TryParse(Console.ReadLine(), out tip))
                {
                    Console.WriteLine("Zadej číslo!");
                }
                
                if(hadane_cislo > tip)
                {
                    Console.WriteLine("Málo!");
                }else if(hadane_cislo < tip)
                {
                    Console.WriteLine("Moc");
                }
                else
                {
                    Console.WriteLine("Uhold jsi");
                }
                pokusi++;
            } while (hadane_cislo != tip);
            Console.WriteLine($"Uhodl jsi na {pokusi} pokus");

        }
    }
}
