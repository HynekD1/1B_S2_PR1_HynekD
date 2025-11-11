namespace maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proměnná do které budu ukládat čísla zadané uživatelem
            int cislo = 0;

            //proměnná pro zapsání nalezeného maxima
            int max = 0;
            
            do
            {
                Console.WriteLine("Zadej mi číslo");
                cislo = Convert.ToInt32(Console.ReadLine());
                if(cislo > max)
                {
                    max = cislo;
                }

            } while (cislo > 0);

            //Cyklus se opakuje dokud je v proměnné číslo uložená hodnota vyšší než 0

            Console.WriteLine($"Nejvyšší zadané číslo je {max}");

        }
    }
}
