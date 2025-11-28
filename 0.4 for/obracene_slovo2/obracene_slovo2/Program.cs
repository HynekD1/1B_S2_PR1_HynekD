namespace obracene_slovo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ahoj, jak se máš?";
            string text2 = "";

            //For cyklus přepis textu do textu2 po znacích
            for (int i = 0; i < text.Length; i++)
            {
                text2 += text[i];
                Console.WriteLine(text2);
            }


            string obraceny_text = "";

            //For cyklus pro přepis textu do obraceny_text po znaku, ale POZPADKU
            for (int i = text.Length-1; i >= 0; i--)
            {
                obraceny_text += text[i];
                Console.WriteLine(obraceny_text);
            }
        }
    }
}
