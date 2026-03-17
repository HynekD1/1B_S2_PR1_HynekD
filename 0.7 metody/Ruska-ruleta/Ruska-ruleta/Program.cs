namespace Ruska_ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] availableNames = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Ivy", "Jack", "Kate", "Liam", "Mia", "Noah", "Olivia", "Peter", "Quinn", "Rachel", "Sam", "Taylor", "Uma", "Victor", "Wendy", "Xavier", "Yara", "Zane", "Eva", "Felix", "Gina", "Hank", "Isabel", "Jacob", "Karen", "Luke", "Megan", "Nathan", "Oscar", "Penelope", "Quincy", "Rebecca", "Simon", "Tina", "Uri", "Violet", "William", "Xena", "Yvonne", "Zara" };
            Random gen = new Random();
            Console.WriteLine("Zadej jméno:");
            string[] Name = new string[5];
            int[] zivot = { 1, 1, 1, 1, 1 };

            Name[0] = Console.ReadLine();
            Name[1] = availableNames[gen.Next(0, availableNames.Length)];
            Name[2] = availableNames[gen.Next(0, availableNames.Length)];
            Name[3] = availableNames[gen.Next(0, availableNames.Length)];
            Name[4] = availableNames[gen.Next(0, availableNames.Length)];


            
            Zivej_Mrtvej(Name, zivot);

            if (zivot[0] == 1)
            {
                Console.WriteLine("Vyhrál jsi");
            }
            else
            {
                Console.WriteLine("Prohrál jsi");
            }

        }


        static int[] Hra(string[] Name, int[] zivot)
        {
            Random gen = new Random();
            int hrac = 0;
            while (zivot[0] == 1 || zivot[1] == 1 && zivot[2] == 1 && zivot[3] == 1 && zivot[4] == 1 && zivot[5] == 1)
            {
                Console.Clear();
                do
                {
                    hrac = gen.Next(0, Name.Length);
                } while (zivot[hrac] == 0);

                zivot[hrac] = R8(zivot[hrac]);

                if (zivot[hrac] == 0)
                { 
                    Console.WriteLine($"Hráč {Name[hrac]} zemřel");
                }
                else
                {
                    Console.WriteLine($"Hráč {Name[hrac]} přežil");
                }

                

            }
            return zivot;
            
        }



        static void Zivej_Mrtvej(string[] Name, int[] zivot)
        {
            for (int i = 0; i < zivot.Length; i++)
            {
                if (zivot[i] == 1)
                {
                    Console.WriteLine($"{Name[i]} je živej");
                }
                else
                {
                    Console.WriteLine($"{Name[i]} je mrtvej");
                }
            }
        }

        static int R8 (int zivot)
        {
            Random gen = new Random();
            int kulkaR8 = gen.Next(0, 7);
            if (kulkaR8 == 6)
            {
                zivot = 0;
                return zivot;
            }
            else
            {
                zivot = 1;
                return zivot;
            }


            
        }
    }
}
