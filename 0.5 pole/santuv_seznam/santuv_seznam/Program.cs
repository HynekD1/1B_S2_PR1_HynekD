namespace santuv_seznam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] seznamjmen = { "Alice", "Alfonz", "Gretruda", "Cecil", "Donald", "Ulrich", "Bedřich", "Kuba", "Oldřich", "Sára", "Edward", "Louda", "Lída", "František", "Xaver", "Ptrik", "Otto", "Ivan", "Robert", "Ester", "Vavřich", "Nathaniel", "Marek", "Linda", "Karel", "Adalbert", "Josef", "Peter", "Tomáš", "Zachariáš", "Hanz", "Janek", "Jindra", "Nikol" };
            string[] darky = { "Kolo", "Bumernag", "Pes", "Kůň", "Hopík", "Lopata", "Koště", "Auto" };

            for (int i = 0; i < seznamjmen.Length; i++)
            {
                //string jmeno = seznamjmen[i];
                if (seznamjmen[i][0] <= 67 && seznamjmen[i][0] >= 65 )
                {
                    Console.WriteLine($"{seznamjmen[i]} dostal {darky[0]}");
                }
                else if (seznamjmen[i][0] <= 71 && seznamjmen[i][0] >= 68)
                {
                    Console.WriteLine($"{seznamjmen[i]} dostal {darky[1]}");
                }
                else if (seznamjmen[i][0] <= 75 && seznamjmen[i][0] >= 71)
                {
                    Console.WriteLine($"{seznamjmen[i]} dostal {darky[2]}");
                }
            }

        }
    }
}
