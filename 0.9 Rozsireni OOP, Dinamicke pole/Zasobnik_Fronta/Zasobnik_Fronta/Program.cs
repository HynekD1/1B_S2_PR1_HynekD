namespace Zasobnik_Fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zásobník
            Stack<int> ZasobnikCisel = new Stack<int>();

            //Přidávání do zásobníku
            ZasobnikCisel.Push(10);
            ZasobnikCisel.Push(20);
            ZasobnikCisel.Push(30);
            VypisZasobnik(ZasobnikCisel);

            //Vyhazování ze zasobníku
            ZasobnikCisel.Pop(); //vyhodí první prvek v zasobníku
            VypisZasobnik(ZasobnikCisel);
            Console.WriteLine(ZasobnikCisel.Pop()); //nejen prvek vyhodí, ale i vrátí jeho hodnotu
            VypisZasobnik(ZasobnikCisel);

            //FRONTA
            Queue<string> FrontaJmen = new Queue<string>();

            //Přidání do fronty
            FrontaJmen.Enqueue("Petr");
            FrontaJmen.Enqueue("Jindra");
            FrontaJmen.Enqueue("Václav");
            FrontaJmen.Enqueue("Dagmar");
            VypisFrontu(FrontaJmen);

            //Odebírání z fronty
            FrontaJmen.Dequeue(); //vyhodí prvního ve frontě
            VypisFrontu(FrontaJmen);
            Console.WriteLine(FrontaJmen.Dequeue()); //Vyhození vrací hodnotu vyhozeného
            VypisFrontu(FrontaJmen);






        }

        static void VypisFrontu(Queue<string> fro)
        {
            foreach (string prvek in fro)
            {
                Console.Write(prvek + " ");
            }
            Console.WriteLine();
        }
        static void VypisZasobnik(Stack<int> zas)
        {
            foreach (int prvek in zas)
            {
                Console.Write(prvek + " ");
            }
            Console.WriteLine();
        }
    }
}
