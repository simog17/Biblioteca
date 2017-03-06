using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string cf { get; set; }

        public DateTime dB { get; set; }
        

        public List <Book> ownBook = new List <Book> ();

        public User(string name, string surname, string cf, int year, int month, int day)
        {
            DateTime dateBirth = new DateTime(year, month, day);
            dB = dateBirth;
        }

        public override string ToString()
        {
            return name + surname + dB;
        }

        public string describe ()
        {
            return "test";
        }
    }
}
