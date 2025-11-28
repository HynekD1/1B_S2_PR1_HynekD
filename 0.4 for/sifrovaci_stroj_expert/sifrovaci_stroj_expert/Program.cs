using System.Globalization;

namespace sifrovaci_stroj_expert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej zprávu a ja ji zašifruji");
            string zprava = Console.ReadLine();
            Console.Clear();

            string zas_zprava = "";

            Random gen = new Random();
            int posun = gen.Next (1,11);
            for (int i = zprava.Length-1; i >= 0; i--)
            {
                //Vytáhnu ascii číslo znaku z zprávy
                int ascii_cislo_znak = zprava[i];
                //posunu číslo o daný generovaný posun
                ascii_cislo_znak += posun;
                char novy_znak = (char)ascii_cislo_znak;
                //přidám znak do zas_zpravy
                zas_zprava += novy_znak;
            }

            Console.WriteLine(zas_zprava);
            Console.ReadKey();
            string des_zprava = "";
            for (int i = zas_zprava.Length - 1; i >= 0; i--)
            {
                //Vytáhnu ascii číslo znaku z zprávy
                int ascii_cislo_znak = zas_zprava[i];
                //posunu číslo o daný generovaný posun
                ascii_cislo_znak -= posun;
                char novy_znak = (char) ascii_cislo_znak;
                //přidám znak do zas_zpravy
                des_zprava += novy_znak;
            }
            Console.WriteLine(des_zprava);
        }
    }
}
