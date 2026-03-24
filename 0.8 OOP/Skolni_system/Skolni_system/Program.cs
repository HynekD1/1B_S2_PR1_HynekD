using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Skolni_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student pepca = new Student(0, true);
            Student dominik = new Student(1, false, "Dominik");

            Console.WriteLine(pepca.jmeno);
            Console.WriteLine(dominik.jmeno);
            */

            Student[] skola = new Student[0]; //pole studentů s velikostí nula

            while (true) //menu v nekonečné smyčce
            {
                Console.Clear();
                Console.WriteLine("Napiš mi, co chceš dělat");
                Console.WriteLine("1. Zadat studenta\n2. Vygenerovat studenty\n3. Vypsat studety\n4. Zadej známku\n5. Vypiš známku");
                int volba = OverVstup();

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadej mi jméno nového studenta");
                        string jmeno = Console.ReadLine();
                        Array.Resize(ref skola, skola.Length + 1);
                        skola[skola.Length - 1] = new Student(skola.Length, false, jmeno);
                        break;
                    case 2:
                        Console.WriteLine("Kolik chceš studentů vygenerovat?");
                        int pocet = OverVstup();
                        for (int i = 0; i < pocet; i++)
                        {
                            Array.Resize(ref skola, skola.Length + 1);
                            skola[skola.Length - 1] = new Student(skola.Length, true);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < skola.Length; i++)
                        {
                            skola[i].PredstavSe();
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Z jakého předmětu:");
                        string predmet = Console.ReadLine();
                        Console.WriteLine("Jakou váhu?");
                        int vaha = OverVstup();
                        Console.WriteLine("Jakou známku?");
                        int znamka = OverVstup();
                        Console.WriteLine("Zadej mi jeho ID?");
                        int id = OverVstup();
                        skola[id - 1].PridejZnamku(znamka, vaha, predmet);
                        break;
                    case 5:
                        Console.WriteLine("Zadej mi ID studenta");
                        int id_ = OverVstup();
                        skola[id_ - 1].PredstavSe();
                        skola[id_ - 1].VypisZnamky();
                        Console.ReadKey();
                        break;

                }
            }
        }

        static int OverVstup()
        {
            int cislo = 0;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadej číslo!");
            }
            return cislo;
        }
    }
}
