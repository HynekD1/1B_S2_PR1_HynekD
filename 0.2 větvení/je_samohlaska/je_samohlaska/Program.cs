namespace je_samohlaska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej jeden znak");
            string znak = Console.ReadLine();
            char a = znak[0];
            if (a == 97 || a == 101 || a == 105 || a == 111 || a == 117)
            {
                Console.WriteLine("Je samohláska");
            }else
            {
                Console.WriteLine("Není samohláska");
            }

        }
    }
}
