namespace kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stiskni enter pro hození");
            Console.ReadKey();
            Random generator = new Random();
            int hrac = generator.Next(1, 7);
            int souper = generator.Next(1, 7);
            Console.WriteLine("Hodil jsi" + hrac);
            Console.WriteLine("Chceš hodit znova (a)");
            char pdp = Console.ReadKey().KeyChar;
            if (pdp == 'a')
            {
                hrac = generator.Next(1, 7);
            }
            switch (hrac)
            {
                case int h when h > souper:
                    Console.WriteLine("\nVyhrál jsi");
                    break;
                case int h when h < souper:
                    Console.WriteLine("\nVyhrál jsi");
                    break;
                default:
                    Console.WriteLine("\nRemíza");
                    break;





            }
        }   
    }
}
