namespace List_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List - Dynamická kolekce

            List<string> SeznamJmen = new List<string>(); // list stringů
            //Inicializace listu s hodnotami z pole
            int[] poleCisla = { 10, 20, 30 };
            List<int> SeznamCisel = new List<int>(poleCisla);


            //Pridávnáli prvků do listu
            SeznamJmen.Add("Fanda Novák");
            SeznamJmen.Add("Lucie Poláčková");
            SeznamJmen.Add("Gabriel Kacz");
            //Console.WriteLine(SeznamJmen[2]); // indexace jako pole

            //Přidávání více hodnot do listu
            SeznamCisel.AddRange(poleCisla);//Přidání všech hodnot pole
            Console.WriteLine(SeznamCisel[4]);
            string[] Jmena = { "Jirka Král", "Zdeněk Hrouda" };
            SeznamJmen.AddRange(Jmena);

            //Atribity Count a Capacity
            Console.WriteLine(SeznamJmen.Count); //Vrací počet hodnot v listu
            Console.WriteLine(SeznamJmen.Capacity); //vraci kapacitu v listu, Závislá na 

            //Iterace pomoci for cyklu s využitím hodnoty Count
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.WriteLine(SeznamJmen[i]);
            }

            //Insert - přepisuje hodnotu na daný index a list se posuse
            SeznamJmen.Insert(0, "Pepa Dlouhý");
            Console.WriteLine(SeznamJmen[0]);
            //Lzze stále menit hodnoty jako u pole
            SeznamJmen[0] = "Pepan Dlouhý";
            Console.WriteLine(SeznamJmen[0]);

            Console.WriteLine("------------------------------");

            //REMOVE - odstanění prvků z listu
            SeznamJmen.Remove("Jirka Král"); //Smaže konkrétní prvek z listu
            SeznamJmen.RemoveAt(0);
            SeznamJmen.RemoveRange(1, 2); //Smaže hodnoty od konkrétního indexu, konrétní počet
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.WriteLine(SeznamJmen[i]);
            }

            //SeznamJmen.Clear(); vymaže všechny hodntoy z listu

            //IndexOF
            Console.WriteLine(SeznamJmen.IndexOf("Zdeněk hrouda")); //Vrátí index na kterém se hodnota nachází
            Console.WriteLine(SeznamJmen.IndexOf("Vavřinec Smutný")); //Vrátí -1 protože daná hodnota se v listu nenachází. Používá se pro najití danné hodnoty

            //SeznamCisel
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }

            //Jelikož existuje dvě 10 v SeznamuCisel, tak to vrátí Index té První
            Console.WriteLine(SeznamCisel.IndexOf(10));
            //Jelikož existuje dvě 10 v SeznamuCisel, tak LASTINDEXOF vrací index poslední!
            Console.WriteLine(SeznamCisel.LastIndexOf(10));

            //Sort
            SeznamCisel.Sort();
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }

            //Revers
            SeznamCisel.Reverse();
            foreach (int cislo in SeznamCisel)
            {
                Console.WriteLine(cislo);
            }

            //Z listu na pole
            string[] poleZListu = SeznamJmen.ToArray();

            //List objekt
            List<Student> SeznamStudetu = new List<Student>();
            for (int i = 0; i < 1000; i++)
            {
                SeznamStudetu.Add(new Student());
            }
            foreach (Student student in SeznamStudetu)
            {
                Console.WriteLine(student.ID + " ");
            }
            

        }
    }
}
