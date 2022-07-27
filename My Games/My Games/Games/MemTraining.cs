using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Games.Games
{
    public partial class MemTraining : Form
    {
        private int _Pkt = 0;
        List<PictureBox> pcBoxList = new List<PictureBox>();
        public MemTraining()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void MTLoad(object sender, EventArgs e)
        {
            PktLbl.Text = "Punktacja: "+_Pkt;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int HowManyImage;
            if(!int.TryParse(comboBox1.Text,out HowManyImage))
            {
                MessageBox.Show("Wybrano błędną lczbę");
                return;
            }
            CreateBox(HowManyImage - 1);
        }


        #region Methods
        public void CreateBox(int How)
        {
            pcBoxList.Clear();
            panel1.Size = new Size(48,48);
            int x = 5, y = 5;
            if (How < 5)
            {
                panel1.Size = new Size(panel1.Size.Width + (How * 53), panel1.Size.Height);
                for (int i = 0; i < How*2; i++)
                {
                    PictureBox pcBox = new PictureBox();
                    pcBox.Location = new Point(x, y);
                    pcBox.Size = new Size(48, 48);
                    pcBox.Image = BlackPic.Images[0];
                    pcBoxList.Add(pcBox);
                    x += 53;                   
                    if (i == How)
                    {
                        panel1.Size = new Size(panel1.Size.Width, panel1.Size.Height+53);
                        y += 53;
                        x = 5;
                    }
                }
            }
            else
            {
                panel1.Size = new Size(panel1.Size.Width + (6 * 53), panel1.Size.Height);
                for (int i = 0; i < How * 2; i++)
                {
                    PictureBox pcBox = new PictureBox();
                    pcBox.Location = new Point(x, y);
                    pcBox.Size = new Size(48, 48);
                    pcBox.Image = BlackPic.Images[0];
                    pcBoxList.Add(pcBox);
                    x += 53;                    
                    if (i % 6==0)
                    {
                        panel1.Size = new Size(panel1.Size.Width, panel1.Size.Height+53);
                        y += 53;
                        x = 5;
                    }
                }
            }
            SizeChanger();
            foreach (var box in pcBoxList)
            {
                panel1.Controls.Add(box);
            }
        }
        public void SizeChanger()
        {
            if (panel1.Size.Width >= this.Size.Width)
                this.Size = new Size(panel1.Size.Width + 40, Height);
            if (panel1.Size.Height >= this.Size.Height && panel1.Size.Height >277)
                this.Size = new Size(Width, panel1.Size.Height+133);
        }
        #endregion
    }
}
