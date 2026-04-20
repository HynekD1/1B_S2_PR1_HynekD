using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priprava
{
    internal class Auto
    {
        public int ID { get; set; }
        private string znacka;

        public string Znacka
        {
            get
            {
                return znacka;
            }
            set
            {
                this.znacka = value;
            }
        }

        public Auto(int ID, string znacka)
        {
            this.ID = ID;
            this.Znacka = znacka;
        }

        public void Introduce()
        {
            Console.WriteLine($"Moje id: {this.ID} a jsem značky:{this.znacka}");
        }
    }
}
