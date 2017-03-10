using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Seeder
    {
        private static string[] name = { "Simone", "Nicola", "Pietro", "Gianni", "Pippo" };
        private static string[] surname = { "Rossi", "Verdi", "Gialli", "Galli", "Neri"};
        private static string[] cf = { "FDMZST83M03Z320Q","FDMZST83M03Z320Q","XGJKDE87C29D582A", "BFRPFC80H13L640O", "PRLRVC36T21L675Y" };
        private static DateTime[] dB = new DateTime[]
        {
            new DateTime(2000,03,8),
            new DateTime(2001,03,9),
            new DateTime(2002,03,10),
            new DateTime(2003,03,11),
            new DateTime(2004,03,23),
        };

        private static Random rnd = new Random();

        //prende un nome a caso dall'array
        private static string SelectName()
        {
            int index = rnd.Next(0,5);
            string n = "";
            while (n == "")
            {
                if (name[index] != "")
                {
                    n = name[index];
                    name[index] = "";
                }
                else
                {
                    index = rnd.Next(5);
                }  
            }
            return n;
        }

        //prende un cognome a caso dall'array
        private static string SelectSurname()
        {
            int index = rnd.Next(5);
            string s = "";
            while (s == "")
            {
                if (surname[index] != "")
                {
                    s = surname[index];
                    surname[index] = "";
                }
                else
                {
                    index = rnd.Next(5);
                }
            }
            return s;
        }

        //prende un codice fiscale a caso dall'array
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

        public static User GenerateUser()
        {
            User u = new User(SelectName(), SelectSurname(), SelectCf(), dB[rnd.Next(4)]); // le date possono anche ripetersi
            return u;
        }

        /*public static Book GenerateBook()      da fare
        {

        }*/
    }

}
