namespace napukni_kosik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik vajíček chceš koupit?");
            int pocet_vajicek = int.Parse(Console.ReadLine());

            Console.WriteLine("Kolik rohlíků chceš koupit?");
            int pocet_rohliku = int.Parse(Console.ReadLine());

            Console.WriteLine("Kolik chlebů chceš koupit?");
            int pocet_chleba = int.Parse(Console.ReadLine());

            float cena_vajicka = 3.5f;
            float cena_rohliku = 1.5f;
            float cena_chleba = 25f;

            Console.WriteLine($"Nákup stojí: {cena_vajicka * pocet_vajicek + cena_rohliku * pocet_rohliku + cena_chleba * pocet_chleba}Kč");
            
        }
    }
}
