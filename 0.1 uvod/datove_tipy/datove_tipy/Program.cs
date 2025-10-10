using System.Collections.Concurrent;

namespace datove_tipy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desetinné číslo
            float desCislo = 4.555f; //f se v případě floatu ??
            //float se
            double myDouble = 4.123456789; //d se u doublu nemusí psát
            Console.WriteLine(desCislo);
            Console.WriteLine(myDouble);

            //boolean
            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            //char - jeden znak
            char znak = 'c'; //jednoduché uvozovky
            //SHIFT + ¨¨ (ta klávesa je poblíž ENTER a vedle!)
            znak = 'd';
            Console.WriteLine(znak);

            //vstup pro znak
            Console.WriteLine("Napiš jedno písmeno");
            char input = Console.ReadKey().KeyChar;
            //KeyChar musí být součástí, aby to rovnou bralo výstup ???
            Console.WriteLine();
            Console.WriteLine(input);

            //
            Console.WriteLine(input + " " +znak); //bez stringu to bude chary ???
            Console.WriteLine(input + znak);  //sčíta se to 
            //hodnoty znaků viz. ASCII tabulka

            //Převod datových tapů

            // int x = "9"; toto nefunguje
            //int y = 'd';
            //char na int lze, string na int nelze

            //Implicit casting
            //char na int na long na float na double (nelze ???
            float myFloat = znak; // char na float (lze)
            Console.WriteLine(myFloat);
            //znak = myFloat; //float na char (nelze)

            //Explicit csting
            //otočenářada jako u implicit casting
            znak = (char)myFloat;
            //jenom se přidává (typ na který převádím)
            Console.WriteLine(znak);

            //Když chci načíst od uživatele vstup
            //int inputX = Console.ReadLine(); tohle nelze
            //Console.ReadLine() načíta´á string


            //Sčítačka
            Console.WriteLine("Napiš čísla které chceš sečíst");
            string inputX = Console.ReadLine();
            //inputX převedu naf int x pomocí Convert
            int x = Convert.ToInt32(inputX);

            // inputY převedu na int y pomocí Parse
            string inputY = Console.ReadLine();
            int y = int.Parse(inputY);

            Console.WriteLine(x + y);

            //Sčítačka 2.0
            Console.WriteLine("Napiš čísla které chceš sečíst");
            x = Convert.ToInt32(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
        }
    }
}