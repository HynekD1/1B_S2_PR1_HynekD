using System.Globalization;

namespace kdo_prijde
{
    internal class Program
    {
        //tuto metodu neupravujte
        public static void Main(string[] args)
        {
            PrijdeI("Karel");
            PrijdeI("Pepa");
            PrijdeI("Eliška");
            PrijdeI("Honza");

            Console.WriteLine(PrijdeII("Ivan"));
            Console.WriteLine(PrijdeII("Ludmila"));
            Console.WriteLine(PrijdeII("Ulrich"));

        }

        static string PrijdeII(string jmeno)
        {
            return $"Přijde také {jmeno}";

        }

        public static void PrijdeI(string jmeno)
        {
            //sem přijde váš kód
            Console.WriteLine($"Přijde taky {jmeno}");
            
        }
    }
}
