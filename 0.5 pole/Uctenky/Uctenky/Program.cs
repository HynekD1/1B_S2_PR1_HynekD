using System.IO.Pipes;

namespace Uctenky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nakup = { "Rohlík", "Pomelo", "Káva", "Houska", "Mandrinka", "Olej", "Sýr", "Šunka", "Mléko", "Pivo", "Rýže", "Těstoviny", "Džus", "Papír", "Kuřecí maso", "Vepřové maso", "Cibule", "Paprika", "Salát", "Kečup", "Rajče", "Tvaroh" };

            int[] ceny = { 5, 10, 20, 5, 15, 20, 30, 30, 25, 15, 50, 50, 40, 50, 100, 120, 25, 40, 30, 30, 10, 50 };

            Random gen = new Random();
            
            int penezenka = 500;

            string[] item = new string[22];

            while (penezenka > 0)
            {
                int index = gen.Next(0, nakup.Length);

                if (penezenka < ceny[index])
                {
                    Console.WriteLine($"Chtěl/a jsi koupit: {nakup[index]} za {ceny[index]} Kč, ale nemáš dost peněz.");
                    break;
                }

                Console.WriteLine($"{nakup[index]} - {ceny[index]} Kč");
                penezenka -= ceny[index];
            }

            Console.WriteLine("Děkujeme za nákup, přejeme pěkný den.");

            if (penezenka > 0)
            {
                Console.WriteLine($"Zůstatek v peněžence: {penezenka} Kč");
            }
            else
            {
                Console.WriteLine($"Nic ti nezůstalo, jsi chůdý jak kostelní myš :)");
            }
        }
    }
}
