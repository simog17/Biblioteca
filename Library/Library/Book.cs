using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string title { get; set; }

        public string author { get; set; }

        public int isbn { get; set; }

        public enum genre {Comedy, Horror, Fantasy, RomanceNovel}

        public bool booked { get { return false; } }

        //Costruttore
        public Book(string title, string author, int isbn, string genre)
        {

        }

        public override string ToString()
        {
            return isbn + " " + author;
        }

        public string Describe ()
        {
            return "Descrivo libro";
        }

        public bool IsBooked(User u)
        {
            if (booked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
