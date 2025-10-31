namespace kvalita_hesla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Zadej heslo");
            string heslo = Console.ReadLine();
            if (heslo.Length <= 5)
            {
                Console.WriteLine("Nekvalitní heslo");
            }
            else
            {
                if(heslo.Length >=6 && heslo.Length <=9)
                {
                    Console.WriteLine("Dobré heslo");
                }
                else
                {

                }
            }
            */



            Console.WriteLine("Zadej své křestní jméno");

            string jmeno = Console.ReadLine();

            char prvni_pismeno = jmeno[0];
            switch (prvni_pismeno)
            {
                case char a when (a == 'a' || a == 'A'):
                    Console.WriteLine("SUPER");
                    break;
                case char a when (a == 'z' || a == 'Z'):
                    Console.WriteLine("Znamenitý začítek");
                    break;
                default:
                    Console.WriteLine("Špatný vstup");
                    break;

            }
        }
    }
}
