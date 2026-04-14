namespace Opakovani_Firma
{
    //Enumerační typ (výčtový typ)
    public enum status
    {
        Prace,
        Nemoc,
        Dovolena
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] firma = new Worker[2];

            //incializace nového objektu na indexu 0 v poli firma
            firma[0] = new Worker("HR");

            //Vytvoření objektu mimo pole a vložení objektu do pole na index 1
            Worker worker1 = new Worker("Management");
            firma[1] = worker1;

            firma[0].PracovniDoba = 100;
            firma[1].PracovniDoba = -50;
            firma[1].PracovniDoba += 2;

            for (int i = 0; i < 2; i++)
            {
                firma[i].Introduction();
            }

            firma[1].Status = status.Dovolena;
            Random rnd = new Random();
            firma[0].Status = (status)rnd.Next(0, 3);
            Console.WriteLine(firma[0].Status + " " + firma[1].Status);

            int denniVydaje = 0;
            for (int i = 0; i < firma.Length; i++)
            {
                denniVydaje += firma[i].HodinovaMzda * firma[i].PracovniDoba;
            }
            Console.WriteLine($"Tento den ve firmě stál firmu {denniVydaje}");

            denniVydaje = 0;
            for (int i = 0; i < firma.Length; i++)
            {
                if (firma[i].Status == status.Dovolena)
                {
                    int vydaje = firma[i].HodinovaMzda * firma[i].PracovniDoba;
                    denniVydaje += vydaje / 3;
                }
                else if (firma[i].Status == status.Nemoc)
                {
                    int vydaje = firma[i].HodinovaMzda * firma[i].PracovniDoba;
                    denniVydaje += vydaje / 2;
                }
                else
                {
                    denniVydaje += firma[i].HodinovaMzda * firma[i].PracovniDoba;
                }
            }
            Console.WriteLine($"Tento den ve firmě stál firmu {denniVydaje}");



        }
    }
}