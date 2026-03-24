using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakupni_seznam
{
    internal class Polozka
    {
        public string Nazev;
        public int Pocet;
        public int Cena_za_kus;
        public int Cena_celkem;

        public Polozka (string jmeno, int pocet, int cena_za_kus)
        {
            this.Nazev = jmeno;
            this.Pocet = pocet;
            this.Cena_za_kus = cena_za_kus;

            this.Cena_celkem = pocet * cena_za_kus;
        }
    }
}
