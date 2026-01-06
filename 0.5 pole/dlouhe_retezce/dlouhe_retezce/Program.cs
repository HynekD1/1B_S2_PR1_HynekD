namespace dlouhe_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] retezce = new string[5];
            for (int i = 0; i < retezce.Length; i++)
            {
                Console.WriteLine($"Napiš mi {i + 1}. retezec");
                retezce[i] = Console.ReadLine();


            }
            foreach (string retezec in retezce)
            {
                if (retezec.Length > 6)
                {
                    Console.Write($"{retezec} ");

                }
            }
            
        }
    }
}
