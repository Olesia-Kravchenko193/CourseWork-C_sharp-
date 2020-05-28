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
    
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить эти страны?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int count = 0;
                    int populatoin = Int32.Parse(textBox1.Text);

                    for (int i = 0; i < Information.size; i++)
                    {
                        if (populatoin > Information.state[i].Population)
                        {
                            richTextBox1.Text += ($"Государство: {Information.state[i].StateName}\n");
                            richTextBox1.Text += ($"Столица: {Information.state[i].Capital}\n");
                            richTextBox1.Text += ($"Континент: {Information.state[i].Continent}\n");
                            richTextBox1.Text += ($"Численность населения: {Information.state[i].Population}\n");
                            richTextBox1.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
                            information.StateDelete(i);
                            count++;
                        }

                    }
                    if(count == 0)
                    {                  
                            MessageBox.Show("Стран, у которых численность меньше заданной, не найдено!");
                    }
                    else
                    {
                            MessageBox.Show("Удалено!");
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Неверно введено численность");
                }
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

        private void Delete_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
