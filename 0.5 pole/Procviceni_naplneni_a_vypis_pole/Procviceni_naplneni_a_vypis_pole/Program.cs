using System.Xml.Schema;

namespace Procviceni_naplneni_a_vypis_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] smery = new string[4];
            smery[0] = "sever";
            smery[1] = "jih";
            smery[2] = "východ";
            smery[3] = "západ";

            foreach (string smer in smery)
            {
                Console.WriteLine($"Můžeš jít na {smer}");
                
            }
        }
    }
}
