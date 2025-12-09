namespace Procviceni_odpocet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 60; i > -1 ; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Zážeh !");
        }
    }
}
