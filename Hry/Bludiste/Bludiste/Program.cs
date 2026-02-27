using System.Globalization;

namespace Bludiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[,] bludiste = //Mapa bludiště
            { {"# " , "#", "#", "#" , "#", "V", "V" , "V", "V", "V"},
              {"#" , "#", "V", "V" , "V", "V", "#" , "#", "#", "X"},
              {"#" , "#", "V", "#" , "#", "#", "#" , "#", "#", "#"},
              {"#" , "#", "V", "V" , "V", "", "#" , "#", "#", "#"},
              {"#" , "#", "#", "#" , "V", "V", "#" , "#", "#", "#"},
              {"P" , "V", "#", "#" , "#", "V", "#" , "#", "#", "#"},
              {"#" , "V", "#", "#" , "#", "V", "#" , "#", "#", "#"},
              {"#" , "V", "#", "V" , "V", "V", "#" , "#", "#", "#"},
              {"#" , "V", "#", "V" , "#", "#", "#" , "#", "#", "#"},
              {"#" , "V", "V", "V" , "#", "#", "#" , "#", "#", "#"},
            };



            Pohyb(bludiste);

        }
        //Metoda na pohybování po bludišti
        static string[,] Pohyb(string[,] bludiste)
        { 
            string hrac = ""; //Kam chce hráč jít
            string policko = ""; //Pomoc na while
            do
            {
                Console.Clear();
                for (int i = 0; i < bludiste.GetLength(0); i++) //Výpis bludiště
                {
                    for (int j = 0; j < bludiste.GetLength(1); j++)
                    {
                        Console.WriteLine(bludiste[i,j]);
                    }
                }
                Console.WriteLine("nahoru = W\ndolu = S\ndoleva = A\ndoprava = D"); //Výpis kam chce hráč jít

                for (int i = 0; i < bludiste.GetLength(0); i++) //Samotný pohyb 
                {
                    for (int j = 0; j < bludiste.GetLength(1); j++)
                    {
                        if (hrac == "W")
                        {
                            bludiste[i, j] = "V";
                            bludiste[i - 1, j] = "P";

                        }
                        else if (hrac == "S")
                        {
                            bludiste[i, j] = "V";
                            bludiste[i + 1, j] = "P";
                        }
                        else if (hrac == "A")
                        {
                            bludiste[i, j] = "V";
                            bludiste[i, j - 1] = "P";
                        }
                        else if (hrac == "D")
                        {
                            bludiste[i, j] = "V";
                            bludiste[i, j + 1] = "P";
                        }
                        else
                        {
                            Console.WriteLine("Špatný vstup");
                        }
                    }
                }


            } while ();

            return bludiste;

        }
    }
}
