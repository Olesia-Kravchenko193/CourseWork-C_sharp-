using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_C_sharp_
{
    public partial class Menu : Form
    {
        Information information = new Information();
        public Menu()
        {
            InitializeComponent();
        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateDatabase create = new CreateDatabase();
            create.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Information.count_1++;
            this.Hide();
            Password password = new Password();
            password.Show();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sort sort = new Sort();
            sort.Show();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Information.count_2++;
            this.Hide();
            Password password = new Password();
            password.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }

        private void Menu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
