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
                usersListBox.Items.Add(Seeder.GenerateUser());
            }
            for (int i = 0; i <= 5; i++)
            {
                booksListBox.Items.Add(Seeder.GenerateBook());
            }
            
        }

        int index;
        private void infoUserButton_Click(object sender, EventArgs e)
        {
            index = usersListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            txt.Text = Convert.ToString(usersListBox.Items[index].ToString());
        }

        private void infoBookButton_Click(object sender, EventArgs e)
        {
            index = booksListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            txt.Text = Convert.ToString(booksListBox.Items[index].ToString());
        }
    }
}
