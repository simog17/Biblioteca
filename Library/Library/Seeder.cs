using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Seeder
    {
        private static Random rnd = new Random();

        private static string[] names = { "Simone", "Nicola", "Pietro", "Gianni", "Pippo" };
        private static string[] surnames = { "Rossi", "Verdi", "Gialli", "Galli", "Neri"};
        private static string[] cf = { "FDMZST83M03Z320Q","FDMZST83M03Z320Q","XGJKDE87C29D582A", "BFRPFC80H13L640O", "PRLRVC36T21L675Y" };

        //Crea una data pseudo random
        private static DateTime SetDB()
        {
            return new DateTime(rnd.Next(1950, 2017), rnd.Next(1, 13), rnd.Next(1, 30));
        }

        //Setta un nome a caso dall'array
        private static string SelectName()
        {
            int index = rnd.Next(0,5);
            string n = "";
            while (n == "")
            {
                if (names[index] != "")
                {
                    n = names[index];
                    names[index] = "";
                }
                else
                {
                    index = rnd.Next(5);
                }  
            }
            return n;
        }

        //Setta un cognome a caso dall'array
        private static string SelectSurname()
        {
            int index = rnd.Next(5);
            string s = "";
            while (s == "")
            {
                if (surnames[index] != "")
                {
                    s = surnames[index];
                    surnames[index] = "";
                }
                else
                {
                    index = rnd.Next(5);
                }
            }
            return s;
        }

        //Setta un codice fiscale a caso dall'array
        private static string SelectCf()
        {
            int index = rnd.Next(5);
            string c = "";
            while (c == "")
            {
                if (cf[index] != "")
                {
                    c = cf[index];
                    cf[index] = "";
                }
                else
                {
                    index = rnd.Next(5);
                }
            }
            return c;
        }

        //Genera un utente
        public static User GenerateUser()
        {
            return new User(SelectName(), SelectSurname(), SelectCf(), SetDB()); // le date possono anche ripetersi
        }

        private static string[] titles = { "Memorie di Adriano", "Il conte di Montecristo", "Il Gattopardo", "1984", "Cime tempestose", "I fratelli Karamazov" };
        private static string[] authors = { "Marguerite Yourcenar", "Alexandre Dumas", "Giuseppe Tomasi di Lampedusa", "George Orwell", "Emily Brontë", "Fedor Dostoevskij" };
        private static string[] genres = { "Romanzo", "Fantasy", "Giallo", "Poema epico", "Comico", "Horror" };

        //Genera isbn pseudo random
        private static string SetIsbns()
        {
            string isbn = "";
            while (isbn.Length < 13)
            {
                isbn += Convert.ToString(rnd.Next(1,9));
            }
            return isbn;
        } 

        //Setta un titolo a caso dall'array
        private static string SelectTitle()
        {
            int index = rnd.Next(6);
            string t = "";
            while (t == "")
            {
                if (titles[index] != "")
                {
                    t = titles[index];
                    titles[index] = "";
                }
                else
                {

                    index = rnd.Next(6);
                }
            }
            return t;
        }

        //Setta un autore a caso dall'array
        private static string SelectAuthor()
        {
            int index = rnd.Next(6);
            string a = "";
            while (a == "")
            {
                if (authors[index] != "")
                {
                    a = authors[index];
                    authors[index] = "";
                }
                else
                {
                    index = rnd.Next(6);
                }
            }
            return a;
        }

        //Setta un genere a caso dall'array
        private static string SelectGenre()
        {
            int index = rnd.Next(6);
            string g = "";
            while (g == "")
            {
                if (genres[index] != "")
                {
                    g = genres[index];
                    genres[index] = "";
                }
                else
                {
                    index = rnd.Next(6);
                }
            }
            return g;
        }

        //Genera un libro
        public static Book GenerateBook()
        {
            return new Book(SelectTitle(), SelectAuthor(), SetIsbns(), SelectGenre());
        }
    }

}
