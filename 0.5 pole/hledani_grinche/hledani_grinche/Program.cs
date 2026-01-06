namespace hledani_grinche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tuhle část kódu nesmíte měnit.
            Random rnd = new Random();
            int delkapole = rnd.Next(20, 1000);
            string[] elfivesnice = new string[delkapole];
            for (int i = 0; i < delkapole; i++)
            {
                elfivesnice[i] = "elf";
            }
            int kdegrinch = rnd.Next(1, delkapole);
            elfivesnice[kdegrinch] = "grinch";


            for (int i = 0; i < elfivesnice.Length; i++)
            {
                if (elfivesnice[i] == "grinch")
                {
                    Console.WriteLine($"Grich byl nalezen na indexu {i}");
                    break;
                }

            }
            foreach (string elf in elfivesnice)
            {
                Console.Write(elf + "");
            }

        }
    }
}
