using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_21._04_
{
    internal class Vypujcka
    {
        public Kniha[] Knihy { get; set; }
        public int CelkemStran { get; set; }
        private int cena;



        public int Cena
        {
            get
            {
                return cena;
            }
            set
            {
                if (value < 0)
                {
                    cena = 0;
                }
                else
                {
                    cena = value;
                }
            }
            
        }


        public Vypujcka(Kniha[] knihy, int cena)
        {
            this.Knihy = knihy;
            this.Cena = cena;
            for (int i = 0; i < knihy.Length; i++)
            {
                this.CelkemStran += knihy[i].PocetStran;
            }

        }

        public void CenaZaKus()
        {
            int IDknihy;
            //Console.WriteLine("Jakou chces knihu?");
            //while (!int.TryParse(Console.ReadLine(), out IDknihy))
            //{
            //    Console.WriteLine("Zadej platne id");
            //}
            Console.WriteLine($"{this.cena / this.Knihy.Length}");
        }
    }
}
