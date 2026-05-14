using System.Data;

namespace Prace_txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ahoj, náhodný text.";

            //File - WriteAllText a ReadAllText
            //Zapíše do text.txt (uložené v kořenové složce programu projektova_slozka -> bin -> Debug -> net 9.0
            File.WriteAllText("text.txt", text); //Přepisuje

            //Připisovací metoda
            File.AppendAllText("text.txt", "Tento text je také náhodný");

            //Načte text jako jeden string
            Console.WriteLine(File.ReadAllText("text.txt"));

            //Práce s daty souborů jako pole stringů
            string[] poleStaty = { "100 životů", "50 stamina", "20 mincí" };

            File.WriteAllLines("staty.txt", poleStaty);

            string[] noveVeci = { "10 diamantů", "100 šipek" };

            File.AppendAllLines("staty.txt", noveVeci);

            string[] vystup = File.ReadAllLines("staty.txt");
            foreach (string stat in vystup)
            {
                Console.WriteLine(stat);
            }


            //StreamWriter

            //true na konci říká, zda budeme připisovat, nebo přepisovat
            using (StreamWriter sw = new StreamWriter("test.txt", true))
            {
                sw.WriteLine("Další nový text přidaný do souboru");
                sw.WriteLine("A další text přidaný do souboru.");
            }

            //StreamReader
            using (StreamReader sr = new StreamReader("staty.txt"))
            {
                string radek = " ";

                while (radek != null)
                {
                    radek = sr.ReadLine();
                    Console.WriteLine(radek);
                }
            }

            File.WriteAllText("Ramm1.txt", "text psany mnou");

            File.WriteAllText("Ramm2.txt", "Ahoj");

            File.WriteAllText("Ramm3.txt", "Hoj ");
            File.AppendAllText("Ramm3.txt", "Rammstein");
            //File.WriteAllText("Ramm3.txt", "čus");

            Console.WriteLine(File.ReadAllText("Ramm1.txt"));
            Console.WriteLine(File.ReadAllText("Ramm2.txt"));
            Console.WriteLine(File.ReadAllText("Ramm3.txt"));


            using(StreamWriter sw = new StreamWriter("pes.txt", true))
            {
                sw.WriteLine("Přidaný soubor ");
                sw.WriteLine("Další přidaný soubor");
            }

            using (StreamReader sr = new StreamReader("pes.txt"))
            {
                string radek = " ";
                while ((radek = sr.ReadLine()) != null)
                {
                    Console.WriteLine(radek);
                }
            }

            Console.WriteLine(File.ReadAllText("pes.txt"));

        }
    }
}
