using System.Collections.Immutable;
using System.Globalization;

namespace Dictionary_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Určuji jaký datový typ je klíč a jaký je hodnota
            Dictionary<string, string> CeskoAnglickySlovnik = new Dictionary<string, string>();

            CeskoAnglickySlovnik.Add("Auto", "Car");

            Console.WriteLine(CeskoAnglickySlovnik["Auto"]);

            Dictionary<string, int> TelefoniSeznam = new Dictionary<string, int>();
            TelefoniSeznam.Add("Pepa Omáčka", 483111222);
            TelefoniSeznam.Add("Jindřich Smutný", 483951357);

            Console.WriteLine(TelefoniSeznam["Pepa Omáčka"]);

            //Iterace Dicationary
            foreach (string klic in TelefoniSeznam.Keys)
            {
                Console.WriteLine(klic + ": " + TelefoniSeznam[klic]);
            }
            foreach (int hodnota in TelefoniSeznam.Values)
            {
                Console.WriteLine(hodnota);
            }
            foreach (KeyValuePair<string, int> zaznam in TelefoniSeznam)
            {
                Console.WriteLine(zaznam.Key + ": " + zaznam.Value);
            }

            //Remove
            TelefoniSeznam.Remove("Pepa Omáčka"); //Vymaže položku z slovníku na klíči "Pepa Omáčka"

            //Contains
            //ContainsKey/Value vrací true/false pokud daný klíč/hodnota je v slovníku
            Console.WriteLine(TelefoniSeznam.ContainsKey("Pepa Omáčka"));
            Console.WriteLine(TelefoniSeznam.ContainsValue(483951357));





            Console.WriteLine("----------------------------------------------------------------");


            Dictionary<string, int> PismenoCislo = new Dictionary<string, int>();
            for (int i = 0; i < 26; i++)
            {
                PismenoCislo.Add($"{(char)(65 + i)}", i + 1);
            }
            PismenoCislo.Remove("A");
            PismenoCislo.ContainsValue(2);
            foreach (string klic in PismenoCislo.Keys)
            {
                Console.WriteLine($"{klic} je písmeno {PismenoCislo[klic]}");
            }

            foreach (var hodnota in PismenoCislo)
            {
                Console.WriteLine($"{hodnota.Key} je číslo {hodnota.Value}");
            }

            


            foreach (int klic in PismenoCislo.Values)
            {
                Console.WriteLine(klic);
            }

            Console.WriteLine(PismenoCislo.ContainsKey("G"));
            Console.WriteLine(PismenoCislo.ContainsValue(6));
            Console.WriteLine(PismenoCislo.ContainsValue(26));


            Console.WriteLine("----------------------------------------------------------------");



            Dictionary<int, string> cisloPismeno = new Dictionary<int, string>();
            cisloPismeno.Add(1, "A");

            foreach (var klic in cisloPismeno.Keys)
            {
                Console.WriteLine(klic);
            }


        }
    }
}
