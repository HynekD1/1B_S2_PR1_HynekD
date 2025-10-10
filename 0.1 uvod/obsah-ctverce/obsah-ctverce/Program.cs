using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

namespace obsah_ctverce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sem přijde váš kód
            Console.WriteLine("Napiš sem delku strany a");
            int stranaA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obsah čtverce je: " + stranaA * stranaA);
            // Konec prostoru pro kód
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}