using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_Vozovi_park
{
    internal class Vozidlo
    {
        private string spz;
        private int rokVyroby;
        private double najeteKm;
        public bool Dostupnost { get; set; }


        public string Spz
        {
            get
            {
                return spz;
            }
            set
            {
                int counter = 0;
                if (value.Length <= 8)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if ((value[i] >= 48 && value[i] <= 57) || (value[i] >= 65 && value[i] <= 90))
                        {
                            counter++;
                        }
                    }
                    if (counter == value.Length)
                    {
                        spz = value;
                    }
                }
            }
        }

        public double NajeteKm
        {
            get
            {
                return najeteKm;
            }
            set
            {
                if (value >= 0)
                {
                    najeteKm = value;
                }
            }
        }

        public int RokVyroby
        {
            get
            {
                return rokVyroby;
            }
            set
            {
                if (value >= 1900 && value <= 2026)
                {
                    rokVyroby = value;
                }
            }
        }

        public Vozidlo(string spz, int rok, double km)
        {
            this.Spz = spz;
            this.NajeteKm = km;
            this.RokVyroby = rok;
            this.Dostupnost = true;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Vozidlo má SPZ: {this.Spz}, má najeto {this.NajeteKm} a je mu {2026 - this.rokVyroby} let.");
        }
    }
}
