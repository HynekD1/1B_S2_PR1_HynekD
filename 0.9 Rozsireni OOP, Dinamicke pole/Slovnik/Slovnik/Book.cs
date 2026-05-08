using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Slovnik
{
    internal class Book
    {

        public string Title { get; set; }
        string[] knihy = new string[]
        {
            "Stín věže",
            "Tajemství prastarého lesa",
            "Cesta bez návratu",
            "Kronika zapomenutých časů",
            "Oheň a popel",
            "Hvězda severu",
            "Píseň bouře",
            "Město v mlze",
            "Legenda o třech králích",
            "Brána do ticha",
            "Poslední poutník",
            "Krvavý měsíc",
            "Ztracené dědictví",
            "Temná voda",
            "Kameny osudu",
            "Volání prázdna",
            "Nad propastí",
            "Dům na kopci",
            "Zahrada stínů",
            "Návrat vlků",
            "Ostrov zapomnění",
            "Hlas minulosti",
            "Kronika větru",
            "Zrození světla",
            "Pád říše",
            "Tichý svědek",
            "Most mezi světy",
            "Ztracená koruna",
            "Hodina pravdy",
            "Děti noci",
            "Písek času",
            "Ocelové nebe",
            "Zimní královna",
            "Hra osudu",
            "Temný hrad",
            "Krvavé pobřeží",
            "Naděje v popelu",
            "Zpěv sirén",
            "Vládce prachu",
            "Tajemná komnata",
            "Příběh dvou světů",
            "Zlomený meč",
            "Kruh věčnosti",
            "Poutníkova cesta",
            "Hlubiny ticha",
            "Ztracený princ",
            "Oko bouře",
            "Třetí brána",
            "Kniha proroctví",
            "Zrození hrdiny",
            "Temnota přichází",
            "Stříbrná věž",
            "Pád hvězdy",
            "Zahrada světel",
            "Kronika ohně",
            "Město duchů",
            "Přízraky minulosti",
            "Ocelová koruna",
            "Hlas bouře",
            "Ztracené město",
            "Pouto krve",
            "Kameny vědění",
            "Tajemství podzemí",
            "Návrat draka",
            "Píseň noci",
            "Zrození temnoty",
            "Hrdina bez jména",
            "Kniha stínů",
            "Ostrov světla",
            "Kronika padlých",
            "Třetí cesta",
            "Zlomená přísaha",
            "Hvězdný poutník",
            "Pád titánů",
            "Tichá bouře",
            "Zahrada času",
            "Ocelový trůn",
            "Legenda o stínu",
            "Kronika severu",
            "Temný pramen",
            "Písek hvězd",
            "Oko noci",
            "Ztracený svět",
            "Hlas ticha",
            "Kniha života",
            "Poutník mezi světy",
            "Tajemství věčnosti",
            "Zrození bouře",
            "Kameny moci",
            "Ocelová cesta",
            "Pád bohů",
            "Legenda o světle",
            "Kronika jihu",
            "Temný les",
            "Píseň větru",
            "Ostrov stínů",
            "Zahrada ohně",
            "Hvězdná brána",
            "Kniha času"
        };

        Random rnd = new Random();
        public Book()
        {
            this.Title = knihy[rnd.Next(0, 100)];
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Něco tu chybí!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    }
}
