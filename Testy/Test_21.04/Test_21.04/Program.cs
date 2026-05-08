using System.Text.RegularExpressions;

namespace Test_21._04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Vypujcka[] vypujceni = new Vypujcka[10];
            Kniha[] knihy = new Kniha[rnd.Next(1, 21)];
            for (int i = 0; i < vypujceni.Length; i++)
            {

                vypujceni = new Vypujcka(, rnd.Next(1, 1000));
                ;
            }

            int min = 0;
            int max = 99999;

            for (int i = 0; i < vypujceni.Length; i++)
            {
                if (vypujceni[i].Cena > min)
                {
                    min = vypujceni[i].Cena;
                }else if (vypujceni[i].Cena < max)
                {
                    max = vypujceni[i].Cena;
                }
            }

            Console.WriteLine($"Nejdražší knina stojí:{min}");
            Console.WriteLine($"Nejlevnější knina stojí:{max}");
        }
    }
}
