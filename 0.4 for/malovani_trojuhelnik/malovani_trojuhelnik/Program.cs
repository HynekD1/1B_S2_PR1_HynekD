namespace malovani_trojuhelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 25;
            
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write('#');
                    
                }
                
                Console.WriteLine();
                
            }
        }
    }
}
