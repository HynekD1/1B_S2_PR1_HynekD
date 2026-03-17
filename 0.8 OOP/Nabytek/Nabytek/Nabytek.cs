using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabytek
{
    internal class Nabytek
    {
        
        public string material;
        public double vyska;
        public double hmotnost;
        public string barva;
        
        public void PredstavSe()
        {
            Console.WriteLine($"Tenhle nábytek z {this.material}, jeho výška je {this.vyska}, jeho hmotnost je {this.hmotnost} a má barvu {this.barva}");
        }

    }
}
