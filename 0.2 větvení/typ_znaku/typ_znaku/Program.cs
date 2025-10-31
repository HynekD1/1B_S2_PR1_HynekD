using System.ComponentModel;

namespace typ_znaku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej znak");
            char znak = Console.ReadKey().KeyChar;
            switch(znak)
            {
                case char a when (a <= 90 && a >= 65 || a <= 122 && a >= 97):
                    Console.WriteLine("\nZadaný znak je písmeno");
                    break;
                case char b when (b >= 48 && b <=57):
                    Console.WriteLine("\nZadaný znak je číslo");
                    break;
                default:
                    Console.WriteLine("\nŠpatný znak");
                    break;
            }
        }
    }
}