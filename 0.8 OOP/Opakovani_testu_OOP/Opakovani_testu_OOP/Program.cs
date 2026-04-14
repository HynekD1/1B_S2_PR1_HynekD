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

            Console.WriteLine("Zadej odbornost");
            int odbornost = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet hodin");
            int pocetH = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej rozpocet");
            int rozpocet = int.Parse(Console.ReadLine());

            ukoly[pocetZadanchUkolu] = new Task(pocetZadanchUkolu, (KategoriePrace)odbornost, pocetH, rozpocet);
            pocetZadanchUkolu++;
        }
    }
}
