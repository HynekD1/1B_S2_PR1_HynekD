using System;
using System.ComponentModel.Design;

namespace Cesko_Anglicky_slovnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slovnik = new Dictionary<string, string>();
            bool rezimPreklad = false;
            while (true)
            {
                

                if (rezimPreklad)
                {
                    Console.WriteLine("Překladač - Napiš slovo česky (nebo '-' pro režim učení):");
                    string hledaneSlovo = Console.ReadLine();

                    if (hledaneSlovo == "-")
                    {
                        rezimPreklad = false;
                        continue;
                    }

                    if (slovnik.ContainsKey(hledaneSlovo))
                    {
                        Console.WriteLine($"{slovnik[hledaneSlovo]}");
                    }
                    else
                    {
                        Console.WriteLine("Toto slovo ve slovníku není");
                    }

                    

                }
                else
                {
                    Console.Write("Napiš slovo česky (nebo '-' pro režim překladače): ");
                    string cesky = Console.ReadLine();

                    if (cesky == "-")
                    {
                        rezimPreklad = true;
                        continue;
                    }

                    Console.WriteLine("Napis slovo anglicky");
                    string anglicky = Console.ReadLine();

                    if (slovnik.ContainsKey(cesky))
                    {
                        if (slovnik[cesky] == anglicky)
                        {
                            Console.WriteLine("toto slovo je již nachází ve slovníku");
                        }
                        else
                        {
                            Console.WriteLine($"Upozornění: Slovo už existuje s překladem '{slovnik[cesky]}'.");
                            Console.Write("Chceš použít nový překlad? (ano/ne): ");
                            if (Console.ReadLine().ToLower() == "ano")
                            {
                                slovnik[cesky] = anglicky;

                            }
                        }
                    }
                    else
                    {
                        slovnik.Add(cesky, anglicky);
                    }
                }
                Console.WriteLine();
                

            }
        }
    }
}
