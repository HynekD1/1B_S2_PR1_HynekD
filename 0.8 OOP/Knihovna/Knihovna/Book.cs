using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    internal class Book
    {
        public string Title;
        public long IBSN;
        public string Genre;
        public bool Available;

        public Book(string title, long ibsn, string genre)
        {
            Title = title;
            IBSN = ibsn;
            Genre = genre;
            Available = true;
        }

        public string IdentifySelf()
        {
            return $"Kniha {Title} s IBSN: {IBSN} je {Genre}. Dostupnost: {Available}";
        }




    }
}
