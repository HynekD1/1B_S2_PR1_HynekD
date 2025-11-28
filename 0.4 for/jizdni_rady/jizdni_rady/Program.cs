namespace jizdni_rady
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet_busu = 150;
            int interval = 13;

            int hodiny = 5;
            int minuty = 42;

            for (int i = 0; i < pocet_busu; i++)
            {
                if (minuty < 10)
                {
                    Console.WriteLine($"{i + 1}. bus jede v {hodiny}:0{minuty}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. bus jede v {hodiny}:{minuty}");
                }
                    
                
                minuty += interval;
                if (minuty > 59)
                {
                    minuty -= 60;
                    hodiny++;

                }
            
            }

        }
    }
}
