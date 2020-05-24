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
            int count = 0, actual = 0;
            string name = textBoxName.Text;
            for (int i=0; i<Information.size; i++)
            {
                if(name == Information.StateName[i])
                {
                    actual = i;
                    Name_textBox.Text = Information.StateName[actual];
                    Capital_textBox.Text = Information.Capital[actual];
                    Continent_textBox.Text = Information.Сontinent[actual];
                    Population_textBox.Text = Convert.ToString(Information.Population[actual]);
                    Area_textBox.Text = Convert.ToString(Information.Area[actual]);
                    count++;
                }
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string new_StateName, new_Capital, new_Continent;
            int new_Population, new_Area, actual=0;

            try
            {
                new_StateName = Name_textBox.Text;
                new_Capital = Capital_textBox.Text;
                new_Continent = Continent_textBox.Text;
                new_Population = Convert.ToInt32(Population_textBox.Text);
                new_Area = Convert.ToInt32(Area_textBox.Text);

                    if ( new_Population >= 0 && new_Area >= 0)
                    { 
                        Information.Population[actual] = new_Population;
                        Information.Area[actual] = new_Area;

                        SaveFileDialog save = new SaveFileDialog();
                        save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            string filename = save.FileName;
                            StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default);
                            sw.Write(Information.size);
                            sw.Write(Information.index);
                            for (int i = 0; i < Information.size; i++)
                            {
                                sw.Write(Information.Population[i]);
                                sw.Write(Information.Area[i]);
                            }
                            MessageBox.Show("Данные сохранены");
                            sw.Close();
                        }
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
    }
}
