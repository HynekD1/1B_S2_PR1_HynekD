using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Tabulka_coko
{
    internal class Tabulka
    {
        //Značka, Hmotnost (0-100g), Druh (mléčná, hořká bílá)
        public string Znacka { get; set; }
        private double hmotnost;
        private string druh;


        public double Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    hmotnost = value;
                }

            }
        }

        public string Druh
        {
            get
            {
                return druh;
            }
            set
            {
                if (value == "mléčná" || value == "mlecna" || value == "MLECNA" || value == "MLÉČNÁ" || value == "Mléčná")
                {
                    druh = "Mléčná";
                }else if (value == "hořká" || value == "horka" || value == "HORKA" || value == "HOŘKÁ" || value == "Hořká")
                {
                    druh = "HOřká";
                }else if (value == "bílá" || value == "bila" || value == "BILA" || value == "BÍLÁ" || value == "Bílá")
                {
                    druh = "Bílá";
                }
            }
        }

        public double OdLom()
        {
            if (Hmotnost > 10)
            {
                Hmotnost /= 2;
                return Hmotnost;
            }
            else
            {
                double zbytek = Hmotnost;
                Hmotnost = 0;
                return zbytek;
            }

        }

    }
}
