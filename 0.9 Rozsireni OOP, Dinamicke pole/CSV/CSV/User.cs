using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    internal class User
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public int age { get; set; }

        public string Inform()
        {
            return $"{this.user_name}, {this.age} years old.";
        }
    }
}
