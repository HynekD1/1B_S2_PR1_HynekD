using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari
{
    internal class Student
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Trida { get; set; }

        public Znamka[] Znamky;
        public int PocetZnamek { get; set; }


        public Student(int id, string jmeno, string trida)
        {
            this.ID = id;
            this.Jmeno = jmeno;
            this.Trida = trida;

            Znamky = new Znamka[20]; //max 20 znamek
            PocetZnamek = 0;
        }

        public void PridejZnamku(Znamka Znamkys)
        {
            if (PocetZnamek < Znamky.Length)
            {
                Znamky[PocetZnamek] = Znamkys;
                PocetZnamek++;
            }
        }

        public double VypoctitejPrumer()
        {
            double soucet = 0;
            if (PocetZnamek == 0)
            {
                return 0;
                
            }

            for (int i = 0; i < PocetZnamek; i++)
            {
                soucet += Znamky[i].Hodnota;
            }
            return soucet / PocetZnamek;

            
        }


    }
}
