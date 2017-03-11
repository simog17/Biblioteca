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

        public override string ToString()
        {
            return title + ", " + author + ", " + " " + genre + "\r\n";
        }

        public string Describe()
        {
            return title + " " +  author + "\r\n";
        }

        /* Se il libro è già stato prestato allora verrà impedito il prestito
           altrimenti esso verrà dato in prestito all'utente */
        public bool ToBook(User u, TextBox t)
        {
            if (booked)
            {
                t.Text = this.Describe() + "\r\n" + "E' gia in prestito.";
                return false;
            }
            else
            {
                t.Text = this.Describe() +"\r\n";
                t.Text += "Utente: " + u.Describe();
                t.Text += "Il prestito è avvenuto con successo";
                _booked = true;
                u.ownBook.Add(this);
                return true;
            }
        }
    }
}
