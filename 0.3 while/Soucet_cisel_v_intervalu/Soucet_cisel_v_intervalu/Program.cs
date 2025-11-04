using System.Diagnostics.CodeAnalysis;

namespace Soucet_cisel_v_intervalu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej okraj intervalu");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej okraj intervalu");
            int y = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(x, y); // Uloží to do max větší z čísel
            int min = Math.Min(x, y); // Uloží to do min menší z čísel

            int soucet = 0;
            
            while(min <= max)
            {
                soucet += min;
                min++;
            }
            Console.WriteLine($"Součet čísel v intervalu (včetně okrajů) je {soucet}");

        }
    }
}
