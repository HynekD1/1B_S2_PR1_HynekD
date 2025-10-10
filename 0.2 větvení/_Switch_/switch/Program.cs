using System.Linq.Expressions;

namespace _Switch_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej mi pořadové číslo dne v týdnu (ˇ1-7)");
        int den = Convert.ToInt32(Console.ReadLine());

        switch(den)
        {
            //hodnotu porovnání s jednotlivými case
            case 1:
                Console.WriteLine("Pondělí");
                break; //ukončení bloku kódu, v tomto případě vyskočí ze switche ven
            case 2:
                Console.WriteLine("Úterý");
                break;
            case 3:
                Console.WriteLine("Středa");
                break;
            case 4:
                Console.WriteLine("Čtvrtek");
                break;
            case 5:
                Console.WriteLine("Pátek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Neděle");
                break;
            default: //Vše co neodpovídá vstupu
                Console.WriteLine("Chyba ve vstupu");
                break;
        }
        
        //Switch - je víkend
        switch (den)
        {
            //deklaruje se proměnná x a přiřadí se k ní hodnota den
            //pak lze za when zapsat podmínku (bool)
            case int x when (x == 6 || x == 7):
                Console.WriteLine("Je víkend");
                break;
            case int x when (x < 1 || x > 7):
                Console.WriteLine("Neplatný vstup");
                break;
            default:
                Console.WriteLine("Je to den v týdnu");
                break;
        }
    }
}
