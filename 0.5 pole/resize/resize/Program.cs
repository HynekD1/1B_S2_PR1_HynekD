namespace resize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializace
            int[] cisla = { 2, 5, 6, 7 }; //velikost 4
            string[] slova = new string[10]; //prázdná pole s velikostí 10

            Console.WriteLine(cisla[0]);
            Console.WriteLine(slova[0]);

            Console.WriteLine(cisla[5]); //index neexistuje
            Console.WriteLine(slova[5]);

            //Resize
            Array.Resize(ref slova, 5);
            Console.WriteLine(slova.Length);

            foreach (int cislo in cisla)
            {
                Console.WriteLine(cisla);
            }
            Array.Resize(ref cisla, 2); //změna velikosti pole cisla z 4 na 2
            foreach(int cislo in cisla)
            {
                Console.WriteLine(cislo); //vypíše:  2, 5
            }


            //Prakticé použití
            string[] hraci = { "Pepa", "Lukáš", "Zdenda", "Karel" };
            foreach(string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();
            //Jak do pole přidat martina?
            Array.Resize(ref hraci, hraci.Length + 1); //Zvětšení pole hráčů o 1
            hraci[hraci.Length - 1] = "Martin"; //Na poslední nový index v poli přidám Martina
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();

            //Jak z pole odebrat lukáše?
            string lavicka = ""; //Pomocné proměná 
            lavicka = hraci[1]; //Lukáš
            hraci[1] = hraci[hraci.Length - 1]; //Marinem přepisuji hodnotu Lukáše
            hraci[hraci.Length - 1] = lavicka; //Lukášem přepisuji půvoní hodnotu Martina
            foreach(string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();
            Array.Resize(ref hraci, hraci.Length - 1); //zkrátit pole o 1
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();


        }
    }
}
 