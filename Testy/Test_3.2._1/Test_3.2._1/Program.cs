namespace Test_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Jan Novák", "Petr Svoboda", "Tomáš Novotný", "Lukáš Dvořák", "Martin Černý", "Jakub Procházka", "Ondřej Kučera", "Filip Veselý", "Karel Horák", "Adam Král", "Anna Zeman", "Tereza Pokorná", "Eliška Kolářová", "Kateřina Urbanová", "Jana Benešová", "Lucie Říhová", "Veronika Fialová", "Marie Sedláčková", "Karolína Krejčí", "Nikola Hrušková", "Jan Horák", "Petr Kučera", "Tomáš Fiala", "Lukáš Hruška", "Martin Beneš", "Jakub Novotný", "Ondřej Veselý", "Filip Sedláček", "Karel Dvořák", "Adam Pokorný", "Anna Králová", "Tereza Říhová", "Eliška Zemanová", "Kateřina Kolářová", "Jana Kučerová", "Lucie Urbanová", "Veronika Svobodová", "Marie Procházková", "Karolína Černá", "Nikola Krejčí", "Jan Beneš", "Petr Procházka", "Tomáš Kolář", "Lukáš Král", "Martin Veselý", "Jakub Horák", "Ondřej Fiala", "Filip Hruška", "Karel Pokorný", "Adam Dvořák" };

            int[] money = new int[] { 3412, 6578, 2934, 7489, 1023, 6587, 9485, 2345, 7634, 1098, 8756, 3467, 5903, 7890, 1456, 6234, 4908, 8672, 3902, 1085, 5943, 3827, 6708, 9345, 2108, 5734, 8094, 6723, 5902, 9834, 3457, 2839, 8703, 4021, 7894, 1502, 6721, 8903, 2145, 9034, 6784, 1209, 7345, 2934, 6724, 8567, 4902, 7834, 2503, 6347 };

            Console.WriteLine(money[20]);
            money = Ucet(-200, 20, money);
            Console.WriteLine(money[20]);

            Stav (20, money, names);

            


        }

        static int[] Ucet (int cislo, int index, int[] zustatek)
        {

            if (index >= 0)
            {
                zustatek[index] = zustatek[index] + cislo;
                return zustatek;
            }
            else
            {
                Console.WriteLine("Nelze provést");
                return zustatek;
            }

        }

        static void Stav (int index, int[] money, string[] names)
        {
            if (index > 0)
            {
                Console.WriteLine(names[index], money[index]);
            }
            else if (index < 0)
            {
                foreach (string jmena in names)
                {
                    Console.Write(jmena + "  ");
                }

                foreach (int penize in money)
                {
                    Console.Write(penize + "  ");
                }
            }

        }
    }

}
