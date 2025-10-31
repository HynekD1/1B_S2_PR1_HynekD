namespace string_procvic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRING
            string txt = "Ahoj";
            string txt2 = "čus";
            //Délka řetězce
            Console.WriteLine(txt.Length); //string.length vraci počet znaků
            Console.WriteLine(txt.Length > txt2.Length);

            //Vyjmutí 1 charu ze stringu
            char a = txt[0]; //vyjme ze stringu txt znak na 0. indexu
            //"Ahoj" = 0.index = 'A'; 1. 'h'; 2. 'o'; 3. 'j'
            // Hranaté závorky: Pravý alt + f = [, Pravý alt + g ]
            Console.WriteLine(a);

            Console.WriteLine(txt[3]); // vypíše písmeno na 3. indexu (j)

            //Poslední ze stringu aniž bych věděl index posledního zkanku
            char posledni_znak = txt[txt.Length - 1];
            //dáélka - 1; "Ahoj" délka = 4; 4-1=3 (poslední index je 3)
            Console.WriteLine(posledni_znak);

            //Program zjisti zda znak je malé písmeno
            Console.WriteLine("Zadej mi znak");
            char znak = Console.ReadKey().KeyChar;

            //Převod char na int
            /*
            int cislo_ze_znaku = znak;
            Console.WriteLine(cislo_ze_znaku);
            */

            //ASCII tabulka převodu znaků na čísla
            // a = 97; z = 122, malá abecanda 97-122
            if (znak >= 97 && znak <= 122)
            {
                Console.WriteLine("Malá abeceda");
            }
            else
            {
                Console.WriteLine("Není malá abeceda");
            }

            //Program - První písmeno slova je velké písmeno?
            Console.WriteLine("Zadej mi slovo");
            string slovo = Console.ReadLine();

            //ASCII tabulka; 65 = A a 90 = Z
            //slovo[0] je znak na 0. indexu (první znak danného slova)
            if (slovo[0] >= 65 && slovo[0] <= 90)
            {
                Console.WriteLine("První písmeno je velké");
            }
            else
            {
                Console.WriteLine("První písmeno není velké");
            }
        }
    }
}
    