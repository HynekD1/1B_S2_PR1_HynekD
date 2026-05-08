using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_21._04_
{
    internal class Kniha
    {
        public int ID { get; set; }
        public int PocetStran { get; set; }

        Random rnd = new Random();

        public Kniha()
        {
            this.ID = rnd.Next(1, 1001);
            this.PocetStran = rnd.Next(50, 501);
        }

    }
}
