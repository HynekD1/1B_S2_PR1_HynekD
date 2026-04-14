namespace Proc_Vozovi_park
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vozidlo[] vozidla = new Vozidlo[]
                {
                    new Vozidlo("SPZ0000", 2001, 120000),
                    new Vozidlo("SPZ0001", 1999, 84000),
                    new Vozidlo("SPZ0002", 2010, 45000),
                    new Vozidlo("SPZ0003", 2020, 15000),
                    new Vozidlo("SPZ0004", 2018, 76000),
                    new Vozidlo("SPZ0005", 2005, 183000),
                    new Vozidlo("SPZ0006", 2015, 92000),
                    new Vozidlo("SPZ0007", 2012, 134000),
                    new Vozidlo("SPZ0008", 2008, 167000),
                    new Vozidlo("SPZ0009", 2019, 31000),

                    new Vozidlo("SPZ0010", 1995, 240000),
                    new Vozidlo("SPZ0011", 2003, 99000),
                    new Vozidlo("SPZ0012", 2016, 56000),
                    new Vozidlo("SPZ0013", 2021, 9000),
                    new Vozidlo("SPZ0014", 2007, 178000),
                    new Vozidlo("SPZ0015", 2014, 80000),
                    new Vozidlo("SPZ0016", 1998, 225000),
                    new Vozidlo("SPZ0017", 2022, 3000),
                    new Vozidlo("SPZ0018", 2002, 140000),
                    new Vozidlo("SPZ0019", 2013, 69000),

                    new Vozidlo("SPZ0020", 2006, 150000),
                    new Vozidlo("SPZ0021", 1993, 260000),
                    new Vozidlo("SPZ0022", 2017, 50000),
                    new Vozidlo("SPZ0023", 2020, 20000),
                    new Vozidlo("SPZ0024", 2011, 99000),
                    new Vozidlo("SPZ0025", 2009, 153000),
                    new Vozidlo("SPZ0026", 2004, 170000),
                    new Vozidlo("SPZ0027", 1990, 280000),
                    new Vozidlo("SPZ0028", 2018, 62000),
                    new Vozidlo("SPZ0029", 2023, 1000),

                    new Vozidlo("SPZ0030", 2001, 110000),
                    new Vozidlo("SPZ0031", 2000, 98000),
                    new Vozidlo("SPZ0032", 2014, 76000),
                    new Vozidlo("SPZ0033", 2019, 33000),
                    new Vozidlo("SPZ0034", 2013, 87000),
                    new Vozidlo("SPZ0035", 2008, 160000),
                    new Vozidlo("SPZ0036", 2021, 7000),
                    new Vozidlo("SPZ0037", 1996, 245000),
                    new Vozidlo("SPZ0038", 2005, 130000),
                    new Vozidlo("SPZ0039", 2017, 59000),

                    new Vozidlo("SPZ0040", 2010, 74000),
                    new Vozidlo("SPZ0041", 2003, 150000),
                    new Vozidlo("SPZ0042", 2024, 500),
                    new Vozidlo("SPZ0043", 2012, 82000),
                    new Vozidlo("SPZ0044", 2016, 69000),
                    new Vozidlo("SPZ0045", 2020, 23000),
                    new Vozidlo("SPZ0046", 1997, 230000),
                    new Vozidlo("SPZ0047", 2007, 175000),
                    new Vozidlo("SPZ0048", 2018, 51000),
                    new Vozidlo("SPZ0049", 2025, 100),

                    new Vozidlo("SPZ0050", 2009, 140000),
                    new Vozidlo("SPZ0051", 2011, 103000),
                    new Vozidlo("SPZ0052", 2006, 165000),
                    new Vozidlo("SPZ0053", 2015, 80000),
                    new Vozidlo("SPZ0054", 1994, 255000),
                    new Vozidlo("SPZ0055", 1999, 210000),
                    new Vozidlo("SPZ0056", 2013, 64000),
                    new Vozidlo("SPZ0057", 2021, 6000),
                    new Vozidlo("SPZ0058", 2016, 73000),
                    new Vozidlo("SPZ0059", 2019, 29000),

                    new Vozidlo("SPZ0060", 2000, 180000),
                    new Vozidlo("SPZ0061", 2002, 150000),
                    new Vozidlo("SPZ0062", 1991, 270000),
                    new Vozidlo("SPZ0063", 2017, 55000),
                    new Vozidlo("SPZ0064", 2020, 14000),
                    new Vozidlo("SPZ0065", 2018, 76000),
                    new Vozidlo("SPZ0066", 2004, 135000),
                    new Vozidlo("SPZ0067", 1995, 260000),
                    new Vozidlo("SPZ0068", 2014, 82000),
                    new Vozidlo("SPZ0069", 2023, 2000),

                    new Vozidlo("SPZ0070", 2001, 145000),
                    new Vozidlo("SPZ0071", 2010, 88000),
                    new Vozidlo("SPZ0072", 2012, 97000),
                    new Vozidlo("SPZ0073", 2016, 63000),
                    new Vozidlo("SPZ0074", 2019, 21000),
                    new Vozidlo("SPZ0075", 2005, 160000),
                    new Vozidlo("SPZ0076", 2008, 172000),
                    new Vozidlo("SPZ0077", 2022, 4000),
                    new Vozidlo("SPZ0078", 2015, 69000),
                    new Vozidlo("SPZ0079", 2003, 153000),

                    new Vozidlo("SPZ0080", 1999, 220000),
                    new Vozidlo("SPZ0081", 2007, 180000),
                    new Vozidlo("SPZ0082", 2011, 105000),
                    new Vozidlo("SPZ0083", 2017, 65000),
                    new Vozidlo("SPZ0084", 2020, 17000),
                    new Vozidlo("SPZ0085", 2018, 54000),
                    new Vozidlo("SPZ0086", 2009, 147000),
                    new Vozidlo("SPZ0087", 2004, 172000),
                    new Vozidlo("SPZ0088", 2013, 70000),
                    new Vozidlo("SPZ0089", 2024, 900),

                    new Vozidlo("SPZ0090", 2002, 160000),
                    new Vozidlo("SPZ0091", 1993, 265000),
                    new Vozidlo("SPZ0092", 2008, 155000),
                    new Vozidlo("SPZ0093", 2016, 72000),
                    new Vozidlo("SPZ0094", 2021, 8000),
                    new Vozidlo("SPZ0095", 2014, 77000),
                    new Vozidlo("SPZ0096", 2019, 28000),
                    new Vozidlo("SPZ0097", 2006, 162000),
                    new Vozidlo("SPZ0098", 2017, 58000),
                    new Vozidlo("SPZ0099", 2025, 120)
                };
            Prodejce[] prodejci = new Prodejce[]
                {
                    new Prodejce("Jan Novak"),
                    new Prodejce("Petr Svoboda"),
                    new Prodejce("Karel Dvorak"),
                    new Prodejce("Lukas Vesely"),
                    new Prodejce("Martin Hajek"),
                    new Prodejce("Tomas Kriz"),
                    new Prodejce("Ondrej Sedlak"),
                    new Prodejce("David Horak"),
                    new Prodejce("Marek Pokorny"),
                    new Prodejce("Jiri Blaha")
                };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vyber uživatele za kterého se chceš přihlásit");
                for (int i = 0; i < prodejci.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {prodejci[i].Jmeno}");
                }
                int volba = OverCislo();
                Prodejce vybranyProdejce = prodejci[volba - 1];
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Jste přihlášen jako prodejce: {vybranyProdejce.Jmeno}");
                    Console.WriteLine("1. Přidej auto do své nabídky\n2. Prodej auto ze své nabídky\n3. Odhlášení");
                    int volba2 = OverCislo();
                    switch (volba2)
                    {
                        case 1:
                            for (int i = 0; i < vozidla.Length; i++)
                            {
                                if (vozidla[i].Dostupnost)
                                {
                                    Console.Write((i + 1) + ". ");
                                    vozidla[i].VypisInfo();
                                }
                            }
                            int volba_auto = OverCislo();
                            vybranyProdejce.PridejAuto(volba_auto - 1);
                            break;
                        case 2:
                            vybranyProdejce.VypisAuta(vozidla);
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }

        static public int OverCislo()
        {
            int cislo = 0;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadej číslo");
            }
            return cislo;
        }
    }
}
