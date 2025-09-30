namespace pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vlož své jméno:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Ahoj " + jmeno + "!");
        }
    }
}
