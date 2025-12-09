namespace Uvod_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializace pole
            //pole o délce 3 s třema zadanýma hodnotama
            int[] cisla = { 25, 30, 25 };
            //pole o délce 10 bez zadaných hodnot
            string[] jmena = new string[10];

            //práce s hodnotami v poli
            Console.WriteLine(cisla[0]); //první prvek z pole cisla
            Console.WriteLine(cisla[2]); //prvek z pole čísla na indexu 2
            Console.WriteLine(cisla[cisla.Length-1]); //vypíše poslední prvek z pole cisla

            //Přepis hodnot
            cisla[0] = 5;
            jmena[0] = "Jaromír";
            jmena[1] = "Vavřinec";
            //název pole[index] = hodnota

            //procházení pole
            //Cyklus for

            //Dokud je i menší než délka pole, tak se cyklus opakuje
            //Délka pole jmena je  a má indexy od 0 do 9
            for (int i = 0; i < jmena.Length; i++)
            {
                //Postupně změní všechny hodnoty v poli jmena na hodnotu "jindřich"
                jmena[i] = "Jindřich";
            }
            for (int i = 0; i < jmena.Length; i++)
            {
                //Postupně vypíše všechny prvky z pole jmena
                Console.WriteLine(jmena[i]);
            }

            //Naplnění pole
            //Napln pole násobky, násobky čísla uložené v proměnné násobek od 1-10
            int[] nasobky = new int[10];
            int nasobek = 2;

            for (int i = 0; i < nasobky.Length; i++)
            {
                nasobky[i] = nasobek * (i + 1);
                
                Console.WriteLine(nasobky[i]);
            }

            //uživatel naplní pole čísly
            //následně se projde pole a vypíše se počet licých a sudých čísel

            int[] pole_cisla = new int[3];
            for (int i = 0; i < pole_cisla.Length; i++)
            {
                Console.WriteLine($"Zadej {i + 1}. číslo");
                while (!int.TryParse(Console.ReadLine(), out pole_cisla[i]))
                {
                    Console.WriteLine("Zadej mi opravdu číslo");
                }
            }
            int suda = 0;
            int licha = 0;
            for (int i = 0; i < pole_cisla.Length; i++)
            {
                if (pole_cisla[i] % 2 == 0)
                {
                    suda++;
                }
                else
                {
                    licha++;
                }
            }
            Console.WriteLine($"V poli je {suda} sudých čísel a {licha} lichých čísel");


            //Foreach průchod kolekcemi (btw. pole je kolekce)


            //Při každém průchodu foreachem se do proměné jmeno načte hodnota z pole jmena
            //forech vždy projde pole od začátku do konce
            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            //Foreach neumí přepisovat hodnoty v poli, které prochází
            /*
            foreach (string jmeno in jmena)
            {
                jmeno = "Pet";
            }
            */

            foreach (int cislo in cisla)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
