using System.Security.AccessControl;

namespace malovani_kruh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 0;
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n <= i; n++)
                {
                    Console.Write("#");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
