﻿namespace CourseWork_C_sharp_
{
    partial class About_the_program
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CreateButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.RadioButton();
            this.DeleteButton = new System.Windows.Forms.RadioButton();
            this.SortButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.RadioButton();
            this.Menu_Button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(288, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.Location = new System.Drawing.Point(31, 51);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(209, 38);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.TabStop = true;
            this.CreateButton.Text = "Создание базы данных и \r\nдобавление новых записей";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.CheckedChanged += new System.EventHandler(this.CreateButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.Location = new System.Drawing.Point(31, 108);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 21);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.TabStop = true;
            this.SearchButton.Text = "Поиск записей";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.CheckedChanged += new System.EventHandler(this.SearchButton_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Location = new System.Drawing.Point(31, 147);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(152, 21);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.TabStop = true;
            this.DeleteButton.Text = "Удаление записей";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.CheckedChanged += new System.EventHandler(this.DeleteButton_CheckedChanged);
            // 
            // SortButton
            // 
            this.SortButton.AutoSize = true;
            this.SortButton.Location = new System.Drawing.Point(31, 187);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(230, 21);
            this.SortButton.TabIndex = 5;
            this.SortButton.TabStop = true;
            this.SortButton.Text = "Выдача сведений, сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.CheckedChanged += new System.EventHandler(this.SortButton_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.Location = new System.Drawing.Point(31, 385);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 40);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MenuButton.Location = new System.Drawing.Point(155, 385);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(106, 40);
            this.MenuButton.TabIndex = 16;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Location = new System.Drawing.Point(31, 227);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(197, 21);
            this.EditButton.TabIndex = 17;
            this.EditButton.TabStop = true;
            this.EditButton.Text = "Редактирование записей";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.CheckedChanged += new System.EventHandler(this.EditButton_CheckedChanged);
            // 
            // Menu_Button
            // 
            this.Menu_Button.AutoSize = true;
            this.Menu_Button.Location = new System.Drawing.Point(31, 268);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(66, 21);
            this.Menu_Button.TabIndex = 18;
            this.Menu_Button.TabStop = true;
            this.Menu_Button.Text = "Меню";
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.CheckedChanged += new System.EventHandler(this.Menu_Button_CheckedChanged);
            // 
            // About_the_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "About_the_program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About_the_program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton CreateButton;
        private System.Windows.Forms.RadioButton SearchButton;
        private System.Windows.Forms.RadioButton DeleteButton;
        private System.Windows.Forms.RadioButton SortButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.RadioButton EditButton;
        private System.Windows.Forms.RadioButton Menu_Button;
    }
}