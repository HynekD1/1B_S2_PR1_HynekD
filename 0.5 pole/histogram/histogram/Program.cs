namespace histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, 3, 2, 4, 7, 12, 4 };

            for (int i = 0; i < cisla.Length; i++)
            {
                for (int j = 0; j < cisla[i]; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
