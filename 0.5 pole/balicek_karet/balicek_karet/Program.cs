using System.Data;

namespace balicek_karet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barvy = { "káry", "piky", "krize", "listy" };
            string[] hodnoty = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] balicek = new string[52];
            for (int i = 0; i < barvy.Length; i++)
            {
                for (int j = 0; j < hodnoty.Length; j++)
                {
                    balicek[(i * 13) + j] = barvy[i] + " " + hodnoty[j];
                }



            }




            foreach (string karta in balicek)
            {
                Console.WriteLine(karta) ;
            }
        }
    }
}
