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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
            SortBox.Items.AddRange(new string[] { "По названию", "По площади", "По населению" });
            Output();
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortBox.Text)
            {
                case "По названию":
                    infoBox.Clear();
                    Array.Sort(Information.StateName);
                    Output();
                    break;
                case "По площади":
                    infoBox.Clear();
                    Array.Sort(Information.Area);
                    Output();
                    break;
                case "По населению":
                    infoBox.Clear();
                    Array.Sort(Information.Population);
                    Output();
                    break;
            }
        }
        private void Output()
        {
            for (int i=0; i<Information.size; i++)
            {
                infoBox.Text += ($"Название страны: {Information.StateName[i]}\n");
                infoBox.Text += ($"Столица: {Information.Capital[i]}\n");
                infoBox.Text += ($"Континент: {Information.Сontinent[i]}\n");
                infoBox.Text += ($"Численность населения: {Information.Population[i]}\n");
                infoBox.Text += ($"Площадь: {Information.Area[i]} км^2\n\n");               
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
