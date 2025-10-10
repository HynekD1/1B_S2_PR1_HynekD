using System.ComponentModel.Design;

namespace podminka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadje mi číslo a ti řeknu zda je větší než 10");
            int cislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Číslo {cislo} je větší než 10? {cislo > 10}");

            //Základní podmínka IF
            //if (podminka) podminka musí být TRUE/FALSE
            //{} vše ve složených závorkách spustí, pokud je podmínka TRUE
            if (cislo > 10) ; //tady se musí napsat podmínka
            {
                //Tento kód se prustí, pokud je podmínka splněna(TRUE)
                //v našem případě, to znamená, že číslo je větší než!
                Console.WriteLine($"Hurá! {cislo} je větší než 10!");
            }

            //IF s ELSE
            if (cislo > 10)
            {
                //Tento kód se prustí, pokud je podmínka splněna(TRUE)
                Console.WriteLine($"Hurá! {cislo} je větší než 10!");
            }
            else  //jinak
            {
                //Tento kód se prustí, pokud není podmínka splněna(FALSE)
                Console.WriteLine($"Bohužel! {cislo} není větší než 10!");

            }

            //Semafór  !!Původní!!
            /*Console.WriteLine("Svítí na semaforu zalená? (a/n)");
            string odpoved = Console.ReadLine();
            if (odpoved == "a")
            {
                Console.WriteLine("JDI!");
            }
            else
            {
                Console.WriteLine("STŮJ!");
            }
            */

            Console.WriteLine("Svítí na semaforu zalená? (a/n)");
            string odpoved = Console.ReadLine();
            if (odpoved == "a")
            {
                Console.WriteLine("JDI!");
            }
            else
            {
                if (odpoved == "n")
                {
                    Console.WriteLine("STŮJ!");


                }
                else
                {
                    Console.WriteLine("ERROR!");

                }

            }





        }
    }
}
