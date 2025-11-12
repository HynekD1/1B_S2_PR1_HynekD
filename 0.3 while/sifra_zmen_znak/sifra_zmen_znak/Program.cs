namespace sifra_zmen_znak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char znak_nahrad = ' ';

            char znak_zasif = ' ';

            
            do
            {
                Console.WriteLine("Zadej mi znak, kterým budu měnit znak, který mi zadá");
                znak_nahrad = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (!(znak_nahrad >= 97 && znak_nahrad <= 122));


            do
            {
                Console.WriteLine("Zadej mi znak, který budu měnit ve slově");
                znak_zasif = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (!(znak_zasif >= 97 && znak_zasif <= 122));


            Console.WriteLine("Zadej mi slovo, které budeme šifrovat a dešifrovat");
            string slovo = Console.ReadLine();

            //Sem uložíme zašífrované slovo
            string zasif_slovo = "";

            int pocitadlo = 0;

            //cyklus, který prochází slovo po znacích
            while (slovo.Length > pocitadlo)
            {
                if (slovo[pocitadlo] == znak_zasif)
                    //pokud je znak ve slově na indexu pocitadlo roven znaku, který máme zašifrovat
                {
                    zasif_slovo += znak_nahrad; //nahraju do zašifrovaného slova znak, kterým máme šifrovaný znak nahradit
                }else
                {
                    zasif_slovo += slovo[pocitadlo];
                    //pokud se nejedné o znak, který máme šifrovat, tak ho nahraji do zašifrovaného slova 

                }
                    pocitadlo++; //po každém průchodu tělem zvyš počitadlo o 1
            }
            Console.WriteLine(zasif_slovo);


            string des_slovo = "";
            pocitadlo = 0;


            while (slovo.Length > pocitadlo)
            {
                if (zasif_slovo[pocitadlo] == znak_zasif)
                {
                    des_slovo += znak_zasif; 
                }
                else
                {
                    des_slovo += slovo[pocitadlo];
                }
                pocitadlo++; 
            }
            Console.WriteLine(des_slovo);



            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
