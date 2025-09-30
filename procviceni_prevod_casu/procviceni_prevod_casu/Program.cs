namespace procviceni_prevod_casu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Zadej mi čas v sekundách");
            int zadane_sekundy = Convert.ToInt32(Console.ReadLine());
            int minuty = (zadane_sekundy - (zadane_sekundy % 60)) / 60;
            //Console.WriteLine(minuty);
            int sekundy = zadane_sekundy % 60;
            //Console.WriteLine(sekundy);
            int hodiny = (minuty - (minuty % 60)) / 60;
            minuty = minuty % 60;
            Console.WriteLine($"Výsledek je: {hodiny} hodin, {minuty} minut a {sekundy} sekund");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}
