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

        public int isbn { get; set; }

        private bool _booked;
        public bool booked { get { return _booked; } }

        public enum genres {Comedy, Horror, Fantasy, RomanceNovel}

        public genres genre { get; set; } //proprietà di type genres

        //Costruttore
        public Book(string title, string author, int isbn, string genre)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            switch (genre.ToLower())  // Assegnazione genere libro + normalizzazione dato
            {
                case "comedy":
                    this.genre = genres.Comedy;
                    break;
                case "horror":
                    this.genre = genres.Horror;
                    break;
                case "fantasy":
                    this.genre = genres.Fantasy;
                    break;
                case "romancenovel":
                    this.genre = genres.RomanceNovel;
                    break;
            }
        }

        public override string ToString()
        {
            return isbn + " " + author + "\r\n";
        }

        public string Describe()
        {
            return title + " " + author + " " + genre + "\r\n";
        }

        // Se il libro è già stato prestato allora verrà impedito il prestito
        // altrimenti esso verrà dato in prestito all'utente 
        public bool ToBook(User u)
        {
            if (booked)
            {
                return false;
            }
            else
            {
                _booked = true;
                return true;
            }
        }
    }
}
