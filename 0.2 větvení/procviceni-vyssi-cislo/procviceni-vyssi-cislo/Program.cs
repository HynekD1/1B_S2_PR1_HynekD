namespace procviceni_vyssi_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo x");
            int cislox = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej číslo y");
            int cisloy = Convert.ToInt32(Console.ReadLine());

            if(cislox == cisloy)
            {
                Console.WriteLine("Čísla si jsou rovna");
            }
            else
            {
                if (cislox < cisloy)
                {
                    Console.WriteLine("Číslo x je menší než číslo y");
                }
                else
                {
                    if (cislox > cisloy)
                    {
                        Console.WriteLine("Číslo x je větší než číslo y");
                    }
                    else
                    {
                        Console.WriteLine("Špatný vstup");
                    }
                }
            }
        }
    }
}
