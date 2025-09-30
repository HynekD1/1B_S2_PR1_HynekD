using System.Text.Json.Serialization;

namespace vystup_vstup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Příkaz na výpis do konzole (do řádku) jeden příkaz jeden řádek
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ahoj, Světe!");

            //Příkaz pro výpis na stejný řádek
            Console.Write("Ahoj");
            Console.Write(" světe 2");
            Console.WriteLine(" A tohle bude na novém rádku");

            //Pokud chci něco vypsat do konzole
            //Na řádek a pak zalomit: Console.WriteLine(co to chce vypsat)
            //Na jeden řádek bez zalomení: Console.Write(co chci vypsat)

            //Proměnné
            //Deklarace proměnné - typ název
            string jmeno;
            int cislo;
            int cele_cislo; //Mezera=_
            int celeCislo; //druhe slovo začíná Velkým písmenem
            string _cilso5; //Nesmí začínat čílsem ale _ ANO

            // Incializace proměnné - typ nazev = hodnota
            string name = "Jan"; //string, že hodnota musí být ""
            int myInt = 5;

            Console.WriteLine(name);
            Console.WriteLine(myInt);
            //Console.WriteLine(jmeno); nelze vypsat hodnptu, nemá žádnou přiřazenou

            //Přižazení hodnoty k proměnné
            //Název hodnoty
            jmeno = "Honza";
            Console.WriteLine(jmeno);
            name = "John";
            Console.WriteLine(name);

            cislo = 10;
            Console.WriteLine(cislo);    //10
            cislo = 5;
            Console.WriteLine(cislo);   //5

            //Vypsat do konzole
            Console.WriteLine("Ahoj "+name +"!");
            Console.WriteLine(name + " " +jmeno);
            Console.WriteLine("My name is " + name + " and Iam " + myInt + " years old!");
            //pokud je int v rámci slepeného stringu, tak se jen slepí cilso+myInt = 55
            Console.WriteLine("You have " + cislo+myInt + " dollars!");
            //Pokud ale není v rámci stringu, tak se sečtou
            Console.WriteLine(cislo+myInt);
            //to lze uělat i vložením závorky
            Console.WriteLine("You have " + (cislo + myInt) + " dollars!");

            //vložení vstupu od uživatele
            Console.WriteLine("Napiš mi své jméno");
            string username = Console.ReadLine(); // čte z konzole vstup
            Console.WriteLine("Ahoj "+ username + "!"); //vypíše jméno 

            //Jak vypsat pro uživatele ve stringu hodnoty proměnných bez +
            Console.WriteLine("Ahoj " + username + "!");
            //Před první uvozovku se dá $(ů+alt gr)
            //Kamkoli de sringu napsat název proměnné v složených závorkách
            Console.WriteLine($"Ahoj {username} !");
            //kam chci dát proměnnou tak bapíšu její pizici za string počínající 0(ve složených závorkách)
            //a za string píšu za čátku názvy proměnných
            Console.WriteLine("Ahoj {0} !",username);

            //syntaxe se dvěma proměnnýma
            Console.WriteLine("Ahoj {0} a je ti {1} !");

        }
    }
}
