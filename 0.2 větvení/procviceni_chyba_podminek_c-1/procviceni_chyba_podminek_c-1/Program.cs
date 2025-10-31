namespace procviceni_chyba_podminek_c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš číslo: ");
            string nacteno = Console.ReadLine();
            double cislo = double.Parse(nacteno);

            if (cislo % 4 == 0)
            {
                Console.WriteLine($"Číslo {cislo} je dělitelné čtyřmi.");
            }
            else
            {
                Console.WriteLine($"Číslo {cislo} není dělitelné čtyřmi.");
            }
        }
    }
}
