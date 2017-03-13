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
         
        //Costruttore
        public User(string name, string surname, string cf, DateTime dateBirth)
        {
            this.name = name;
            this.surname = surname;
            this.cf = cf;
            dB = dateBirth;
        }

        //Usato per scrivere l'utente nella ListBox
        public override string ToString() 
        {
            return name + " " + surname + "\r\n";
        }

        //Usato per descrivere utente nella textBox
        public string Describe() 
        {
            return "Nome: " + name + "\r\n" + "Cognome: " + surname + "\r\n" + "Codice fiscale: " + cf + "\r\n" + "Data di nascita: " + dB.ToShortDateString() + "\r\n";
        }

        public string DescribeBook()
        {
            int count = ownBook.Count;
            if (count < 2)
            {
                return Describe() + name + " ora ha " + count + " libro in prestito";  //Cambia solo la vocale del singolare/plurale di libro/i
            }
            else
            {
                return Describe() + name + " ora ha " + count + " libri in prestito";  //Cambia solo la vocale del singolare/plurale di libro/i
            }
        }
    }
}
