using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string title { get; set; }

        public string author { get; set; }

        public string isbn { get; set; }

        private bool _booked;
        public bool booked { get { return _booked; } }

        public string genre { get; set; }

        //Costruttore
        public Book(string title, string author, string isbn, string genre)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.genre = genre;
        }

        //Usato per scrivere il titolo del libro nella listBox
        public override string ToString() 
        {
            return title;
        }

        //Usato per descrivere il libro nella textBox
        public string Describe() 
        {
            return "Titolo: " + title + "\r\n" + "Autore: " +  author + "\r\n" + "Genere: " +  genre + "\r\n";
        }

        /* Se il libro è già stato prestato allora verrà impedito il prestito
           altrimenti esso verrà dato in prestito all'utente */
        public bool ToBook(User u, TextBox t)
        {
            if (booked)
            {
                t.Text = this.Describe() + "\r\n" + "Il libro selezionato è già in prestito. ";
                return false;
            }
            else
            {
                _booked = true;
                u.ownBook.Add(this);
                t.Text = this.Describe() +"\r\n";
                t.Text += "Il prestito è avvenuto con successo\r\n";
                t.Text += u.DescribeBook();
                return true;
            }
        }
    }
}
