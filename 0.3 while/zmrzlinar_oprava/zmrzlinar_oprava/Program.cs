namespace zmrzlinar_oprava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vanilka = 15;
            int coko = 20;
            int zmrl = 0;

            while (vanilka > 0 && coko > 0) 
            {
                Console.WriteLine($"Zadej jakou zmrzlinu chceš? Máme ještě {vanilka} vanilky a {coko} čokoládové zmrzliny (vanilka = 1, coko = 2, mix = 3)");
                while(!int.TryParse(Console.ReadLine(), out zmrl))
                {
                    Console.WriteLine("Zadej jednu z možností");
                }
                if(zmrl == 1)
                {
                    vanilka--;
                }else if(zmrl == 2)
                {
                    coko--;
                } else if(zmrl == 3)
                {
                    vanilka--;
                    coko--;
                }
            }
            Console.WriteLine($"Zmrzlináři došli zásoby");
            Console.WriteLine($"Zmrzlinář prodal {15 - vanilka} vanilky a {20 - coko} čokoládové zmrzliny");
        }
    }
}
