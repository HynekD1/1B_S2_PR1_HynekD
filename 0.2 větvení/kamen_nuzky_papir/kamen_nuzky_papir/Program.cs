using System.Globalization;

namespace kamen_nuzky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vyber si k/n/p");
            char knp = Console.ReadKey().KeyChar;
            Random generator = new Random();
            //1 = kámen, 2 = nůžky, 3 = papír
            int souper = generator.Next(1, 4);
            Console.WriteLine("");
            /*
            switch (knp)
            {
                case 'k':
                        if(souper == 2)
                        {
                        Console.WriteLine("Vyhrál jsi");
                        }
                        else if (souper == 1)
                        {
                        Console.WriteLine("Ramíza");
                        }
                        else
                        {
                        Console.WriteLine("Prohrál jsi");
                        }
                    break;

                case 'n':
                        if (souper == 1)
                    {
                        Console.WriteLine("Vyhrál jsi");
                    }
                    else if (souper == 3)
                    {
                        Console.WriteLine("Ramíza");
                    }
                    else
                    {
                        Console.WriteLine("Prohrál jsi");
                    }
                    break;
                default:
                    Console.WriteLine("spatný vstup");
                    break;
             
            }
            */

            if (knp == 'k' && souper == 2 || knp == 'n' && souper == 3 || knp == 'p' && souper == 1)
            {
                Console.WriteLine("Vyhrál jsi");
            }else if (knp == 'k' && souper == 1 || knp == 'n' && souper == 2 || knp == 'p' && souper == 3)
            {
                Console.WriteLine("Remíza");
            }else
            {
                Console.WriteLine("Prohrál jsi");
            }
        }
    }
}
