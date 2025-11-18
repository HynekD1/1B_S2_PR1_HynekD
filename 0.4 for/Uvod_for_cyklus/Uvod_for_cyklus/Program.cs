namespace Uvod_for_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Výpís od 0 do 9
            for (int i = 0; i < 10; i++)
            //při začátku cyklu (pouze jednou) se inicializuje proměnná i s hodnotou 0
            //podmínka se ověřuje vždy, pokud platí cyklus se opakuje
            //i++ se stane vždy na konci průchodu tělem cyklu
            {
                Console.WriteLine($"Hodnota i: {i}");
            }

            Console.WriteLine("");
            
            //Výpis od 1 do 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Hodnota i: {i}");
            }

            Console.WriteLine("");

            //Výpis od 10 do 0
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Hodnota i: {i}");
            }

            //Hod x krát stěnnou kostkou
            int pocet_sten = 0;
            int pocet_hodu = 0;
            Random kostka = new Random();
            double soucet_hodu = 0;

            for (int i = 0; i > pocet_hodu; i++)
            {
                soucet_hodu += kostka.Next(1, pocet_sten + 1);
            }

            Console.WriteLine(soucet_hodu/pocet_sten);

            //Program uživatele vyzve, aby zadával čísla kladná.
            //Uživatel zadá celkově 10 čísel. Program na konci vypíše jejich součet.
            //Pokud ael uživatel zadá číslo záporné, pak zadávání okamžitě zkončí.

            int cislo = 1;
            int soucet = 0;
            for (int i = 0; i < 10 && cislo  > 0; i++)
            {
                Console.WriteLine($"Zadej mi {i + 1}. číslo:");
                
                while(!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo");
                }
                if(cislo > 0)
                {
                    soucet += cislo;
                }
                
            }

            Console.WriteLine(soucet);
        
        
        
        
        
        
        }
    }
}
