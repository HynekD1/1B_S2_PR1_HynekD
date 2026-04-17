namespace Dictionary_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Určuji jaký datový typ je klíč a jaká je hodnota
            Dictionary<string, string> CeskoAngSlovnik = new Dictionary<string, string>();

            CeskoAngSlovnik.Add("Auto", "Car");

            Console.WriteLine(CeskoAngSlovnik["Auto"]);

            Dictionary<string, int> TelefonniSeznam = new Dictionary<string, int>();
            TelefonniSeznam.Add("Pepa Omáčka", 483111122);
            TelefonniSeznam.Add("Jindřich Smutný", 465245285);
            Console.WriteLine(TelefonniSeznam["Pepa Omáčka"]);

            //Iterace Dicationary
            foreach (string klic in TelefonniSeznam.Keys)
            {
                Console.WriteLine(klic + ": " + TelefonniSeznam[klic]);
            }
            foreach (int hodnota in TelefonniSeznam.Values)
            {
                Console.WriteLine(hodnota);
            }
            foreach (KeyValuePair<string, int> zaznam in TelefonniSeznam)
            {
                Console.WriteLine(zaznam.Key + ": " + zaznam.Value);
            }
        }
    }
}
