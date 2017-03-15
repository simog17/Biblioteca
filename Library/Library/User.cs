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

        public DateTime dateBirth { get; set; }

        public List<Book> ownBook = new List<Book>();
         
        //Costruttore
        public User(string name, string surname, string cf, DateTime dateBirth)
        {
            this.name = name;
            this.surname = surname;
            this.cf = cf;
            this.dateBirth = dateBirth;
        }

        //Usato per scrivere l'utente nella ListBox
        public override string ToString() 
        {
            return surname + " " + name + Environment.NewLine;
        }

        //Usato per descrivere utente nella textBox
        public string Describe() 
        {
            return "Nome: " + name + Environment.NewLine + "Cognome: " + surname + Environment.NewLine + "Codice fiscale: " + cf + Environment.NewLine + "Data di nascita: " + dateBirth.ToShortDateString() + Environment.NewLine;
        }

        public string DescribeBook()
        {
            int count = ownBook.Count;
            if (count >= 1)
            {
                string output = name + " ha i seguenti libri: ";
                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)  //Serve solo per la visualizzazione output
                    {
                        output += ownBook[i] + Environment.NewLine;
                    }
                    else
                    {
                        output += ownBook[i] + ", ";
                    }
                }
                return this.Describe() + output;
            }
            else
            {
                return this.Describe() + name + " non ha ancora nessun libro in prestito" + Environment.NewLine;  //Cambia solo la vocale del singolare/plurale di libro/i
            }       
        }
    }
}
