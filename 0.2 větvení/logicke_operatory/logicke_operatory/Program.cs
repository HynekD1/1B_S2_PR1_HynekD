using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace logicke_operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dospelost = true;
            bool penize = false;
            //Logický operátor AND(a zároveň)
            //Pravý ale + C = & (AND ==&&)
            if (dospelost == true && penize == true)
            {
                Console.WriteLine("Může do baru!");
            }
            else
            {
                Console.WriteLine("Nemůže do baru!");
            }
            //Logický operátor OR (Nebo)
            //Pravý ALT + W = | (OR == ||)
            if (dospelost == true || penize == true)
            {
                Console.WriteLine("Můžeš do baru");
            } else 
            {
                Console.WriteLine("Nemůžeš do baru");
            }
            

            //Logický operátor NOT (negace)
            //! (SHIFT + §)
            if(!(dospelost == true || penize == true))
            {
                Console.WriteLine("Můžeš do baru");
            }
            else
            {
                Console.WriteLine("Nemůžeš do baru");
            }


            //Složené podmínky
            bool vstupenka = true;
            //Podmínka - do baru může vstoupit ten, kdo má bud vstupenku nebo peníze
            if ((vstupenka || penize) && dospelost)
            {
                Console.WriteLine("Můžeš do baru");
            }
            else
            {
                Console.WriteLine("Nemůžeš do baru");
            }

            

        }
    }
}
