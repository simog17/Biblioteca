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

        public User(string name, string surname, string cf, DateTime dateBirth) // istanzia da form
        {
            dB = dateBirth;
            this.name = name;
            this.surname = surname;
            this.cf = cf;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + dB + "\r\n";
        }

        public string Describe()
        {
            return name + " " + surname + " " + cf + " " + dB.ToLongDateString() + "\r\n";
        }

        public string DescribeBook(User u)
        {
            return u.Describe() + "Possiede: " + ownBook.Count + " libri\r\n";
        }
    }
}
