using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VozovyPark
{
    internal class Vozidlo
    {
        private string spz;
        private int rokVyroby;
        private double najeteKilometry;
        private bool dostupne;


        public Vozidlo(string Spz, int rokvyroby, double pocetNajetechKm)
        {
            this.SPZ = Spz;
            this.RokVyroby = rokvyroby;
            this.NajeteKilometry = pocetNajetechKm;
            this.dostupne = true;

        }

        public void VypisInfo()
        {
            Console.WriteLine($"SPZ: {this.spz} rok stárí auta: {2025 - this.rokVyroby}, pocet najetých Km: {this.najeteKilometry}, dostupnost:{this.dostupne}");
        }

        public int RokVyroby
        {
            get
            {
                return rokVyroby;
            }
            set
            {
                if (value >= 1900 && value <= 2025)
                {
                    rokVyroby = value;
                }
                else
                {
                    Console.WriteLine("Rok musí být 1900–2025");
                }
                
                
            }
        }


        public string SPZ
        {
            get
            {
                return spz;
            }
            set
            {
                if (value.Length <= 8 && value.All(char.IsLetterOrDigit))
                {
                    spz = value;
                }
                else
                {
                    Console.WriteLine("SPZ musí mít max 8 znaků a jen písmena/čísla");
                }
                    
            }
        }

        public double NajeteKilometry
        {
            get
            {
                return najeteKilometry;
            }
            set
            {
                if (value < 0)
                {
                    najeteKilometry = 0;
                }
                else
                {
                    najeteKilometry = value;
                }

            }
        }

    }
}
