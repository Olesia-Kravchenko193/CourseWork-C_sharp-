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
        File file = new File();
        STATE[] sort = new STATE[1];
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
                    for (int i=0; i<Information.state.Length-1; i++)
                    {
                        for(int j=i+1; j<Information.state.Length; j++)
                        {
                            if(string.Compare(Information.state[i].StateName, Information.state[j].StateName) > 0)
                            {
                                sort[0] = Information.state[i];
                                Information.state[i] = Information.state[j];
                                Information.state[j] = sort[0];

                            }
                        }
                    }
                    SortOutput();
                    Output();
                    break;

                case "По площади":
                    for (int i = 0; i < Information.state.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Information.state.Length; j++)
                        {
                            if (Information.state[i].Area > Information.state[j].Area)
                            {
                                sort[0] = Information.state[i];
                                Information.state[i] = Information.state[j];
                                Information.state[j] = sort[0];

                            }
                        }
                    }
                    SortOutput();
                    Output();
                    break;

                case "По населению":
                    for (int i = 0; i < Information.state.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Information.state.Length; j++)
                        {
                            if (Information.state[i].Population > Information.state[j].Population)
                            {
                                sort[0] = Information.state[i];
                                Information.state[i] = Information.state[j];
                                Information.state[j] = sort[0];

                            }
                        }
                    }
                    SortOutput();
                    Output();
                    break;
            }
        }

        private void SortOutput()
        {
            infoBox.Clear();
            for (int i=0; i<Information.size; i++)
            {
                if (ContinentBox.Text == Information.state[i].Continent)
                {
                    infoBox.Text += ($"Государство: {Information.state[i].StateName}\n");
                    infoBox.Text += ($"Столица: {Information.state[i].Capital}\n");
                    infoBox.Text += ($"Континент: {Information.state[i].Continent}\n");
                    infoBox.Text += ($"Численность населения: {Information.state[i].Population}\n");
                    infoBox.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
                }                
            }
        }
        private void Output()
        {
            infoBox.Clear();
            for (int i = 0; i < Information.size; i++)
            {
                infoBox.Text += ($"Государство: {Information.state[i].StateName}\n");
                infoBox.Text += ($"Столица: {Information.state[i].Capital}\n");
                infoBox.Text += ($"Континент: {Information.state[i].Continent}\n");
                infoBox.Text += ($"Численность населения: {Information.state[i].Population}\n");
                infoBox.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
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


        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string continent = ContinentBox.Text;

                infoBox.Clear();
                for (int i = 0; i < Information.size; i++)
                {
                    if (continent == Information.state[i].Continent)
                    {
                        infoBox.Text += ($"Государство: {Information.state[i].StateName}\n");
                        infoBox.Text += ($"Столица: {Information.state[i].Capital}\n");
                        infoBox.Text += ($"Континент: {Information.state[i].Continent}\n");
                        infoBox.Text += ($"Численность населения: {Information.state[i].Population}\n");
                        infoBox.Text += ($"Площадь: {Information.state[i].Area} км^2\n\n");
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Стран не найдено");
            }
            catch
            {
                MessageBox.Show("Неверно введено название континента!");
            }
        }

        private void Sort_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About_the_program AboutTheProgram = new About_the_program();
            AboutTheProgram.Show();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            file.Read();
            if (infoBox.Text != String.Empty)
            {
                infoBox.Clear();
            }
            Output();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            file.Write();
        }
    }
}
