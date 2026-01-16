using System.Threading.Channels;

namespace Pocet_celych_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.5, 5, 2.5, 10.9, 3, 5, 12, 5.1, 13, 8 };
            double[] cislaA = { 5, 1.5, 6, 5.1, 3, 2.6, 5, };

            Console.WriteLine($"V poli cisla je celkově {CelaCisla(cisla)} celých čísel");
            Console.WriteLine($"V poli cisla je celkově {CelaCisla(cislaA)} celých čísel");


            //Vyvolání metody
            Console.WriteLine(CelaCisla(cisla)); //Když metoda vrací hodnotu
            int pocetC = CelaCisla(cisla); //Když metoda vrací hodnotu
            CelaCisla(cisla); //Když matoda NEvrací hodnotu

            int[] cela_cisla = PoleCelychCisel(cisla);
            int[] cele_cislaA = PoleCelychCisel(cislaA);
            VypisPole(cela_cisla);
            VypisPole(cele_cislaA);
        }


        static void VypisPole(int[] array)
        {
            foreach (int cislo in array)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
        }


        static int[] PoleCelychCisel(double[] pole)
        {
            int[] pole_celych = new int[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 1 == 0)
                {
                    Array.Resize(ref pole_celych, pole_celych.Length + 1);
                    pole_celych[pole_celych.Length - 1] = (int) pole[i];
                }
            }
            return pole_celych;

        }

        

        static int CelaCisla (double[] numbers)
        {
            int pocet_cel = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    pocet_cel++;
                }
            }
            return pocet_cel;
        }

        
         
    }
}
