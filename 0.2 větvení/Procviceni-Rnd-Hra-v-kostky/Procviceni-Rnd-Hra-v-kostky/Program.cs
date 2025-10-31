namespace Procviceni_Rnd_Hra_v_kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Hoď kostkou (znáčnkni enter)");
            string enter = Console.ReadLine();
            Console.Write($"{generator.Next(0, 7)} : {generator.Next(0, 7)} ");


        }
    }
}
