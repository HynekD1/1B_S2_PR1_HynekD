using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolni_system
{
    internal class Znamka
    {
        private int znamka;
        private int vaha;
        private string predmet;

        public Znamka(int z, int v, string p)
        {
            this.znamka = z;
            this.vaha = v;
            this.predmet = p;
        }

        public string VratZnamku()
        {
            return $"Známka z předmětu {this.predmet} s váhou {this.vaha} je {this.znamka}";
        }
    }
}