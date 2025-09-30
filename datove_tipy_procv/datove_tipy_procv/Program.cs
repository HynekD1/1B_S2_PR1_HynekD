namespace datove_tipy_procv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pocetRohliku = 5;
            Console.WriteLine("Kup " + pocetRohliku + " rohlíků");


            int cenaZaLitr = 55;
            Console.WriteLine("Za litr nafty dnes zaplatíte " + cenaZaLitr + "Kč");


            string prvniPismeno = "A";
            Console.WriteLine("První písmeno abecedy je " + prvniPismeno + ".");


            string textZpravy = "Ahoj";
            Console.WriteLine("Přišla mi zpráva s tímto textem: " + textZpravy);


            int autaZaDen = 150;
            Console.WriteLine("Dnes naší ulicí projelo " + autaZaDen + " aut.");


            string interpunkcniZnamenko = "/";
            Console.WriteLine("K oddělení vět v souvětí používáme symbol " + interpunkcniZnamenko);


            int delkaHrany = 4;
            Console.WriteLine("Základna trojúhleníka měří " + delkaHrany + " cm.");


            string prijmeni = "Josef";
            Console.WriteLine(prijmeni + " je časté příjmení.");

            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
