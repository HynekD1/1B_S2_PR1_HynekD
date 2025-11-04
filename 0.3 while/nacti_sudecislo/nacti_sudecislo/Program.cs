namespace nacti_sudecislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;

            do
            {
                Console.WriteLine("Zadej mi sudé číslo:");
                cislo = int.Parse(Console.ReadLine());
            } while (cislo % 2 == 1);
            Console.WriteLine($"Sudé zadané číslo je {cislo} a jeho nejbližší vyšší liché je {cislo+1}");

        }
    }
}
