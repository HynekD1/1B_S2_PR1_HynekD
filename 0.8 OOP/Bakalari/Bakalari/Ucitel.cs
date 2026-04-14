using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari
{
    internal class Ucitel
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public Predmet[] Predmety;

        public Ucitel(int id, string jmeno)
        {
            this.ID = id;
            this.Jmeno = jmeno;
            this.Predmety = new Predmet[3]; //3 Přeměty
        }
    }
}
