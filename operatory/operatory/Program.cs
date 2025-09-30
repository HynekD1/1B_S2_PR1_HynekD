namespace operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            //Inkriminace
            x++;
            x++;
            //Deinkriminace
            Console.WriteLine(x);

            //Přiřazovací operátory
            //do proměnné x se uloží její původní hodnota + 2
            x = x + 2;
            Console.WriteLine(x);
            //Zkrácený zápis
            x += 2;
            x -= 2;
            Console.WriteLine(x);

            //Porovnávací operátory
            // == je rovnáce
            // == je přiřad hodnotu
            Console.WriteLine(1==1);
            Console.WriteLine(1==2);
            Console.WriteLine( 5 > 1);
            Console.WriteLine( 1 < 5);

            // Větší a rovno a menší a rovno
            Console.WriteLine( 5 < 5);
            Console.WriteLine(5 <= 5);

            //Negace (nerovná se = !)
            Console.WriteLine(5 != 5);
            Console.WriteLine(1 != 5);

        }
    }
}
