using System.Text.Json;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření objektu z třídy App a uložení ho jako JSON
            App app1 = new App();
            app1.id = 300;
            app1.name = "SupApp";
            app1.version = "0.0.1";
            app1.cost = 1000;

            //Abych uložil něco jako JSON, tak to musí převést na Json string
            string jsonString = JsonSerializer.Serialize(app1); //serializace je převedení objektu na string
            File.WriteAllText("app.json", jsonString); //uložím string do souboru user.json

            //Načtení jednoho objektu ze souboru
            jsonString = File.ReadAllText("app.json");
            //Deserializuji z stringu na objekt
            //POZOR! v <> musí být datový typ objektu
            App newApp = JsonSerializer.Deserialize<App>(jsonString);
            Console.WriteLine(newApp.name + " " + newApp.version);

            //načíst data z mock_data.json do listu objektu App

            //Postupně krok po kroku načtení
            string mockData = File.ReadAllText("mock_data.json");
            List<App> listapp = JsonSerializer.Deserialize<List<App>>(mockData);
            /* Na jednom řádku
            List<App> listapp = JsonSerializer.Deserialize<List<App>>(File.ReadAllText("mock_data.json"));
            */


            for (int i = 0; i < listapp.Count; i++)
            {
                if (listapp[i].cost > 990000)
                {
                    listapp[i].version = "1.0.0";
                }
            }

            foreach (App app in listapp)
            {
                if (app.cost > 990000)
                {
                    Console.WriteLine(app.name + " " + app.cost + " " + app.version);
                }
            }

            //Uložit data do jsonu
            string jsonString2 = JsonSerializer.Serialize(listapp);
            File.WriteAllText("mock_data.json", jsonString2);

            /*Zkracení uložení na jeden řádek
             * File.WriteAllText("mock_data.json", JsonSerializer.Serialize(listapp));
            */
        }
    }
}
