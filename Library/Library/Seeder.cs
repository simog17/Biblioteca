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
            return new DateTime(rnd.Next(1950, 2017), rnd.Next(1, 12), rnd.Next(1, 30));
        }

        //Setta elementi dell'istanza
        private static string Select(ref string[] data, int count)
        {
            int index = rnd.Next(count);
            string temp = "";
            while (temp == "")
            {
                if (data[index] != "")
                {
                    temp = data[index];
                    data[index] = "";
                }
                else
                {
                    index = rnd.Next(count);
                }  
            }
            return temp;
        }

        //Genera un utente
        public static User GenerateUser()
        {
            ;
            return new User(Select(ref names, 5), Select(ref surnames, 5), Select(ref cf, 5), SetDB());
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

        //Genera un libro
        public static Book GenerateBook()
        {
            return new Book(Select(ref titles, 6), Select(ref authors, 6), SetIsbns(), Select(ref genres, 6));
        }
    }

}
