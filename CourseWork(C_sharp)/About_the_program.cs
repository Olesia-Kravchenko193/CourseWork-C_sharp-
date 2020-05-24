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
    public partial class About_the_program : Form
    {
        public About_the_program()
        {
            InitializeComponent();
            richTextBox1.Text = "Здесь вы можете найти всю информацию о программе.";
        }

        private void CreateButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В меню у вас есть возможность создать базу данных(при нажатии соответсвующей кнопки)";
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
