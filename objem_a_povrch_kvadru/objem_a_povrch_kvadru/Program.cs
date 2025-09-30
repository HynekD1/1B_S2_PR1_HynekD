using System.Xml;

namespace objem_a_povrch_kvadru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sem přijde váš kód
            Console.Write("Zadej šířku kvádru ");
            int sirkaA = Convert.ToInt32(Console.ReadLine());
            //float sirkaA_ = float.Parse(Console.ReadLine());

            Console.Write("Zadej hloubku ");
            int hloubkaB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadej výšku ");
            int vyskaC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Objem kvádru je: " + sirkaA * hloubkaB * vyskaC);

            Console.WriteLine("Povrch kvádru je: " + 2 * (sirkaA * hloubkaB + hloubkaB * vyskaC + vyskaC * sirkaA));

            Console.WriteLine($"Povrch kvádru je: {2 * (sirkaA * hloubkaB + hloubkaB * vyskaC + vyskaC * sirkaA)} a objem kvádru je{sirkaA * hloubkaB * vyskaC}");

            Console.WriteLine($"povrch kvádru je (0) a objem je (1) ");


            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
