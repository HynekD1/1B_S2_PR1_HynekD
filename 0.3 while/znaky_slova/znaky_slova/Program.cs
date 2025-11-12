using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Security.Principal;

namespace znaky_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zadej slovo");
            string slovo = Console.ReadLine();
            //Console.WriteLine(slovo[0]);  //vypíše písmeno na 0. indexu


            int pocitadlo = 0;     //pomocné počitadlo

            while(slovo.Length > pocitadlo) // Opakuje dokud počitadlo je mensí než déka slova
            {
                Console.WriteLine(slovo[pocitadlo]); // vypíše znak na indexu hodnoty proměnné počitadlo
                pocitadlo++; //Po každém průchodu cyklu zvýším počitadlo o 1

            }


            Console.WriteLine("Zadej mi znak a já ti řeknu,zda v daném slově je, či není");
            char znak = Console.ReadKey().KeyChar;

            //Cyklus, který projde slovo a zjistí, zda v něm je přítomen znak uložený v proměnné znak.
            

            pocitadlo = 0;
            bool nalezeno = false;  //Proměnná která bude zaznamenávat zda byl znak nalezen
            while (slovo.Length > pocitadlo) 
            {
                //pokud se zak ve slově na indexu pocitadlo rovná znaku
                if (slovo[pocitadlo] == znak)
                {

                    nalezeno = true;
                    break; //ukončení cyklu
                }
                pocitadlo++;
            }

            Console.WriteLine("\nByl znak nalezen :" + nalezeno);
            //Cyklus, který projde slovo a zjistí, kolikrát v něm je daný znak

            pocitadlo = 0;
            int pocet_znak = 0;
            while (slovo.Length > pocitadlo)
            {
                //pokud se zak ve slově na indexu pocitadlo rovná znaku
                if (slovo[pocitadlo] == znak)
                {
                    pocet_znak++;
                    nalezeno = true;
                    
                }
                pocitadlo++;
            }

            Console.WriteLine($"Počet znaků {znak} ve slově {slovo} je {pocet_znak}");




            Console.ForegroundColor = ConsoleColor.Black;




            


        }
    }
}
