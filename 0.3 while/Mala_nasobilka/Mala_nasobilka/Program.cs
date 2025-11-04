namespace Mala_nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasobky = 7;
            int nasobitel = 0;
            while (nasobitel <= 10)
            {
                Console.WriteLine(nasobky * nasobitel);
                nasobitel++;
            }
        }
    }
}
