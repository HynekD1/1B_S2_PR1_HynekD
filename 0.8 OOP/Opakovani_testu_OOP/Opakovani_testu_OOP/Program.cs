namespace Opakovani_testu_OOP
{
    public enum KategoriePrace
    {
        VyvojSoftware,
        Marketing,
        Ucetnictvi,
        Grafika

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Worker[] pracovnici = new Worker[10];
            for (int i = 0; i < pracovnici.Length; i++)
            {
                pracovnici[i] = new Worker();
            }

            Task[] ukoly = new Task[50];
            int pocetZadanchUkolu = 0;

            int Vyber = 0;



            while (true)
            {
                Console.WriteLine("Co chces udělat?:");
                Console.WriteLine("\nZadat nový úkol(1)" +
                                  "\nVypsat kalkulaci(2)" +
                                  "\nKonec(3)");

                while (!int.TryParse(Console.ReadLine(), out Vyber))
                {
                    Console.WriteLine("Zadej číslo");
                }

                if (Vyber == 1)
                {
                    Console.WriteLine("Zadej odbornost (0-3)");
                    int odbornost;
                    while (!int.TryParse(Console.ReadLine(), out odbornost) || odbornost < 0 || odbornost > 3)
                    {
                        Console.WriteLine("Zadej číslo 0–3");
                    }

                    Console.WriteLine("Zadej pocet hodin");
                    int pocetH;
                    while (!int.TryParse(Console.ReadLine(), out pocetH))
                    {
                        Console.WriteLine("Zadej číslo");
                    }

                    Console.WriteLine("Zadej rozpocet");
                    int rozpocet;
                    while (!int.TryParse(Console.ReadLine(), out rozpocet))
                    {
                        Console.WriteLine("Zadej číslo");
                    }

                    ukoly[pocetZadanchUkolu] = new Task(pocetZadanchUkolu, (KategoriePrace)odbornost, pocetH, rozpocet);
                    pocetZadanchUkolu++;
                    Console.Clear();
                }
                else if (Vyber == 2)
                {
                    for (int i = 0; i < pocetZadanchUkolu; i++)
                    {
                        int pocetMoznyLidi = 0;        // reset pro každý úkol
                        double mzdoveNaklady = 0;      // součet sazeb vhodných pracovníků

                        for (int j = 0; j < pracovnici.Length; j++)
                        {
                            if (ukoly[i].PozadovanaOdbornost == pracovnici[j].Odbornost)
                            {
                                pocetMoznyLidi++;
                                mzdoveNaklady += pracovnici[j].HodinovaSazba;
                            }
                        }

                        if (pocetMoznyLidi == 0)
                        {
                            Console.WriteLine("Nelze realizovat – chybí personál");

                        }

                        double casNaPracovnika = ukoly[i].PocetHodin / pocetMoznyLidi;
                        double celkoveNaklady = casNaPracovnika * mzdoveNaklady;
                        double zisk = ukoly[i].RozpocetZakazky - celkoveNaklady;

                        Console.WriteLine($"Úkol ID: {ukoly[i].ID}");
                        Console.WriteLine($"Odbornost: {ukoly[i].PozadovanaOdbornost}");
                        Console.WriteLine($"Čas na pracovníka: {casNaPracovnika:F1} hod"); //F1 na jedno desetinné místo
                        Console.WriteLine($"Celkové náklady: {celkoveNaklady:F0} Kč");
                        Console.WriteLine();

                        Console.WriteLine($"Zisk: {zisk:F0} Kč");
                        Console.WriteLine();
                    }

                }
                else
                {
                    break;
                }


            }
        }
    }
}
