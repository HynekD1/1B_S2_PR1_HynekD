namespace Nakupni_seznam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polozka[] nakupni_seznam = new Polozka[3];
            /*
            Polozka vejce = new Polozka();

            vejce.Nazev = "Vajíčko";
            vejce.Pocet = 10;
            vejce.Cena_za_kus = 5;
            Nakupni_seznam[0] = vejce;
            */
            nakupni_seznam[0] = new Polozka("Vajíčko", 10, 5);
            nakupni_seznam[1] = new Polozka("Rohlík", 20, 3);
            nakupni_seznam[2] = new Polozka("Pivo", 30, 12);

            VypisSeznam(nakupni_seznam);
            
            
        }
        static void VypisSeznam(Polozka[] seznam)
        {
            int celkem = 0;
            for (int i = 0; i < seznam.Length; i++)
            {
                celkem += seznam[i].Cena_celkem;
                Console.WriteLine($"Potřebuju {seznam[i].Nazev}, chci ho {seznam[i].Pocet}x a stojí to celkem: {seznam[i].Cena_celkem}");
            }
            Console.WriteLine($"Celková cena z nákup je {celkem}Kč");
        }
    }
}
