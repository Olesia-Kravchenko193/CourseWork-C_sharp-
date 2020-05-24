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
            this.ContinentBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 74);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(307, 364);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Location = new System.Drawing.Point(352, 266);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(201, 24);
            this.SortBox.TabIndex = 2;
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(661, 388);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(106, 40);
            this.MenuButton.TabIndex = 17;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ContinentBox
            // 
            this.ContinentBox.FormattingEnabled = true;
            this.ContinentBox.Location = new System.Drawing.Point(352, 137);
            this.ContinentBox.Name = "ContinentBox";
            this.ContinentBox.Size = new System.Drawing.Size(201, 24);
            this.ContinentBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Выберите континент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Выберите способ сортировки";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(12, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(114, 37);
            this.infoButton.TabIndex = 22;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContinentBox);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBox);
            this.Name = "Sort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.ComboBox ContinentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button infoButton;
    }
}