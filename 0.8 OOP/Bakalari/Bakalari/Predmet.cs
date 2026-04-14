using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari
{
    internal class Predmet
    {
        public int ID { get; set; }
        public string Nazev { get; set; }
        public Ucitel Ucitel { get; set; }


        public Predmet(int id, string nazev, Ucitel Ucitele)
        {
            ID = id;
            Nazev = nazev;
            Ucitel = Ucitele;
        }
    }
}
