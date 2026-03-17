namespace Uvod_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random – vytvoření objektu ze třídy Random
            Random gen = new Random();

            //Nový objekt ze třídy Auto
            Auto moje_auto = new Auto(); //inicializace objektu

            Auto sousedovo_auto; //deklarace objektu
            sousedovo_auto = new Auto(); //přiřazení hodnoty - objekt z třídy Auto

            //Volání vlastností objektu
            moje_auto.barva = "červená"; //uložení hodnota "červená do vlastnosti barva u objektu moje_auto
            moje_auto.hmotnost = 100;
            moje_auto.spz = "000000";

            Console.WriteLine($"Mám auto a to má barvu: {moje_auto.barva} a váží: {moje_auto.hmotnost} a spztka je {moje_auto.spz}");

            sousedovo_auto.barva = "černá";
            sousedovo_auto.hmotnost = 80;
            sousedovo_auto.spz = "11111";

            Console.WriteLine($"Moje auto má barvu {moje_auto.barva} a sousedovo auto naopak má barvu {sousedovo_auto.barva}");

            //Volání metody u objektu
            moje_auto.Zatrub();
            sousedovo_auto.Zatrub();

            moje_auto.PredstavSe();
            sousedovo_auto.PredstavSe();

            //Zapouzdření – Volání metod na vracení hodnoty soukromé položky a metody na její úpravu
            moje_auto.SetKola(5);
            Console.WriteLine($"Moje auto má {moje_auto.GetKola()} kola.");
            moje_auto.SetKola(moje_auto.GetKola() - 2);
            Console.WriteLine($"Moje auto má {moje_auto.GetKola()} kola.");
            moje_auto.SetKola(moje_auto.GetKola() - 10);
            Console.WriteLine($"Moje auto má {moje_auto.GetKola()} kola.");


            //Incializace objektu s hodnotami
            Auto sefovo_auto = new Auto
            {
                barva = "modrá",
                spz = "22222",
                hmotnost = 200,
                znacka = "Volvo"
            };
            sefovo_auto.PredstavSe();
            sefovo_auto.SetKola(1);
            Console.WriteLine(sefovo_auto.GetKola());
        }
    }
}