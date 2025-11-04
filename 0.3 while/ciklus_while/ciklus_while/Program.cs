namespace ciklus_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odpočítávadlo s cyklem WHILE

            /*
            int pocitadlo = 5;
            
            //Cyklus se opakuje, dokud pocitadlo je větší, nebo mensí, nebo rovno 0
            while (pocitadlo >= 0) //Podmínka, pokud platí vykoná se tělo cyklu
            //Tělo cyklu - pokaždé se vykoná dokud podmínka platí
            {
                Console.WriteLine(pocitadlo + "!");
                pocitadlo--; // snížení počitadla o 1
            }
            Console.WriteLine("Start");
            

            int pocitadlo2 = 0;

            while (pocitadlo2 <= 10)
            {
                Console.WriteLine(pocitadlo2 + "!");
                pocitadlo2++;
            }
            Console.WriteLine("Start2!");
            */
            /*
            //Načítání slova z charů pomocí cyklu While
            string text = "";

            Console.WriteLine("Zadej mi znak a já ho pořídám do řetězce, ketrý nakonec vypíšu, pro ukončení zadej 0");
            char znak = Console.ReadKey().KeyChar;
            text += znak;
            while (znak != '0')
            {
                Console.WriteLine(" \nZadej mi další znak: (0 pro ukončení)");
                znak = Console.ReadKey().KeyChar;
                text += znak;
            }
            Console.WriteLine("\n" + text);
                */
            
            
            //Načítání znaků do stringu v2 - DO WHILE
            
            string text = "";
            char znak = ' ';


            Console.WriteLine("Zadej mi znak a já ho pořídám do řetězce, ketrý nakonec vypíšu, pro ukončení zadej 0");
            znak = Console.ReadKey().KeyChar;
            text += znak;
            do
            {
                Console.WriteLine(" \nZadej mi další znak: (0 pro ukončení)");
                znak = Console.ReadKey().KeyChar;
                //Podmínka, aby se do textu nepřídal ukončovací znak 0
                if(znak != '0')
                {
                    text += znak;

                }
                text += znak;
            } while (znak != '0') ;  
            //Podmínka cyklu se ověřuje nakonci až po průchodu tělem

            Console.WriteLine("\n" + text);



        }  
    }
}
