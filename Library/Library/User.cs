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


        public List<Book> ownBook = new List<Book>();

        public User(string name, string surname, string cf, int year, int month, int day)
        {
            DateTime dateBirth = new DateTime(year, month, day);
            dB = dateBirth;
            this.name = name;
            this.surname = surname;
            this.cf = cf;
        }

        public override string ToString()
        {
            string output = name + surname + dB;
            return output;
        }

        public string describe()
        {
            string output = name + surname + cf + dB; // manca il numero dei libri
            return output;
        }

       /* public string describeBook()
        {
            string output = describe() + //libri che ha
            return output;
        }*/
    }
}
