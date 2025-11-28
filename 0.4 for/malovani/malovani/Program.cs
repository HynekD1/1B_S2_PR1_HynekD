namespace malovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)  //počet rádků
            {
                for (int j = 0; j < 5; j++) //počet sloupců
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();//Zalomí řádek
            }


            for (int i = 0; i < 5; i++)  //počet rádků
            {
                for (int m = 0; m < 5; m++)
                {
                    Console.Write("#");


                }

                for (int l = 0; l < 5; l++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();//Zaloví žádak
            }




        }
    }
}
