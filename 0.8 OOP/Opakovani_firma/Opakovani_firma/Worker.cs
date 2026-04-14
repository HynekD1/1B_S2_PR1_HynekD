using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_Firma
{
    internal class Worker
    {
        //private set říká, že vlastnost lze měnit pouze v třídě Worker, ale ne ve třídě Program
        public int ID { get; private set; }
        public string Workspace { get; set; }

        public int HodinovaMzda { get; set; }

        public status Status { get; set; }

        //soukromá položka pracovní doby
        private int pracovniDoba;
        //veřejná pložka pracovní doby s upraveným settrem
        public int PracovniDoba
        {
            //getter vrací hodnotu soukromé položky pracovniDoba
            get
            {
                return pracovniDoba;
            }
            set
            {
                //omezení vstupu, tak aby mohl do pracovniDoby vložit maximálně 8
                //omezení také odspoda, aby nemohl mít zápornou pracovní dobu
                if (value > 8)
                {
                    pracovniDoba = 8;
                }
                else if (value < 0)
                {
                    pracovniDoba = 0;
                }
                else
                {
                    pracovniDoba = value;
                }
            }
        }


        //konstruktor - volá se při vzniku každého objektu z třídy Worker
        public Worker(string ws)
        {
            Random rnd = new Random();
            this.ID = rnd.Next(1, 1000);
            this.Workspace = ws;
            this.PracovniDoba = 0;
            this.HodinovaMzda = rnd.Next(80, 2000);
            this.Status = status.Prace;
        }

        //metoda
        public void Introduction()
        {
            Console.WriteLine($"{this.ID} working in {this.Workspace}, {this.PracovniDoba} hours a day. {this.HodinovaMzda} – they pay me for 1 hour of work.");
        }


    }
}