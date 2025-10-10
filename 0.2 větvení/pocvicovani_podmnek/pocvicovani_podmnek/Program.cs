using System.ComponentModel.Design;

namespace pocvicovani_podmnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první číslo");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("První číslo je větší");
            }else
            {
                if (a < b)
                {
                    Console.WriteLine("První číslo je menší");
                }else
                {
                    if(a==b)
                    {
                        Console.WriteLine("Čísla si jsou rovna");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }
            }


            Console.WriteLine("Zadej číslo");
            int cislo = Convert.ToInt32(Console.ReadLine());
            if(cislo % 2 == 0)
            {
                Console.WriteLine("TOTO ČÍSLO JE SUDÉ");
            }
            else
            {
                Console.WriteLine("TOTO ČÍSLO JE LICHÉ");
            }


            Console.WriteLine("Zadej stranu a");
            int strana_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej stranu b");
            int strana_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej stranu c");
            int strana_c = Convert.ToInt32(Console.ReadLine());

            if( strana_a + strana_b >= strana_c) 
            {
                Console.WriteLine("Trojúhelník lze sestrojit");
            }
            else
            {
                if (strana_b + strana_c >= strana_a)
                {
                    Console.WriteLine("Trojúhelník lze sestrojit");
                }
                else
                {
                    if(strana_c + strana_a >= strana_b)
                    {

                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }      
            }


            Console.WriteLine("");
        }
    }
}
