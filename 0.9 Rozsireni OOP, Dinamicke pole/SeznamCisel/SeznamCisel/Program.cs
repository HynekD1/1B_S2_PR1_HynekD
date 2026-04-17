namespace SeznamCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> SeznamCisel = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                SeznamCisel.Add(rnd.Next(0, 1000001));
            }
            Console.WriteLine("Vyber si: \nVypis všech čísel " +
                "\nPřidat číslo do seznamu (0)" +
                "\nVypsat součet a průměr všech čísel(1)" +
                "\nZobrazit nejmenší a největší hodnotu(2)" +
                "\nVymazat určité číslo nebo rozsah čísel(3)" +
                "\nSeřadit čísla vzestupně nebo sestupně(4)" +
                "\nZjištění, zda číslo existuje v seznamu(5)"
                );


        }
        static List<int> Pridej (List<int> seznamCisel)
        {
            Console.WriteLine("napis cislo které chces pridet:");
            int cislo = 0;
            cislo = int.Parse(Console.ReadLine());
            seznamCisel.Add(cislo);
            return seznamCisel;
        }


        static void Vypis(List<int> seznamCisel)
        {
            foreach (var cislo in seznamCisel)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
