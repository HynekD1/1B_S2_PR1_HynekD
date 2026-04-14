using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace Bakalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            string[] moznajmena = {"Frankenštajn","Barbora","Cyril","Dominik","Ema","Filip","Gabriela","Hana", "Ivan", "Jana"};
            string[] moznatrida = { "A", "B", "C" };
            string[] moznepredmety = { "Matika", "Fyzika", "Programování" };

            // studenti
            Student[] studenti = new Student[10];
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i] = new Student(i, moznajmena[rnd.Next(0, moznajmena.Length)], $"{rnd.Next(0, 10) + moznatrida[rnd.Next(0, moznatrida.Length)]}");
            }

            

            // ucitele
            Ucitel[] Ucitele = new Ucitel[3];
            for (int i = 0; i < Ucitele.Length; i++)
            {
                Ucitele[i] = new Ucitel(i, moznajmena[rnd.Next(0, moznajmena.Length)]);
            }

            // predmety
            Predmet[] Predmety = new Predmet[3];
            for (int i = 0; i < Predmety.Length; i++)
            {
                Predmety[i] = new Predmet(i, moznepredmety[i], Ucitele[i]);
                Ucitele[i].Predmety[0] = Predmety[i];
            }

            // menu
            while (true)
            {
                
                Console.WriteLine("\n1 - Přidat známku");
                Console.WriteLine("2 - Vypsat studenty");
                Console.WriteLine("3 - Průměr studenta");
                Console.WriteLine("4 - Výpis známek studenta z předmětu");
                Console.WriteLine("0 - Konec");

                int volba = int.Parse(Console.ReadLine());
                if (volba == 1)
                {
                    Console.WriteLine("ID studenta:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("ID Predmětu:");
                    for (int i = 0; i < Predmety.Length; i++)
                    {
                        Console.WriteLine($"{i} - {Predmety[i].Nazev}");
                    }
                    int index_p = int.Parse(Console.ReadLine());

                    Console.WriteLine("známka (1-5):");
                    int hodnota = int.Parse(Console.ReadLine());

                    studenti[id].PridejZnamku(new Znamka(Predmety[index_p], hodnota, DateTime.Now));
                    
                    
                
                }
                else if(volba == 2)
                {
                    foreach (Student stud in studenti)
                    {
                        Console.WriteLine($"\n{stud.ID} - {stud.Jmeno} ({stud.Trida})");

                        for (int i = 0; i < stud.PocetZnamek; i++)
                        {
                            Console.WriteLine($"{stud.Znamky[i].Predmet.Nazev}: {stud.Znamky[i].Hodnota}");
                        }
                    }
                    
                }
                else if(volba == 3)
                {

                    Console.WriteLine("ID studenta:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Průměr: {studenti[id].VypoctitejPrumer():0.00}");
                    
                }
                else if(volba == 4)
                {
                    VypisZnamek(studenti, Predmety);
                }
                else if (volba == 0)
                {
                    break;
                }


            }

        }


        static void VypisZnamek(Student[] studenti, Predmet[] predmety)
        {
            // výběr studenta
            Console.WriteLine("Zadej ID studenta:");
            for (int i = 0; i < studenti.Length; i++)
            {
                Console.WriteLine($"{i} - {studenti[i].Jmeno}");
            }
            int id = int.Parse(Console.ReadLine());

            if (id < 0)
            {
                id = 0;
            }else if (id > 9)
            {
                id = 9;
            }

            // výběr předmětu
            Console.WriteLine("Zadej ID předmětu:");
            for (int i = 0; i < predmety.Length; i++)
            {
                Console.WriteLine($"{i} - {predmety[i].Nazev}");
            }

            int predm = int.Parse(Console.ReadLine());

            if (predm < 0 )
            {
                predm = 0;
            }else if (predm > 3)
            {
                predm = 2;
            }

            Console.WriteLine($"\nZnámky studenta {studenti[id].Jmeno} z {predmety[predm].Nazev}:");

            bool nasel = false;

            for (int i = 0; i < studenti[id].PocetZnamek; i++)
            {
                if (studenti[id].Znamky[i].Predmet == predmety[predm])
                {
                    Console.WriteLine($"{studenti[id].Znamky[i].Hodnota} ({studenti[id].Znamky[i].Datum:dd.MM.yyyy})");
                    nasel = true;
                }
            }

            if (!nasel)
            {
                Console.WriteLine("Žádné známky.");
            }
        }
    }
}
