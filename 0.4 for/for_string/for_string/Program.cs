using System.Globalization;

namespace for_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi slovo");
            string slovo = Console.ReadLine();

            //"Ahoj"
            /*
            A
            h
            o
            j
            */
            //Program, co vypíše slovo po znacích na řádek
            for (int i = 0; i < slovo.Length; i++)
                //slovo.Leangt při slově "Ahoj" je 4
                //indexy začínají 0
            {
                Console.WriteLine(slovo[i]);
            }


            //Vypiš do řádku, pouze každý druhý znak ze slova
            for (int i = 1; i < slovo.Length; i+= 2)
            {
                Console.Write(slovo[i]);
            }
            Console.WriteLine();

            //Vypsat do řádku, pouze znaky 'o' ,'O' , 'a' , 'A' ze slova
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == 'o' || slovo[i] == 'O' || slovo[i] == 'a' || slovo[i] == 'A')
                {
                    Console.Write(slovo[i]);
                }
                
            }
            Console.WriteLine();

        }
    }
}
