using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test7._4_
{
    internal class Worker
    {
        Random gen = new Random();

        private int id;
        private double hodinovaSazba { get; set; }
        private string KategoriePrace;
        
        public Worker()
        {
            this.id = gen.Next(1000, 10000);

        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                
            }
        }
        public double HodinovaSazba
        {
            get
            {
                return hodinovaSazba;
            }
            set
            {
                this.hodinovaSazba = gen.Next(300, 1501);
            }
        }



    }
}
