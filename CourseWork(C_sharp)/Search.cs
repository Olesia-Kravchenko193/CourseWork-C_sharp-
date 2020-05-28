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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchCapitalButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string capital = textBox1.Text;
                
                richTextBox1.Clear();
                for (int i = 0; i < Information.size; i++)
                {
                    if (capital == Information.state[i].Capital)
                    {
                        richTextBox1.Text += ($"Государство: {Information.state[i].StateName},\n");
                        richTextBox1.Text += ($"Столица: {Information.state[i].Capital}\n");
                        richTextBox1.Text += ($"Континент: {Information.state[i].Continent}\n");
                        richTextBox1.Text += ($"Численность населения: {Information.state[i].Population}\n");
                        richTextBox1.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Стран с такой столицей не найдено");
            }
            catch
            {
                MessageBox.Show("Неверно введено название столицы");
            }
        }

        private void SearchAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                int area = Int32.Parse(textBox1.Text);

                richTextBox1.Clear();
                for (int i = 0; i < Information.size; i++)
                {
                    if (area <= Information.state[i].Area)
                    {
                        richTextBox1.Text += ($"Государство: {Information.state[i].StateName},\n");
                        richTextBox1.Text += ($"Столица: {Information.state[i].Capital}\n");
                        richTextBox1.Text += ($"Континент: {Information.state[i].Continent}\n");
                        richTextBox1.Text += ($"Численность населения: {Information.state[i].Population}\n");
                        richTextBox1.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Стран с площадью свыше заданной не найдено");
            }
            catch
            {
                MessageBox.Show("Неверно введено площадь");
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

        private void Search_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
