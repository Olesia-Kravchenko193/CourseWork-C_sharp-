namespace CourseWork_C_sharp_
{
    partial class Sort
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
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.ContinentBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.Window;
            this.infoBox.Location = new System.Drawing.Point(12, 74);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(307, 364);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здесь вы можете просмотреть информацию о странах \r\n      заданного континента с в" +
    "ыбором сортировки";
            // 
            // SortBox
            // 
            this.SortBox.BackColor = System.Drawing.SystemColors.Window;
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Location = new System.Drawing.Point(352, 266);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(201, 24);
            this.SortBox.TabIndex = 2;
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MenuButton.Location = new System.Drawing.Point(661, 388);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(106, 40);
            this.MenuButton.TabIndex = 17;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(348, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите континент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(348, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Выберите способ сортировки:";
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.infoButton.Location = new System.Drawing.Point(12, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(114, 37);
            this.infoButton.TabIndex = 22;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // ContinentBox
            // 
            this.ContinentBox.BackColor = System.Drawing.SystemColors.Window;
            this.ContinentBox.Location = new System.Drawing.Point(352, 151);
            this.ContinentBox.Name = "ContinentBox";
            this.ContinentBox.Size = new System.Drawing.Size(201, 22);
            this.ContinentBox.TabIndex = 23;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOk.Location = new System.Drawing.Point(412, 179);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(86, 32);
            this.buttonOk.TabIndex = 24;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ReadButton.Location = new System.Drawing.Point(389, 315);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(176, 48);
            this.ReadButton.TabIndex = 25;
            this.ReadButton.Text = "Открыть файл";
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveButton.Location = new System.Drawing.Point(389, 364);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(176, 48);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.ContinentBox);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBox);
            this.Name = "Sort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Sort_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TextBox ContinentBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}