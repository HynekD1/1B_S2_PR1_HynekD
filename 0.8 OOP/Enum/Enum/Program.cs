namespace Enum
{
    internal class Program
    {
        enum Obdobi { Jaro, Leto, Podzim, Zima };

        static void Main(string[] args)
        {
            Obdobi sezona = Obdobi.Podzim;
            sezona++;
            Console.WriteLine(sezona);
            sezona++;
            Console.WriteLine(sezona);

            Console.ReadKey();
        }

    }
}
