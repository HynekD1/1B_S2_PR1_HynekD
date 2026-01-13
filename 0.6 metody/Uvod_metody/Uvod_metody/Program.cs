namespace Uvod_metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozdrav(); //volání metody
                       //Metoda se vykoná v rámci svého zavolání

            Pozdrav();

            string jmeno = "Honza";
            //Volání metody s jedním paramertem, zadáním jednoho argumentu
            PozdravJmeno("Kuba"); // "Kuba" jeargument pro paramert name
            PozdravJmeno(jmeno); //hodnota proměnné jmeno se pošle jako argument pro paramert name

            //Console.WriteLine(jmeno);

            int soucet = Soucet(1, 5);

            Console.WriteLine(soucet);

            //Praktické použití
            int x = BezpecneNacteni();
            int y = BezpecneNacteni();
        }

        static int BezpecneNacteni()
        {
            Console.WriteLine("Zadej mi celé číslo!");
            int num = 0;
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Zadej mi opravdu celé číslo");
            }

            return num;
        }



        //metody Součet
        //metoda má dva parametry - int 'x' a int 'y'
        //místo void se pší datový typ, který budeme z metody vracet
        static int Soucet (int x, int y)
        {
            int sum = x + y;
            return sum; //vrátí zpět do Mainu hodnotu proměnné sum
        }




        //Metoda pozdrav jmeno
        //Má 1 paramert, uvedený v závorce za jménem

        static void PozdravJmeno (string name)
        {
            //name existuje, protože to je paramert metody. Mohu ho volat jako proměnnou
            
            Console.WriteLine($"Hello {name}");
            /*
            //když změníme name nebude to mít vliv na proměnné v Mainu
            name = "Pepík";
            Console.WriteLine($"Hello {name}");
            */
        }




        //Metoda Pozdrav
        //je statická, protože existuje v támci instance dané třídy
        //je void(prázdná), protože nevrací žádnou hodnotu
        //namá žádny parametry, proto má za jménem prázdné závorky
        static void Pozdrav()
        {
            //Součást metody
            Console.WriteLine("Hello, World!");
            //Console.WriteLine($"Hello {jmeno}");  Jmeno neexistuje v kontextu metody pozdrav
        } 
    }
}
