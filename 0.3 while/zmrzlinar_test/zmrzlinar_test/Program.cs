namespace zmrzlinar_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valinka = 5;
            int coko = 7;
            int pocet_zmr = 0;

            while(valinka > 0 && coko > 0)
            {
                Console.WriteLine("Zadej jakou zmrzlinu chceš valinku(1), nebo čokoladu(2), nebo mix(3)");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out pocet_zmr))
                    {
                        Console.WriteLine("Zadej celé číslo");
                    }
                } while (!(pocet_zmr >= 1 && pocet_zmr <= 3 && pocet_zmr <= valinka && pocet_zmr <= coko));

                if(pocet_zmr == 1)
                {
                    valinka--;
                } else if(pocet_zmr == 2)
                {
                    coko--;
                }
                else if(pocet_zmr ==3)
                {
                    valinka--;
                    coko--;
                }
            }
            Console.WriteLine("Omlouvám se ale jedna ze zmrzlin došla");
            Console.WriteLine($"Zmrzlinář prodal {5 - valinka} vanilkové a {7 - coko} cokoládoké zmrzliny");
        }
    }
}
