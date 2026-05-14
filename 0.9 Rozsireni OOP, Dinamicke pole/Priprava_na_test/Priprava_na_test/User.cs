using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprava_na_test
{
    internal class User
    {
        public int Id { get;  set; }
        public string First_name { get;  set; }
        public string Last_name { get;  set; }

        public User(int id, string Fname, string Lname)
        {
            Id = id;
            First_name = Fname;
            Last_name = Lname;
        }
    }
}
