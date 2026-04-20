namespace priprava
{
    public enum status
    {
        Doma,
        Škola,
        Práce
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] znacky = {"Ford", "Porshe", "Felda", "Lambo", "Corvette"};
            
            Random rnd = new Random();
            string StatusSTR = status.Práce.ToString();
            Console.WriteLine(StatusSTR);

            Auto[] Autíčko = new Auto[2];

            Autíčko[0] = new Auto(0, "Ford");
            Autíčko[1] = new Auto(1,"Porshe");

            Autíčko[1].Introduce();

            Auto[] Auta = new Auto[5];
            for (int i = 0; i < Auta.Length; i++)
            {
                Auta[i] = new Auto(i, znacky[i]);
            }
            for (int i = 0; i < Auta.Length; i++)
            {
                Auta[i].Introduce();
            }

            if ("Práce" == status.Práce.ToString())
            {
                Console.WriteLine("Jde to");
            }
        }
    }
}
