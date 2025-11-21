namespace oddelovaci_znak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slovo = "Delta";
            char oddelovac = '/';
            string nove_slovo = "";

            for (int i = 0; i < slovo.Length; i++)
            {
                if (!(i ==  slovo.Length -1))
                {
                    nove_slovo += slovo[i] + "" + oddelovac;
                }
                else
                {
                    nove_slovo += slovo[i];
                }
                
            }
            Console.WriteLine(nove_slovo);
        }
    }
}
