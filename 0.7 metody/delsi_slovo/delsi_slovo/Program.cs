namespace delsi_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string slovo_a = "Jablko";
            string slovo_b = "klarinet";
            string delsi_slovo = Delsi_Slovo(slovo_a, slovo_b);
            Console.WriteLine(delsi_slovo);
            
        }

        static string Delsi_Slovo(string a, string b)
        {

            if (a.Length < b.Length)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
