namespace Nabytek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nabytek Zidle = new Nabytek
            {
                material = "dřevo",
                vyska = 5,
                hmotnost = 10,
                barva = "žlutá"
            };
            

            Nabytek Stul = new Nabytek();
            Stul.material = "plast";
            Stul.vyska = 7;
            Stul.hmotnost = 20;
            Stul.barva = "fialová";
            

            Zidle.PredstavSe();
            Stul.PredstavSe();
            
        }
    }
}
