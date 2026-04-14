using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_Vozovi_park
{
    internal class Prodejce
    {
        private int[] indexyAut;
        public string Jmeno { get; set; }
        public int[] IndexyAut
        {
            get
            {
                return indexyAut;
            }
            set
            {
                indexyAut = value;
            }

        }

        public Prodejce(string jmeno)
        {
            this.Jmeno = jmeno;
            this.IndexyAut = new int[0];
        }

        public void PridejAuto(int index)
        {
            Array.Resize(ref indexyAut, indexyAut.Length + 1);
            IndexyAut[IndexyAut.Length - 1] = index;
        }
        public void VypisAuta(Vozidlo[] auta)
        {
            for (int i = 0; i < auta.Length; i++)
            {
                for (int j = 0; j < IndexyAut.Length; j++)
                {
                    //Do budoucna kontrola dostupnosti daného auta
                    if (IndexyAut[j] == i)
                    {
                        auta[i].VypisInfo();
                    }
                }
            }
        }
    }
}