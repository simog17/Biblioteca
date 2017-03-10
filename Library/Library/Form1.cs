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
            usersListBox.Items.Add(Seeder.GenerateUser());
        }

        int index;
        private void infoUserButton_Click(object sender, EventArgs e)
        {
            index = usersListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            txt.Text = Convert.ToString(usersListBox.Items[index]);
        }

        private void infoBookButton_Click(object sender, EventArgs e)
        {
            index = booksListBox.SelectedIndex;  // indice dell'elemento selezionato nella listBox
            txt.Text = Convert.ToString(booksListBox.Items[index]);
        }
    }
}
