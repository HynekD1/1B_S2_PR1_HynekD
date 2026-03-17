using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_OOP
{
    internal class Auto
    {
        //Veřejné položky (vlastnosti)
        public string barva;
        public double hmotnost;
        public string spz;
        public string znacka;

        //Soukromé položky (vlastnosti)
        private int pocetKol;

        //Metody pro práci s soukromou položku
        public int GetKola()
        {
            return this.pocetKol;
        }

        public void SetKola(int pocet)
        {
            this.pocetKol = pocet;
            if (this.pocetKol > 4)
            {
                this.pocetKol = 4;
            }
            if (this.pocetKol < 0)
            {
                this.pocetKol = 0;
            }
        }

        //Veřejné metody
        public void Zatrub()
        {
            Console.WriteLine("TůTů!");
        }

        public void PredstavSe()
        {
            //this je ukazovatl, který vždy ukazuje na hodnoty konkrétního objektu, který tuto metodu volá
            Console.WriteLine($"Tohle auto má barvu {this.barva}, váží {this.hmotnost} a má spz {this.spz}");
        }
    }
}