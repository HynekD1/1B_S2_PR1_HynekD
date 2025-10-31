using System.Threading.Channels;

namespace procviceni_ktery_kvadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo x na ose");
            int cislo_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej číslo y na ose");
            int cislo_y = Convert.ToInt32(Console.ReadLine());
            switch (cislo_x, cislo_y)
            {
                case (int x, int y) when x == 0 && y == 0:
                    Console.WriteLine("0");
                    break;
                case (int x, int y) when x >= 1 && y >= 1:
                    Console.WriteLine("1");
                    break;
                case (int x, int y) when x <= 1 && y >= 1:
                    Console.WriteLine("2");
                    break;
                case (int x, int y) when x <= 1 && y <= 1:
                    Console.WriteLine("3");
                    break;
                case (int x, int y) when x >= 1 && y <= 1:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("Špatný vstup");
                    break;
            }
         
        }
    }
}
