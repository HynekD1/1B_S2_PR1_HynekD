using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Priprava_na_test_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sFile = File.ReadAllText("MOCK_DATA.json");
            List<User> AllUsers = JsonSerializer.Deserialize<List<User>>(sFile);

            Console.WriteLine("id,first_name,last_name,email");
            foreach (User uziv in AllUsers)
            {
                Console.WriteLine($"{uziv.id},{uziv.first_name},{uziv.last_name}");
            }

            Console.WriteLine("Kteremu?");
            int indUziv = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet");
            int pocetOkolik = int.Parse(Console.ReadLine());
            foreach (User uziv in AllUsers)
            {
                if (uziv.id == indUziv)
                {
                    uziv.id += pocetOkolik;
                    break;
                }
            }

            string Json = JsonSerializer.Serialize(AllUsers);
            File.WriteAllText("Json.json", Json);
        }
    }
}
