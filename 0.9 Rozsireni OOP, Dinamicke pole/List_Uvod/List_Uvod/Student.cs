using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Uvod
{
    internal class Student
    {
        public int ID { get; set; }

        public Student()
        {
            Random rnd = new Random();
            ID = rnd.Next(0, 10000000);
        }
    }
}
