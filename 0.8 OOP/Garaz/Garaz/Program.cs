using Garaz_Kolekce;

namespace Garaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Incializace objektu z třídy Auto
            Auto moje_auto = new Auto();

            //Nahraní hodnot do vlastností
            moje_auto.pocetKol = 4;
            moje_auto.SPZ = "XXX";

            //Incializace objektu s hodnotami na vlastnotech
            Auto sousedovo_auto = new Auto
            {
                SPZ = "YYY",
                pocetKol = 3
            };

            //Volání metody u objektů
            moje_auto.PredstavSe();
            sousedovo_auto.PredstavSe();

            //Volání metod s parametrem
            sousedovo_auto.OdeberKola(2);
            sousedovo_auto.PredstavSe();
            sousedovo_auto.OdeberKola(2);
            sousedovo_auto.PredstavSe();

            //Vlastnost jako pole
            moje_auto.pasazeri = ["Šimon", "Fanda", "Ondřej"];
            sousedovo_auto.pasazeri = ["Elena", "Tomáš"];

            //Vypsání hodnot z pole, které je vlastnost objektu
            Console.WriteLine(moje_auto.pasazeri[1]); //vypíše u objektu moje_auto, co je ve vlastnosti pasazeri (pole) na 1. indexu
            Console.WriteLine(moje_auto.VratPasazery());
            Console.WriteLine(sousedovo_auto.VratPasazery());

            //Kolekce objektů
            Auto[] garaz = { moje_auto, sousedovo_auto };
            Console.WriteLine(garaz[0].pasazeri[1]);

            //Chci vypsat všechny pasazeri ve všech autech v garáži (bez použití metody VratPasazeri)
            for (int i = 0; i < garaz.Length; i++) //Vnější cyklus jde po objektech v poli garaž
            {
                Console.WriteLine($"Auto na indexu {i}. v garáži:");
                for (int j = 0; j < garaz[i].pasazeri.Length; j++) //vnitřní cyklus u vybranného objektu vnějším cyklem jde po jednotlivých prvních v lastnosti pasazeri
                {
                    Console.WriteLine(garaz[i].pasazeri[j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                
            }


            //přidání auta do garáže
            Array.Resize(ref garaz, garaz.Length + 1);
            garaz[garaz.Length - 1] = new Auto();
            garaz[garaz.Length - 1].SPZ = "CCC";
            garaz[garaz.Length - 1].pocetKol = 2;
            garaz[garaz.Length - 1].pasazeri = ["Dominik"];

            Array.Resize(ref garaz, garaz.Length + 1);
            garaz[garaz.Length - 1] = new Auto
            {
                SPZ = "TTT",
                pocetKol = 4,
                pasazeri = ["Adam", "Tobiáš"]
            };

            //Výpis všech aut z garáže (s využitím metody VratPasazery)
            for (int i = 0; i < garaz.Length; i++)
            {
                Console.WriteLine($"Auto na indexu {i}. v garáži:");
                Console.WriteLine(garaz[i].VratPasazery());
                Console.WriteLine("------------------------");
            }
                


                
        }
    }
}
