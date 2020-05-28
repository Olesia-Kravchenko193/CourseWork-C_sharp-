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
    public partial class CreateDatabase : Form
    {
        Information information = new Information(); 
        File file = new File();
        public CreateDatabase()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string new_StateName, new_Capital, new_Continent;
            long new_Population;
            int new_Area, count = 0;

            DialogResult result = MessageBox.Show("Сохранить информацию?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    new_StateName = Name_textBox.Text;
                    new_Capital = Capital_textBox.Text;
                    new_Continent = Continent_textBox.Text;
                    new_Population = Convert.ToInt64(Population_textBox.Text);
                    new_Area = Convert.ToInt32(Area_textBox.Text);

                    for (int i = 0; i < Information.size; i++)
                    {
                        if (new_StateName == Information.state[i].StateName)
                            count++;
                    }
                    if (count != 0)
                    {
                        MessageBox.Show("Такая страна уже есть в базе данных!");
                    }
                    else
                    {
                        if (new_StateName.Length >= 3 && new_Capital.Length >= 3 && new_Continent.Length >= 4 && new_Population > 0 && new_Area > 0)
                        {

                            Information.size++;
                            information.ArrayResize();
                            Information.state[Information.index].StateName = new_StateName;
                            Information.state[Information.index].Capital = new_Capital;
                            Information.state[Information.index].Continent = new_Continent;
                            Information.state[Information.index].Population = new_Population;
                            Information.state[Information.index].Area = new_Area;
                            Information.index++;

                            file.Write();                          
                        }
                        else
                        {
                            MessageBox.Show("Неверный ввод одного из полей");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Неверный ввод! Введите заново!");//проверка на дурака
                }
                Name_textBox.Clear();
                Capital_textBox.Clear();
                Continent_textBox.Clear();
                Population_textBox.Clear();
                Area_textBox.Clear();
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

        private void CreateDatabase_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }
    }
}
