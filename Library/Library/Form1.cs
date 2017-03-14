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

        List<User> users= new List<User>();
        List<Book> books= new List<Book>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                users.Add(Seeder.GenerateUser());  //creo una istanza di user che viene aggiunta alla lista users
                usersListBox.Items.Add(users[i]);  //aggiungo l'elemento della lista users alla listBox
            }
            for (int i = 0; i <= 5; i++)
            {
                books.Add(Seeder.GenerateBook());  //creo una istanza di book che viene aggiunta alla lista books
                booksListBox.Items.Add(books[i]);  //aggiungo l'elemento della lista books alla listBox
            }
            
        }

        private void infoUserButton_Click(object sender, EventArgs e)
        {
            int index;
            index = usersListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            try      //gestico il caso in cui venga cliccato il bottone senza prima aver selezionato un utente
            {
                txt.Text = Convert.ToString(users[index].DescribeBook());
            }
            catch
            {
                MessageBox.Show("ERRORE. Selezionare un utente.");
            }
        }

        private void infoBookButton_Click(object sender, EventArgs e)
        {
            int index;
            index = booksListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            try      //gestico il caso in cui venga cliccato il bottone senza prima aver selezionato un libro
            {
                txt.Text = Convert.ToString(books[index].Describe());
            }
            catch
            {
                MessageBox.Show("ERROE. Selezionare un libro.");
            }
        }

        private void bookedButton_Click(object sender, EventArgs e)
        {
            int userIndex = usersListBox.SelectedIndex;
            int bookIndex = booksListBox.SelectedIndex;
            try      //gestico il caso in cui venga cliccato il bottone senza prima aver selezionato un utente e/o un libro
            {
                books[bookIndex].ToBook(users[userIndex], txt);
            }
            catch
            {
                MessageBox.Show("ERRORE. Selezionare un utente e un libro");
            }

        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
