namespace malovani_trojuhelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 35;
            //Trojuhelník tipu b
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write('#');
                    
                }
                
                Console.WriteLine();
                
            }



            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            //Trojuhelník tipu P
            
            for (int i = 0; i < radky; i++)
            {
                /*
                for (int o = radky-l; o > 0; o--)
                {
                    Console.Write('#');
                }
                */

                for (int j = 0; j < radky - i; j++)
                {
                    Console.Write('#');
                }


                Console.WriteLine();

            }



            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            //Trojuhelník tipu q

            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < radky - i; m++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            //Trojuhelník tipu d

            for (int i = 0; i < radky; i++)
            {

                for (int j = 0; j < radky - i -1; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m <= i; m++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
