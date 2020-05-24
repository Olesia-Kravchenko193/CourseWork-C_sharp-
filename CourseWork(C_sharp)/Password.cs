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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if (password == Information.password && Information.count_1 != 0)
            {
                this.Hide();
                Delete delete = new Delete();
                delete.Show();
                Information.count_1 = 0;
            }

            if (password == Information.password && Information.count_2 != 0)
            {
                this.Hide();
                Edit edit = new Edit();
                edit.Show();
                Information.count_2 = 0;
            }
        
            if(textBox1.Text != String.Empty)
            {
                textBox1.Clear();
            }
        }
    }
}
