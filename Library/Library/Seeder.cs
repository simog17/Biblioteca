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

        //Genera un utente
        public static User GenerateUser()
        {
            return new User(names[rnd.Next(0, 5)], surnames[rnd.Next(0,5)], cf[rnd.Next(0,5)], new DateTime(rnd.Next(1960, 2000), rnd.Next(1, 12), rnd.Next(1, 28)));
        }

        private static string[] titles = { "Memorie di Adriano", "Il conte di Montecristo", "Il Gattopardo", "1984", "Cime tempestose", "I fratelli Karamazov" };
        private static string[] authors = { "Marguerite Yourcenar", "Alexandre Dumas", "Giuseppe Tomasi di Lampedusa", "George Orwell", "Emily Brontë", "Fedor Dostoevskij" };
        private static string[] genres = { "Romanzo", "Fantasy", "Giallo", "Poema epico", "Comico", "Horror" };
        private static int tLength = titles.Length;
        private static int aLength = authors.Length;
        private static int gLength = genres.Length;
        static List<string> isbnList = new List<string>();  // serve per il controllo della unicità dell' isbn

        //Genera isbn pseudo random + controllo se sia univoco o meno
        private static string SetIsbns()
        {
            string isbn = "";
            int _count = isbnList.Count;
            while (isbn.Length < 13)
            {
                isbn += Convert.ToString(rnd.Next(1,9));
                if (isbn.Length == 12)  // Controllo su isbn. Deve essere univoco quindi diverso dagli altri
                {
                    for (int i = 0; i < _count; i++)
                    {
                        if (isbn == isbnList[i])   
                        {
                            isbn = "";  // Così lo deve rigenerare 
                        }
                    }
                }
            }
            isbnList.Add(isbn);
            return isbn;
        }

        //Evita che i titoli dei libri si ripetano
        private static string SetTitle(ref string[] data, int count)
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

        //Genera un libro
        public static Book GenerateBook()
        {
            return new Book(SetTitle(ref titles, tLength), authors[rnd.Next(0, aLength)], genres[rnd.Next(0, gLength)], SetIsbns());
        }
    }

}
