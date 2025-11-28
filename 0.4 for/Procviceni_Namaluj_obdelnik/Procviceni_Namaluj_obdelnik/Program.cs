namespace Procviceni_Namaluj_obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyska = 10;
            int sirka = 6;
            for (int i = 0; i < vyska; i++)
            {
                for (int j = 0; j < sirka; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
