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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        Information information = new Information();
        OpenFileDialog open = new OpenFileDialog();
        //open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить эти страны?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int count = 0;
                    int populatoin = Int32.Parse(textBox1.Text);

                    if (richTextBox1.Text != String.Empty)
                    {
                        richTextBox1.Clear();
                    }
                    for (int i = 0; i < Information.size; i++)
                    {
                        if (populatoin >= Information.Population[i])
                        {
                            richTextBox1.Text += ($"Государство: {Information.StateName[i]},\n Столица: {Information.Capital[i]},\n Континент: {Information.Сontinent[i]},\n Численность населения: {Information.Population[i]},\n Площадь: {Information.Area[i]}\n");
                            count++;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Неверно введено численность");
                }
                information.ClearAll();
                MessageBox.Show("Удалено!");
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
