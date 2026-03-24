namespace Zapouzdreni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predmet skrin = new Predmet();
            skrin.Price = 10;
            Console.WriteLine("Cena: " + skrin.Price);

            skrin.Weight = -50;
            Console.WriteLine("Tíha:" + skrin.Weight);
            skrin.Weight = 50;
            Console.WriteLine(skrin.Weight);

            skrin.Wood = 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood += 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood += 50;
            Console.WriteLine(skrin.Wood);

            skrin.Name = "skřín";
            Console.WriteLine(skrin.Name);

            Console.WriteLine(skrin.ID);
            //skrin.ID = 100; //Nefunguje (naschvál)

        }
    }
}
