namespace CourseWork_C_sharp_
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchCapitalButton = new System.Windows.Forms.Button();
            this.SearchAreaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы можете найти нужную вам страну по названию столицы \r\n              или по площ" +
    "ади свыше заданной";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(37, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 1;
            // 
            // SearchCapitalButton
            // 
            this.SearchCapitalButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchCapitalButton.Location = new System.Drawing.Point(37, 162);
            this.SearchCapitalButton.Name = "SearchCapitalButton";
            this.SearchCapitalButton.Size = new System.Drawing.Size(143, 42);
            this.SearchCapitalButton.TabIndex = 2;
            this.SearchCapitalButton.Text = "Поиск по столице";
            this.SearchCapitalButton.UseVisualStyleBackColor = false;
            this.SearchCapitalButton.Click += new System.EventHandler(this.SearchCapitalButton_Click);
            // 
            // SearchAreaButton
            // 
            this.SearchAreaButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchAreaButton.Location = new System.Drawing.Point(37, 210);
            this.SearchAreaButton.Name = "SearchAreaButton";
            this.SearchAreaButton.Size = new System.Drawing.Size(143, 42);
            this.SearchAreaButton.TabIndex = 3;
            this.SearchAreaButton.Text = "Поиск по площади";
            this.SearchAreaButton.UseVisualStyleBackColor = false;
            this.SearchAreaButton.Click += new System.EventHandler(this.SearchAreaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите площадь или столицу:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(284, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 351);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MenuButton.Location = new System.Drawing.Point(640, 373);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(106, 40);
            this.MenuButton.TabIndex = 15;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.infoButton.Location = new System.Drawing.Point(37, 375);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(114, 37);
            this.infoButton.TabIndex = 16;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchAreaButton);
            this.Controls.Add(this.SearchCapitalButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Search_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchCapitalButton;
        private System.Windows.Forms.Button SearchAreaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button infoButton;
    }
}