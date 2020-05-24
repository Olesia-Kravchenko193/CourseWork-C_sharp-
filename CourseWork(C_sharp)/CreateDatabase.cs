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
    public partial class CreateDatabase : Form
    {
        public CreateDatabase()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            string new_StateName, new_Capital, new_Continent;
            int new_Population, new_Area, count = 0;

            try
            {
                new_StateName = Name_textBox.Text;
                new_Capital = Capital_textBox.Text;
                new_Continent = Continent_textBox.Text;
                new_Population = Convert.ToInt32(Population_textBox.Text);
                new_Area = Convert.ToInt32(Area_textBox.Text);

                for (int i = 0; i < Information.size; i++)
                {
                    if (new_StateName == Information.StateName[i])
                        count++;
                }
                if (count != 0)
                {
                    MessageBox.Show("Такая страна уже есть в базе данных!");
                }
                else
                {
                    if (new_StateName.Length >= 3 && new_Capital.Length >= 3 && new_Continent.Length >= 4 && new_Population >= 0 && new_Area >= 0)
                    {

                        Information.size++;
                        information.ArrayResize();
                        Information.StateName[Information.index] = new_StateName;
                        Information.Capital[Information.index] = new_Capital;
                        Information.Сontinent[Information.index] = new_Continent;
                        Information.Population[Information.index] = new_Population;
                        Information.Area[Information.index] = new_Area;
                        Information.index++;

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
                                sw.Write(Information.StateName[i]);
                                sw.Write(Information.Capital[i]);
                                sw.Write(Information.Сontinent[i]);
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
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            if (Name_textBox.Text != String.Empty && Capital_textBox.Text != String.Empty && Continent_textBox.Text != String.Empty && Population_textBox.Text != String.Empty && Area_textBox.Text != String.Empty)
            {
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
    }
}
