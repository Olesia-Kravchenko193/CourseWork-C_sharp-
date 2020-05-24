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
                
                if(richTextBox1.Text != String.Empty)
                {
                    richTextBox1.Clear();
                }
                for (int i = 0; i < Information.size; i++)
                {
                    if (capital == Information.Capital[i])
                    {
                        richTextBox1.Text += ($"Государство: {Information.StateName[i]},\n Столица: {Information.Capital[i]},\n Континент: {Information.Сontinent[i]},\n Численность населения: {Information.Population[i]},\n Площадь: {Information.Area[i]} km^2\n");
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

                if (richTextBox1.Text != String.Empty)
                {
                    richTextBox1.Clear();
                }
                for (int i = 0; i < Information.size; i++)
                {
                    if (area <= Information.Area[i])
                    {
                        richTextBox1.Text += ($"Государство: {Information.StateName[i]},\n Столица: {Information.Capital[i]},\n Континент: {Information.Сontinent[i]},\n Численность населения: {Information.Population[i]},\n Площадь: {Information.Area[i]}\n");
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
    }
}
