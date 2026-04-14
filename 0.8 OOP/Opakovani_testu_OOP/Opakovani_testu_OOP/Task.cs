using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_testu_OOP
{
    internal class Task
    {
        public int ID { get; set; }
        public KategoriePrace PozadovanaOdbornost { get; set; }
        private double pocetHodin;
        private double rozpocetZakazky;

        public Task(int id, KategoriePrace pozadovanaodbornost, double pocetH, double rozpocetZ)
        {
            this.ID = id;
            this.PozadovanaOdbornost = pozadovanaodbornost;
            this.PocetHodin = pocetH;
            this.RozpocetZakazky = rozpocetZ;
        }
        public double RozpocetZakazky
        {
            get
            {
                return rozpocetZakazky;
            }
            set
            {
                if (value < 0)
                {
                    this.rozpocetZakazky = 0;
                }
                else
                {
                    this.rozpocetZakazky = value;
                }
            }
        }

        public double PocetHodin
        {
            get
            {
                return pocetHodin;
            }
            set
            {
                if (value < 1)
                {
                    this.pocetHodin = 1;
                }
                else
                {
                    this.pocetHodin = value;
                }

            }
        }
    }
}
