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
            return name + " " + surname + Environment.NewLine;
        }

        //Usato per descrivere utente nella textBox
        public string Describe() 
        {
            return "Nome: " + name + Environment.NewLine + "Cognome: " + surname + Environment.NewLine + "Codice fiscale: " + cf + Environment.NewLine + "Data di nascita: " + dB.ToShortDateString() + Environment.NewLine;
        }

        int j = 0;
        public string DescribeBook()
        {
            j++;
            int count = ownBook.Count;
            if (j > 1)
            {
                string output = name + " ha i seguenti libri: ";
                for (int i = 0; i < count; i++)
                {
                    output += ownBook[i] + " ";
                }
                return Describe() + output;
            }
            if (count == 1)
            {
                return Describe() + name + " ora ha " + count + " libro in prestito" + Environment.NewLine;  //Cambia solo la vocale del singolare/plurale di libro/i
            }
            else
            {
                return Describe() + name + " ora ha " + count + " libri in prestito" + Environment.NewLine;  //Cambia solo la vocale del singolare/plurale di libro/i
            }       
        }
    }
}
