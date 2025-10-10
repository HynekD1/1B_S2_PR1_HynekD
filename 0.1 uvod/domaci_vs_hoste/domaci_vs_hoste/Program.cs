namespace domaci_vs_hoste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej skore domácích:" );
            string domaci = Console.ReadLine();

            Console.Write("Zadej skore hostů:" );
            string hoste = Console.ReadLine();

            Console.WriteLine("Výsledek zápasu je " + domaci + ":" +hoste);
        }
    }
}
