using System.Security.Cryptography;
namespace bludiste
{
    internal class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            //pevně zadané bludiště 
            string[,] bludiste =
            { {"P", "#", "#", "#", "#", "#", "#", "#"},
            {"V", "V", "V", "V", "V", "#", "X", "#"},
            {"#", "#", "V", "#", "V", "#", "V", "#"},
            {"#", "#", "#", "V", "V", "#", "V", "#"},
            {"#", "#", "V", "V", "V", "V", "V", "#"},
            {"#", "V", "V", "#", "#", "#", "V", "#"},
            {"#", "#", "V", "V", "V", "#", "V", "#"},
            {"#", "#", "#", "#", "#", "#", "#", "#"}
            };

            VypisMapy(GrafikaMapy(bludiste));

        }

        //metoda pro pohyb
        static void PohybHrace(string[,] mapa)
        {

        }

        //metoda pro grafický design
        static string[,] GrafikaMapy(string[,] mapa)
        {
            VypisMapy(mapa);
            string policko_pred = "";
            string policko = "P";//Výpis kam chce hráč jít
            Console.WriteLine("Kam chceš jít??");
            Console.WriteLine("nahoru = W\ndolu = S\ndoleva = A\ndoprava = D");
            string hrac = "";
            hrac = Console.ReadLine();
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (hrac == "W")
                    {

                        policko_pred = mapa[i - 1, j];

                    }
                    else if (hrac == "S")
                    {

                        policko_pred = mapa[i + 1, j];
                    }
                    else if (hrac == "A")
                    {

                        policko_pred = mapa[i, j - 1];
                    }
                    else if (hrac == "D")
                    {

                        policko_pred = mapa[i, j + 1];
                    }

                }
            }

            do
            {
                //cyklus pro projití mapou
                for (int i = 0; i < mapa.GetLength(0); i++)
                {
                    for (int j = 0; j < mapa.GetLength(1); j++)
                    {
                        if (mapa[i, j] == policko && policko_pred == "V")
                        {
                            if (hrac == "W")
                            {
                                mapa[i, j] = "V";
                                mapa[i - 1, j] = "P";

                            }
                            else if (hrac == "S")
                            {
                                mapa[i, j] = "V";
                                mapa[i + 1, j] = "P";
                            }
                            else if (hrac == "A")
                            {
                                mapa[i, j] = "V";
                                mapa[i, j - 1] = "P";
                            }
                            else if (hrac == "D")
                            {
                                mapa[i, j] = "V";
                                mapa[i, j + 1] = "P";
                            }
                            else
                            {
                                Console.WriteLine("Špatný vstup");
                            }
                        }
                        else
                        {
                            Console.WriteLine("TAM NEMŮŽEŠ!!!!");
                        }

                    }
                }
            } while (policko_pred != "X");


            return mapa;
        }

        static string[,] VypisMapy(string[,] mapa)
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    Console.Write(mapa[i, j] + " ");
                }
                Console.WriteLine();
            }
            return mapa;
        }
    }
}
