using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test7._4_
{
    internal class Task
    {
        private int id;
        private pozadovanaOdbornost();
        private double pocetHodin;
        private double rozpocetZakazky;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
            
        }

        public int PozadovanaOdbornost
        {
            get
            {
                return pozadovanaOdbornost;
            }
            set
            {
                
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
                this.pocetHodin = value;
            }

        }

        public double RozpocetZakazky
        {
            get 
            {
                return rozpocetZakazky;
            }
            set
            {
                this.rozpocetZakazky = value;
            }

        }

        static public string Tasks(int id, KategoriePrace KategoriePrace, double PocetHodin, double RozpocetZakazky)
        {
            
        }



    }
}
