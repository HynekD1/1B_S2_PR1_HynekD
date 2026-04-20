namespace VozovyPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Vozidlo[] Vozidla = new Vozidlo[100];
            string[] znaky = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "1", "2", "3", "4", "5" };
            for (int i = 0; i < Vozidla.Length; i++)
            {
                string spz = "";
                for (int j = 0; j < 6; j++)
                {
                    spz += znaky[rnd.Next(znaky.Length)];

                    Vozidla[i] = new Vozidlo(spz, rnd.Next(1990, 2025), rnd.Next(1000, 300000));

                }
            }


            Prodejce[] Prodejci = new Prodejce[3];
            Prodejci[0] = new Prodejce("Novák");
            Prodejci[1] = new Prodejce("Svoboda");
            Prodejci[2] = new Prodejce("Dvořák");

            Console.WriteLine("Vyber si prodejce:");
            for (int i = 0; i < Prodejci.Length; i++)
            {
                Console.WriteLine( i + Prodejci[i].Jmeno);
            }

            int vyber = int.Parse(Console.ReadLine());
            Prodejce aktualni = Prodejci[vyber];
        }
    }
}
