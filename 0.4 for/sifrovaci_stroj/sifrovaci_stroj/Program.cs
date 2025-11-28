namespace sifrovaci_stroj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi zprávu");

            string zprava = Console.ReadLine();

            Console.Clear();
            string zasif_zprava = "";

            for (int i = zprava.Length-1; i >= 0 ; i--)
            {
                switch (zprava[i])
                {
                    case 'a':
                        zasif_zprava += '#';
                        break;
                    case 'o':
                        zasif_zprava += '$';
                        break;
                    case 'i':
                        zasif_zprava += '!';
                        break;

                    default:
                        zasif_zprava += zprava[i];
                        break;
                }
                
            }
            Console.WriteLine(zasif_zprava);



        }
    }
}
