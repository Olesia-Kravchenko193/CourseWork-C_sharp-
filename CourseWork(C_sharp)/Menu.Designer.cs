namespace CourseWork_C_sharp_
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(344, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateDatabaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateDatabaseButton.Location = new System.Drawing.Point(264, 90);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(272, 46);
            this.CreateDatabaseButton.TabIndex = 3;
            this.CreateDatabaseButton.Text = "Добавить новые записи";
            this.CreateDatabaseButton.UseVisualStyleBackColor = false;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(341, 374);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 43);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Location = new System.Drawing.Point(264, 142);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(272, 46);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск записей";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Location = new System.Drawing.Point(264, 194);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(272, 46);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удаление записей";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Location = new System.Drawing.Point(264, 298);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(272, 46);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Выдача сведений";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.Location = new System.Drawing.Point(12, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(114, 37);
            this.infoButton.TabIndex = 9;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Location = new System.Drawing.Point(264, 246);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(272, 46);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreateDatabaseButton);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Menu_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateDatabaseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button EditButton;
    }
}

