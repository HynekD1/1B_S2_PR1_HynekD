using System.ComponentModel;

namespace Pruvodci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stanice = { "Jablonec nad Nisou", "Turnov", "Semily", "Železný brod" };
            string[] jizdenky = { "Dětská", "Student", "Dospělý", "Senior" };
            int[] cenyjizdenek = { 10, 20, 50, 20 };

            Random gen = new Random();
            
            for (int i = 0; i < stanice.Length; i++)
            {
                
                int penezenka = gen.Next(0, 201);
                int index = gen.Next(0, jizdenky.Length);
                Console.WriteLine($"Nacházíme se ve stavini: {stanice[i]}");
                if (i == 3)
                {
                    Console.WriteLine("Konečná stanice. Prosím vystupte");
                    break;
                }
                while (penezenka > cenyjizdenek[index])
                {
                    Console.WriteLine("Zde si můžete koupit jízdenku");
                    Console.WriteLine(jizdenky[index] + " " + cenyjizdenek[index]);
                    penezenka = gen.Next(0, 201);
                    index = gen.Next(0, jizdenky.Length);
                    

                }
                Console.WriteLine("Pokračujeme do další stanice");
                Console.WriteLine();
                

            }
        }
    }
}
