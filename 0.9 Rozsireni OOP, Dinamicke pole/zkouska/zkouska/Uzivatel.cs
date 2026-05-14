using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zkouska
{
    internal class Uzivatel
    {
        public string Jmeno { get; private set; }
        public int Vek { get; private set; }
        public DateTime Registrovan { get; private set; }
        public Uzivatel(string jmeno, int vek, DateTime regisrovan)
        {
            Jmeno = jmeno;
            Vek = vek;
            Registrovan = regisrovan;
        }

        public override string ToString()
        {
            return Jmeno;
        }
    }
}
