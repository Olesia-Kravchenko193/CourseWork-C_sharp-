using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork_C_sharp_
{
    public partial class Edit : Form
    {
        int actual;
        public Edit()
        {
            InitializeComponent();
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string name = textBoxName.Text;
                for (int i = 0; i < Information.size; i++)
                {
                    if (name == Information.state[i].StateName)
                    {
                        actual = i;
                        Name_textBox.Text = Information.state[actual].StateName;
                        Capital_textBox.Text = Information.state[actual].Capital;
                        Continent_textBox.Text = Information.state[actual].Continent;
                        Population_textBox.Text = Convert.ToString(Information.state[actual].Population);
                        Area_textBox.Text = Convert.ToString(Information.state[actual].Area);
                        count++;

                        Population_textBox.ReadOnly = false;
                        Area_textBox.ReadOnly = false;

                    }
                }  
                
                if (count == 0)
                {
                    MessageBox.Show("Данной страны нет в базе даных.");
                }
            }
            catch
            {
                MessageBox.Show("Неверный ввод!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int new_Population, new_Area;

            try
            {              
                new_Population = Convert.ToInt32(Population_textBox.Text);
                new_Area = Convert.ToInt32(Area_textBox.Text);

                    if ( new_Population >= 0 && new_Area >= 0)
                    {
                        Information.state[actual].Population = new_Population;
                        Information.state[actual].Area = new_Area;
                        MessageBox.Show("Изменено!");
                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод одного из полей");
                    }      
                    
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Edit_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
