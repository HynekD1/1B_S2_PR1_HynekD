using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari
{
    internal class Znamka
    {
        public Predmet Predmet { get; set; }
        public int Hodnota { get; set; }
        public DateTime Datum { get; set; }



        public Znamka(Predmet predmet, int hodnota, DateTime datum)
        {
            Predmet = predmet;
            Hodnota = Math.Clamp(hodnota, 1, 5);
            Datum = datum;
        }

    }
}
