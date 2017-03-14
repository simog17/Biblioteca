using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                usersListBox.Items.Add(Seeder.GenerateUser());  //aggiungo l'elemento della lista users alla listBox
            }
            for (int i = 0; i <= 5; i++)
            {
                booksListBox.Items.Add(Seeder.GenerateBook());  //aggiungo l'elemento della lista books alla listBox
            }
            booksListBox.SelectedIndex = 0;
            usersListBox.SelectedIndex = 0;
        }
   
        private void infoUserButton_Click(object sender, EventArgs e)
        {
            int index;
            index = usersListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            User u = (User)usersListBox.Items[index];
            txt.Text = u.Describe();
        }

        private void infoBookButton_Click(object sender, EventArgs e)
        {
            int index;
            index = booksListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            Book b = (Book)booksListBox.Items[index];
            txt.Text = b.Describe();
        }

        private void bookedButton_Click(object sender, EventArgs e)
        {
            int userIndex = usersListBox.SelectedIndex;
            int bookIndex = booksListBox.SelectedIndex;
            User u = (User)usersListBox.Items[userIndex];
            Book b = (Book)booksListBox.Items[bookIndex];
            b.ToBook(u, txt);
        }
    }
}
