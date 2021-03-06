﻿using System;
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
    public partial class About_the_program : Form
    {
        public About_the_program()
        {
            InitializeComponent();
            richTextBox1.Text = "В этой программе вы можете создать базу данных 'Государство', добавить новые записи(о государствах) или удалить, найти государство, редактировать, а так же можете вывести всю информацию о странах из базы данных или отсортировать. Подробнее смотрите в разделах...";
        }

        private void CreateButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' при нажатии кнопки 'Добавить новые записи' у вас откроется окно 'CreateDatabase', в котором вы сможете добавить новые записи в базу данных или же создать базу данных. При нажатии кнопки 'Сохранить' вам будет предложено сохранить введенные данные в файл. Так же в этом окне есть кнопки 'Меню'(возвращает вас в главное окно 'Menu') и 'о программе'(при нажатии которой, вы попадаете в окно 'About_the_program', в котором сейсас находитесь. Здесь находится вся онформация о программе. Так же эту справку можно вызвать при нажатии F1.";
        }
    
        private void SearchButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' при нажатии кнопки 'Поиск записей' у вас откроется окно 'Search', в котором вы сможете найти нужные вам страны по названию столицы или по площади свыше заданной. Все данные выводятся в окошко, в котором вы можете просмотреть нужную вам информацию. Так же есть кнопки 'Mеню' и 'о программе'(Подробнее читайте в разделе 'Создание базы данных и добавление новых записей')";
        }

        private void DeleteButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' при нажатии кнопки 'Удаление записей' у вас откроется окно 'Password' в котором вам надо будет ввести пароль доступа, который имеется только у администратора. При правильном вводе вы получите доступ к окну 'Delete', в котором вы сможете удалить все страны, у которых численность меньше заданой. Кроме этого вы сможете просмотреть информацию о странах, которые удалили. Так же есть кнопки 'Mеню' и 'о программе'(Подробнее читайте в разделе 'Создание базы данных и добавление новых записей ";
        }

        private void SortButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' при нажатии кнопки 'Выдача сведений' у вас откроется окно 'Sort' в котором вы сможете просмотреть базу данных. Здесь вы можете вывести страны по континенту и отсортировать их(по названию, площади или численности). Так же здесь можете сохранить все изменения или же открыть другой файл. Есть кнопки 'Меню' и 'о программе'(Подробнее читайте в разделе 'Создание базы данных и добавление новых записей')";
        }

        private void EditButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' при нажатии кнопки 'Редактировать' у вас откроется окно 'Password'  в котором вам надо будет ввести пароль доступа, который имеется только у администратора. При правильном вводе вы получите доступ к окну 'Edit' в котором вы сможете отредактировать информацию о странах(корректировать можно только численность и площадь). При нажатии кнопки 'Изменить', все изменения будут сохранены. Так же есть кнопки 'Mеню' и 'о программе'(Подробнее читайте в разделе 'Создание базы данных и добавление новых записей')";
        }
        private void Menu_Button_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В окне 'Menu' вам будут предложены все функции программы. Окно имеет 5 главных кнопок: 'Добавить новые записи','Поиск записей','Удаление записей','Редактировать','Выдача сведенний'. Кнопка 'о программе'(при нажатии которой, вы попадаете в окно 'About_the_program', в котором сейсас находитесь. Здесь находится вся информация о программе. Так же эту справку можно вызвать при нажатии F1). И кнопка 'Выход'(при нажатии которой вы можете выйти из программы) ";
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
