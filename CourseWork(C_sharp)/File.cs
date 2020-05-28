using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork_C_sharp_
{
    class File
    {
        public void Write()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Binary files (*.bin) | *.bin";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string filename = save.FileName;
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(Information.size);
                bw.Write(Information.index);
                for (int i = 0; i < Information.size; i++)
                {
                    bw.Write(Information.state[i].StateName);
                    bw.Write(Information.state[i].Capital);
                    bw.Write(Information.state[i].Continent);
                    bw.Write(Information.state[i].Population);
                    bw.Write(Information.state[i].Area);
                }
                MessageBox.Show("Данные сохранены");
                bw.Close();
                fs.Close();
            }

        }
        public void Read()
        {
            Information information = new Information();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Binary files (*.bin) | *.bin";
            DialogResult result = MessageBox.Show("Загрузить файл?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;
                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                    Information.size = br.ReadInt32();
                    Information.index = br.ReadInt32();
                    information.ArrayResize();
                    for (int i = 0; i < Information.size; i++)
                    {
                        
                        Information.state[i].StateName = br.ReadString();
                        Information.state[i].Capital = br.ReadString();
                        Information.state[i].Continent = br.ReadString();
                        Information.state[i].Population = br.ReadInt64();
                        Information.state[i].Area = br.ReadInt32();
                    }
                    MessageBox.Show("Данные загружены");
                    br.Close();
                    fs.Close();
                }
            }
        }
    }
}
