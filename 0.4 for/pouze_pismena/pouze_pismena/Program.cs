using System.Threading.Channels;

namespace pouze_pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ahoj, jak se máš?";
            string jen_pismena = "";

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 65 && text[i] <= 90 || text[i] >= 97 && text[i] <= 122))
                {
                    jen_pismena += text[i];
                }
            }
            Console.WriteLine(jen_pismena);
        }
    }
}
