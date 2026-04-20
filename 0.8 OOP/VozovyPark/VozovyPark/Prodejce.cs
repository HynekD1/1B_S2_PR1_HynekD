using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozovyPark
{
    internal class Prodejce
    {
        public string Jmeno { get; set; }
        public List<int> indexyAut;

        public Prodejce(string jmeno)
        {
            Jmeno = jmeno;
            indexyAut = new List<int>();
        }

        public void PridejAuto(int index)
        {
            indexyAut.Add(index);
        }

        public void VypisAuta(Vozidlo[] auta)
        {
            foreach (int auto in indexyAut)
            {
                auta[auto].VypisInfo();
            }
        }
    }
}
