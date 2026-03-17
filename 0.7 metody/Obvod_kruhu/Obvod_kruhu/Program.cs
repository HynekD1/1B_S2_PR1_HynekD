namespace Obvod_kruhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Zadej poloměr kruhu");
            double pol = 0;
            while (!double.TryParse(Console.ReadLine(), out pol))
            {
                Console.WriteLine("chci číslo!");
            }
            Console.WriteLine(obvodkruh(pol));
        }


        static double obvodkruh(double polomer)
        {
            return (2 * Math.PI * polomer);
            
        }
    }
}
