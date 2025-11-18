using System.Threading.Channels;

namespace Procviceni_zdraveni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet_pozdraveni = 0;
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Zdravím");
                pocet_pozdraveni++;
            }
            Console.WriteLine(pocet_pozdraveni);
        }
    }
}
