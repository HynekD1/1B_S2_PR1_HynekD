using System.Security.Cryptography;

namespace Slovnik
{ 
    internal class Program
    { 
        static void Main(string[] args) 
        {
            Random rnd = new Random();
            Dictionary<int, Book> knihovna = new Dictionary<int, Book>();
            for (int i = 0; i < 50; i++)
            {
                knihovna.Add(rnd.Next(100, 1000000), new Book());
            }

            while (true)
            {
                //Přidání nové knihy do knihovny
                int klic = int.Parse(Console.ReadLine());
                knihovna.Add(klic, new Book());

                //Odebrání klihy dle ISBN
                int odebrani = int.Parse(Console.ReadLine());
                if (knihovna.ContainsKey(odebrani))
                {
                    knihovna.Remove(odebrani);
                }
                

                //Výpis titulků knihy dle ISBN
                int vypis = int.Parse(Console.ReadLine());
                Console.WriteLine(knihovna[vypis].Title);

                //Výpis všech titulu knih v knihovně
                foreach (var kniha in knihovna.Values)
                {
                    Console.WriteLine(kniha.Title);
                }
                
                    
                

            }

        }
    }
}
