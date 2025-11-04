namespace delitelnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo kterým budete chtít dělit");
            int delitel = Convert.ToInt32(Console.ReadLine());
            int cislo = 0;

            do
            {
                Console.WriteLine($"Zadej číslo dělitelné {delitel}");
                cislo = Convert.ToInt32(Console.ReadLine());


            } while (cislo % delitel != 0 );
            Console.WriteLine($"{cislo} / {delitel} = {cislo / delitel}");
        }
    }
}
