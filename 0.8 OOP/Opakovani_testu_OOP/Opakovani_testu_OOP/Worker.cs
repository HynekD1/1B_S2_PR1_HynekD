using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_testu_OOP
{
    internal class Worker
    {
        public int ID { get; set; }
        public double HodinovaSazba { get; set; }
        public KategoriePrace Odbornost { get; set; }

        public Worker()
        {
            Random rnd = new Random();
            this.ID = rnd.Next(1000, 10000);
            this.HodinovaSazba = rnd.Next(300, 1500);
            this.Odbornost = (KategoriePrace)rnd.Next(0, 4);
        }

    }
}
