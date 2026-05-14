namespace Priprava_na_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> AllUsers = new List<User>();
            using (StreamReader sw = new StreamReader("MOCK_DATA.csv"))
            {
                sw.ReadLine();
                string radek = sw.ReadLine();
                while (radek != null)
                {
                    string[] Newuser = radek.Split(",");
                    User new_user = new User(int.Parse(Newuser[0]), Newuser[1], Newuser[2]);
                    AllUsers.Add(new_user);
                    radek = sw.ReadLine();

                }
            }

            foreach (User uziv in AllUsers)
            {
                Console.WriteLine($"{uziv.Id} {uziv.First_name} {uziv.Last_name}");
            }

            Console.WriteLine("KOHO?");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Na jaky cislo");
            }

            Console.WriteLine("Na kolik?");
            int klk;
            while (!int.TryParse(Console.ReadLine(), out klk))
            {
                Console.WriteLine("Napis cislo");
            }

            foreach (var uziv in AllUsers)
            {
                if (uziv.Id == id)
                {
                    uziv.Id = klk;
                    break;
                }
            }

            using (StreamWriter sw = new StreamWriter("Users.csv"))
            {
                sw.WriteLine("Id,First_Name,Last_Name");
                foreach (User uziv in AllUsers)
                {
                    sw.WriteLine($"{uziv.Id},{uziv.First_name},{uziv.Last_name}");
                }
            }
        }
    }
}
