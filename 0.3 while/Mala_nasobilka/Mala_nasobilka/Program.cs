namespace Mala_nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte u kterého čísla chcete násobky od 0 do 10");
            int nasobky = Convert.ToInt32(Console.ReadLine());
            int nasobitel = 0;
            Console.WriteLine(" ");
            while (nasobitel <= 10)
            {
                Console.WriteLine(nasobky * nasobitel);
                nasobitel++;
            }
        }
    }
}
