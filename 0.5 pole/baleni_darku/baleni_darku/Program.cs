namespace baleni_darku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hracky = { "letadlo", "autíčko", "vláček", "lodička", "koník", "dinosaurus" };
            string[] barvy = { "červené", "modré", "bílé", "černé", "žluté", "failové", "růžové", "oranžové", "tyrkysové", "zelené" };
            string[] vzorpapiru = { "pruhovaným", "jednobarevným", "žíhaným", "blyštivým", "obrázkovým", "lesklým" };
            string[] typstuhy = { "pruhovanou", "zdobenou", "pozlacenou", "postříbřenou", "lesklou", "jednobarevnou" };

            Console.WriteLine("Kolik chces dárků?");
            int pocet;
            while (!int.TryParse(Console.ReadLine(), out pocet))
            {

            }
            Random gen = new Random();

            if (pocet == 0)
            {
                Console.WriteLine("grich ti ukradl dárky hahaha");
            }
            else
            {
                for (int i = 0; i < pocet; i++)
                {
                    Console.WriteLine($"{barvy[gen.Next(0,barvy.Length)]} {hracky[gen.Next(0, hracky.Length)]} {vzorpapiru[gen.Next(0, vzorpapiru.Length)]} {typstuhy[gen.Next(0,typstuhy.Length)]}");
                }
            }
           
        }
    }
}