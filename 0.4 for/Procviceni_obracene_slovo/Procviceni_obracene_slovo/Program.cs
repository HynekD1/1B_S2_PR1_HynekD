namespace Procviceni_obracene_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "pihovatý";
            string obraceny_text = "";

            //řádek níže je jediný, který budete měnit
            for (int i = text.Length -1; i >= 0; i--)
            {
                obraceny_text += text[i];
                
            }
            Console.WriteLine(obraceny_text);
        }
    }
}
