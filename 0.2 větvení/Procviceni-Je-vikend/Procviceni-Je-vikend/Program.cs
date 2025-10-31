namespace Procviceni_Je_vikend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo (1-7)");
            int cislo = Convert.ToInt32(Console.ReadLine());
            
            switch (cislo)
            {
                case int x when (cislo == 6 || cislo == 7):
                    Console.WriteLine("Je výkend");
                    break;
                case int x when (cislo <= 5 && cislo >= 1):
                    Console.WriteLine("Je týden");
                    break;
                default:
                    Console.WriteLine("Špatný vstup");
                    break;
            }
        }
    }
}
