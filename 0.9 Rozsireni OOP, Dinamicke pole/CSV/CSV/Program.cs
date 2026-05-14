namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User();
            usr1.id = 1;
            usr1.user_name = "karel";
            usr1.age = 25;

            //Zápis ve formátu csv
            //zapisujeme do složky s programem do souboru data.csv
            using (StreamWriter sw = new StreamWriter("data.csv"))
            {
                sw.WriteLine($"id,user_name,age");
                sw.WriteLine($"{usr1.id},{usr1.user_name},{usr1.age}");
            }
            //až budete hledat složku s programem
            //projektová složka -> bin -> Debug -> net 9.0 (tam to najdete)
            //Projektova složka jde otevřít rychleji kliknutí na název třídy ve VS (Open Containg folder)

            //Vytvoření listu s dvěma položkami u položek rovnou hodnoty na atributy
            List<User> new_user_list = new List<User>
            {
                new User{ id = 2, user_name = "Pepa", age = 40},
                new User{ id = 3, user_name = "Kamil", age = 55}
            };
            //Chci dopsat tyto další uživatele do data.csv na nové řádky
            //true znamená připisování a ne přepisování
            using (StreamWriter sw = new StreamWriter("data.csv", true))
            {
                //Abych zapsal obsah listu musím ho procházet a každý prvek z listu zapsat na nový řádek
                for (int i = 0; i < new_user_list.Count; i++)
                {
                    sw.WriteLine($"{new_user_list[i].id},{new_user_list[i].user_name},{new_user_list[i].age}");
                }
            }

            //číst data z mock_data.csv, kde je 1000 záznamů
            //budu chtít tyto záznamy načíst do listu se kterým pak program může pracovat

            List<User> mockUsers = new List<User>();

            //čtení z csv
            using (StreamReader sr = new StreamReader("mock_data.csv"))
            {
                sr.ReadLine(); //přečtení čtečkou hlavičky, aby se načítala rovnou data
                //čtení musí být cyklus, kdy se čte dokud čtečka nevrací null (prázdná hodnota)
                string radek = sr.ReadLine(); //načtu první řádek

                while (radek != null) //kontroluju že hodnota není null
                {
                    //Console.WriteLine(radek); výpis řádku
                    string[] pole_user = radek.Split(","); //split rozdělí string na pole, dle oddělovače (",")
                                                           //v poli je nyní na 0. indexu = id; 1. user_name; 2. age

                    User new_user = new User();

                    //nacpání hodnot z pole do nového objektu
                    new_user.id = int.Parse(pole_user[0]);
                    new_user.user_name = pole_user[1];
                    new_user.age = int.Parse(pole_user[2]);

                    //Nový objekt je potřeba přidat do listu
                    mockUsers.Add(new_user);

                    radek = sr.ReadLine(); //načtení dalšího řádku
                }
            }

            //Postaršení všech uživatelů o 5 let
            for (int i = 0; i < mockUsers.Count; i++)
            {
                mockUsers[i].age += 5;
            }

            //Výpis uživatelů nad 95 let
            foreach (User user in mockUsers)
            {
                if (user.age >= 95)
                {
                    Console.WriteLine(user.Inform());
                }
            }

            //Uložíme data zpět do csv
            using (StreamWriter sw = new StreamWriter("mock_data.csv"))
            {
                sw.WriteLine("id,user_name,age");
                foreach (User user in mockUsers)
                {
                    sw.WriteLine($"{user.id},{user.user_name},{user.age}");
                }
            }
        }
    }
}
