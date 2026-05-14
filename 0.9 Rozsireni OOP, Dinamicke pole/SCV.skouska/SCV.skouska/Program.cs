using System.IO;

namespace SCV.skouska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> AllUsers = new List<User>();
            using (StreamReader sr = new StreamReader("MOCK_DATA.csv"))
            {
                sr.ReadLine();
                string radek = sr.ReadLine();
                while (radek != null)
                {
                    string[] pole_user = radek.Split(",");
                    User new_user = new User(int.Parse(pole_user[0]), pole_user[1], pole_user[2], pole_user[3]);
                    AllUsers.Add(new_user);
                    radek = sr.ReadLine();
                }
            }

            foreach (User uzivatel in AllUsers)
            {
                Console.WriteLine($"{uzivatel.Id}, {uzivatel.First_Name}, {uzivatel.Last_Name}, {uzivatel.Email}");
            }

            Console.WriteLine("Kteremu?");
            int indUziv = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet");
            int pocetOkolik = int.Parse(Console.ReadLine());


            foreach (var uziv in AllUsers)
            {
                if (uziv.Id == indUziv)
                {
                    uziv.Id += pocetOkolik;
                    break;
                }
                
            }
             
            

            using (StreamWriter sw = new StreamWriter("Users.csv"))
            {
                sw.WriteLine("id,First_Name,Last_Name,Email");
                foreach (User uzivatel in AllUsers)
                {
                    sw.WriteLine($"{uzivatel.Id},{uzivatel.First_Name},{uzivatel.Last_Name},{uzivatel.Email}");
                }
            }



            Console.WriteLine("_________________________________________________________________________________");









            

            

        }
    }
}
