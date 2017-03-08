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
            DateTime dateBirth = new DateTime(year, month, day); // problema: ogni volta che istanzio un utente verrà istanziato un DateTime
            dB = dateBirth;
            this.name = name;
            this.surname = surname;
            this.cf = cf;
        }

        public override string ToString()
        {
            return name + surname + dB;
        }

        public string describe()
        {
            return name + " " + surname + " " + cf + " " + dB + "\r\n";
        }

        public string describeBook(User u)
        {
            return u.describe() + "Possiede: " + ownBook.Count + " libri\r\n";
        }
    }
}
