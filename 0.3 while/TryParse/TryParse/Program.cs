namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cislo = int.Parse(Console.ReadLine());
            //Chceme zabránot padání při zadání jiného vstupu než číslo

            Console.WriteLine("Zadej mi vstup");
            string vstup = Console.ReadLine();

            //int cislo = int.Parse(vstup);

            //pro bezpečný převod na číslo
            //datovy_typ.TryParse(vstup, out proměnné v datovém typu)

            int cislo = 0;
            int.TryParse(vstup, out cislo);
            //Pokud se to převést hodnotu v proměnné vstup na int a ten uložit do proměnné cislo
            Console.WriteLine(cislo);
            //Pokud je vstup hodnota. která lze převest na int, tak se převede a uloží do cisla
            //Pokud je vstupu hodnota, která NELZE převést na itn, tak se nic do cisla neukládá(zůstane tam stávající hodnota)

            double des_cislo = 0;
            Console.WriteLine("Zadej mi des. číslo");
            double.TryParse(Console.ReadLine(), out des_cislo);
            //upravený TryParse, aby místo proměnné se stringem bral rovnou vstup do konzole
            Console.WriteLine(des_cislo);

            //TryParse a cyklus While (pro donucení uživatele, aby nám zadal číslo)
            int zad_cislo = 0;
            Console.WriteLine("Zadej mi celé číslo, prosím!");
            while(!int.TryParse(Console.ReadLine(), out zad_cislo))
                //! neguje výraz (pokud se podaří parsovat podmínka je true, jinak false) - tohle negují
                //nyní podmínka říká pokud se nepodařilo parsovat, tak podmínka je true
            {
                Console.WriteLine("Hele kámo, to není číslo! Zadej mi fakt CEL0 číslo!");
            }
            Console.WriteLine(zad_cislo);

            double dess_cislo = 0;
            Console.WriteLine("Zadej mi desetinné číslo, prosím!");
            while (!double.TryParse(Console.ReadLine(), out dess_cislo))
            {
                Console.WriteLine("řekl jsem des číslo, tak dělej nebo si pro tebe pčíjdu!!");
            }
            Console.WriteLine(dess_cislo);



        }
    }
}
