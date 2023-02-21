using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsUI
{
    public partial class Dashboard : Form
    {


        //start with an empty list
       List<Card> cards = new List<Card>();


        public Dashboard()
        {
            InitializeComponent();

            updateBinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBinding()
        {
            //put all the cards from the list into the listbox in the UI
            flashcardsListbox.DataSource = cards;
            flashcardsListbox.DisplayMember = "fullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            cards = db.GetCards(bandNameTextbox.Text);

            updateBinding();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bandNameInputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void databaseStatusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToDatabaseButton_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            db.AddCards(bandNameInputTextbox.Text, songNameTextbox.Text);

        }

        private void idDeleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteCards(idToDeleteTextbox.Text);
        }
    }
}
