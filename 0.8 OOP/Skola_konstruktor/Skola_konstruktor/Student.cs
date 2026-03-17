using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola_konstruktor
{
    internal class Student
    {
        public string name;
        public int age;
        public int ID;

        //Konstruktor pro každý nový objekt z třídy Student
        public Student(string jmeno, int vek)
        {
            this.name = jmeno;
            if (vek < 14)
            {
                this.age = 14;

            }else if(vek > 20)
            {
                this.age = 20;
            }
            else
            {
                this.age = vek;
            }
            Random gen = new Random();
            this.ID = gen.Next(1, 1000000);
        }

        public string Introduction()
        {
            return $"Hello my name is {this.name} and I´m {this.age} years old! My school ID is {this.ID}";
        }
    }
}
