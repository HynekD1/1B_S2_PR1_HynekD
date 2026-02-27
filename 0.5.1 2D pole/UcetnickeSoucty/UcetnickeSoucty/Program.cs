namespace Proc_UcetnickeSoucty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] soucty =
            {
                {50, 200, 100, 25 },
                {400, 250, 30, 42 },
                {50, 55, 10, 156 },
                {80, 158, 122, 180 }
            };
            VypisUcetnictvi(soucty);

        }

        static void VypisUcetnictvi(int[,] ucty)
        {
            for (int i = 0; i < ucty.GetLength(0); i++)
            {
                int soucetRadek = 0;
                for (int j = 0; j < ucty.GetLength(1); j++)
                {
                    soucetRadek += ucty[i, j];
                    Console.Write(ucty[i, j] + " ");
                }
                Console.Write("| " + soucetRadek);
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            int soucetVse = 0;
            for (int i = 0; i < ucty.GetLength(1); i++)
            {
                int soucetSloupec = 0;
                for (int j = 0; j < ucty.GetLength(0); j++)
                {
                    soucetSloupec += ucty[j, i];
                }
                soucetVse += soucetSloupec;
                Console.Write(soucetSloupec + " ");
            }
            Console.Write("| " + soucetVse);
        }
    }
}