using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.skouska
{
    internal class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }

        public User(int id, string Fname, string Lname, string Email)
        {
            this.id = id;
            this.first_name = Fname;
            this.last_name = Lname;
            this.email = Email;
        }

        public User()
        {
        } 
    }
}
