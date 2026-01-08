namespace slova_s_velkymi_pismeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Nový rok byl zdařilí. Všichni jsme se sešli ve škole Delta a to včetně Adama, Františka i Dominika.";
            string[] slova = text.Split(" ");
            foreach (string slovo in slova)
            {
                Console.WriteLine(slovo);
            }
            Console.WriteLine();
            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i][0] >= 65 && slova[i][0] <= 90)
                {
                    Console.WriteLine(slova[i]);
                }
            }

        }
    }
}
