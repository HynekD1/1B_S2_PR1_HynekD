namespace List_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List - dynamická kolekce

            //Deklarace listu
            List<string> SeznamJmen = new List<string>(); //list stringů
            //Incializace listu s hodnotami z pole
            int[] poleCisla = { 10, 20, 30 };
            List<int> SeznamCisel = new List<int>(poleCisla); //incializace listu hodnotami z pole

            //Přidávání prvků do listu
            SeznamJmen.Add("Fanda Novák");
            SeznamJmen.Add("Lucie Poláčková");
            SeznamJmen.Add("Gabriel Kacz");
            //Console.WriteLine(SeznamJmen[0]); indexace jako pole

            //Přidání více hodnot do listu
            SeznamCisel.AddRange(poleCisla); //přidání všech hodnot z pole
            //Console.WriteLine(SeznamCisel[4]);
            string[] jmena = { "Jirka Král", "Zdeněk Hrouda" };
            SeznamJmen.AddRange(jmena);

            //Atribut Count a Capacity
            Console.WriteLine(SeznamJmen.Count); //vrací počet hodnot v listu
            Console.WriteLine(SeznamJmen.Capacity); //vrací kapacitu listu (zavislá na tom, jak jsme přidávali prvky)

            //Iterace pomocí for cyklu s využitím hodnoty Count
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.WriteLine(SeznamJmen[i]);
            }

            //Insert - připíše hodnotu na daný index a list se posune
            SeznamJmen.Insert(0, "Pepa Dlouhý");
            Console.WriteLine(SeznamJmen[0]);

            //Lze stále měnit hodnoty jako u pole
            SeznamJmen[0] = "Pepan Dlouhý";
            Console.WriteLine(SeznamJmen[0]);


            Console.WriteLine("---------------------------");
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.WriteLine(SeznamJmen[i]);
            }

            //REMOVE - odstranění prvku z listu
            SeznamJmen.Remove("Jirka Král"); //Smaže konkrétní prvek z listu
            SeznamJmen.RemoveAt(0); //Smaže hodnotu na konkrétním indexu
            SeznamJmen.RemoveRange(1, 2); //Smaže hodnoty od konkrétního indexu, konkrétní počet!
            Console.WriteLine("---------------------------");
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.WriteLine(SeznamJmen[i]);
            }
            //SeznamJmen.Clear() vymaže všechny hodnoty z listu

            //IndexOf - používá se na zjištování na jakém indexu prvek, případně jestli daný prvek vůbec je v listu
            Console.WriteLine(SeznamJmen.IndexOf("Zdeněk Hrouda")); //vrátí index na kterém se hodnota nachází
            Console.WriteLine(SeznamJmen.IndexOf("Vavřinec Smutný")); //vratí -1, protože daný prvek v listu není

            //SeznamCisel - 10,20,30,10,20,30 - co bude vracet IndexOf?
            Console.WriteLine("------------");
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }
            SeznamCisel.Add(10);

            //Jelikož existují dvě 10 v SeznamCisel, tak to vrátí INDEX té PRVNÍ
            Console.WriteLine(SeznamCisel.IndexOf(10)); //0
            //Jelikož existují dvě 10 v SeznamCisel, tak LASTINDEXOF vrací INDEX poslední!
            Console.WriteLine(SeznamCisel.LastIndexOf(10)); //6

            //SORT
            SeznamCisel.Sort();
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }
            //REVERSE
            SeznamCisel.Reverse();
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }

            //Z listu na pole - metoda ToArray
            string[] poleZListu = SeznamJmen.ToArray();

            //List objektů
            List<Student> SeznamStudentu = new List<Student>();
            for (int i = 0; i < 1000; i++)
            {
                SeznamStudentu.Add(new Student());
            }
            foreach (Student student in SeznamStudentu)
            {
                Console.Write(student.ID + " ");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");









            List<string> Knihy = new List<string>();
            string[] books = {"Narnie", "Rammstein"};
            for (int i = 0; i < books.Length; i++)
            {
                Knihy.Add(books[i]);
            }
            Knihy.AddRange(books);
            Knihy.Add("Harry Potter");
            Knihy.Add("Pán Prstenů");
            Knihy.Add("Aladin");
            Knihy.Add("Grand Turismo");
            Knihy.Add("F1");

            
            
            Console.WriteLine(Knihy.Count);
            Console.WriteLine(Knihy.Capacity);
            Console.WriteLine("---------------------------");
            foreach (var kniha in Knihy)
            {
                Console.WriteLine(kniha);
            }

            Knihy.Remove("Harry Potter");

            Knihy.Insert(0, "Dexter");

            Knihy[1] = ("Kouzelná Školka");

            

            Console.WriteLine("---------------------------");
            foreach (var kniha in Knihy)
            {
                Console.WriteLine(kniha);
            }
            Console.WriteLine(Knihy.IndexOf("Matka roku"));
            Console.WriteLine(Knihy.IndexOf("Dexter"));

            Knihy.Sort();
            Console.WriteLine("---------------------------");
            foreach (var kniha in Knihy)
            {
                Console.WriteLine(kniha);
            }

            Knihy.Reverse();
            Console.WriteLine("---------------------------");
            foreach (var kniha in Knihy)
            {
                Console.WriteLine(kniha);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(Knihy.IndexOf("Dexter"));
            Console.WriteLine(Knihy.IndexOf("Core"));


        }
    }
}
