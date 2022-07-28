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
        #region Variable
        private int _Pkt = 0,_ImageNum;
        List<PictureBox> pcBoxList = new List<PictureBox>();
        Task tr1;
        #endregion
        public MemTraining()
        {
            InitializeComponent();
        }
        
        #region Methods
        public void CreateBox()
        {
            if (pcBoxList.Count > 0)
            {
                foreach (PictureBox pb in pcBoxList)
                {
                    panel1.Controls.Remove(pb);
                }
            }
            pcBoxList.Clear();           
            panel1.Size = new Size(48,48);
            int x = 5, y = 5;
            if (_ImageNum <= 5)
            {
                panel1.Size = new Size(panel1.Size.Width + (_ImageNum * 53), panel1.Size.Height);
                for (int i = 0; i <= (_ImageNum * 2)-1; i++)
                {
                    PictureBox pcBox = new PictureBox();
                    pcBox.Location = new Point(x, y);
                    pcBox.Size = new Size(48, 48);
                    pcBox.Tag = "";
                    pcBox.BackColor = Color.Black;
                    pcBox.Click += new System.EventHandler(this.BoxClick);
                    pcBoxList.Add(pcBox);
                    x += 53;                   
                    if (i == _ImageNum - 1)
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
                for (int i = 0; i <= (_ImageNum * 2)-1; i++)
                {
                    PictureBox pcBox = new PictureBox();
                    pcBox.Location = new Point(x, y);
                    pcBox.Size = new Size(48, 48);
                    pcBox.Tag = "";
                    pcBox.BackColor = Color.Black;
                    pcBox.Click+= new System.EventHandler(this.BoxClick);
                    pcBoxList.Add(pcBox);
                    x += 53;                    
                    if (x>=313)
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
        public void AddImage()
        {
            Random rand = new Random();
            List<int> ImageNumber = new List<int>();
            for(int i=0;i< _ImageNum; i++)
            {
                ImageNumber.Add(i);
                ImageNumber.Add(i);
            }
            foreach(var box in pcBoxList) { 
                int temp = ImageNumber[rand.Next(0, ImageNumber.Count - 1)];
                box.Name = temp.ToString();
                ImageNumber.Remove(temp);

            }
        }
        public void ImageCheck()
        {
            if (pcBoxList.Where(p => p.Tag.ToString() == "click").Count() < 2)
                return;
            List<PictureBox> temp = new List<PictureBox>();
            temp.AddRange(pcBoxList.Where(p => p.Tag.ToString() == "click"));
            if (temp[0].Name == temp[1].Name)
            {
                _Pkt++;
                temp[0].Enabled = false;
                temp[1].Enabled = false;
                temp[0].Click -= BoxClick;
                temp[1].Click -= BoxClick;
                temp[0].Tag = "";
                temp[1].Tag = "";
            }
            else
            {
                Thread.Sleep(1000);
                temp[0].BackColor = Color.Black;
                temp[1].BackColor = Color.Black;
                temp[0].Image = null;
                temp[1].Image = null;
                temp[0].Tag = "";
                temp[1].Tag = "";
            }
            if (pcBoxList.Where(p => p.Enabled == false).Count() == _ImageNum * 2)
            {
                MessageBox.Show("Zgadłeś wszystkie brawo !!!\nKliknij ok później nowa gra.\nPunkty przechodzą na nową grę");
            }
            return;
        }
        public void PointsChanger()
        {
            PktLbl.Text = "Punktacja: " + _Pkt;
        }
        #endregion        
        #region Events
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void MTLoad(object sender, EventArgs e)
        {
            PointsChanger();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(comboBox1.Text, out _ImageNum))
            {
                MessageBox.Show("Wybrano błędną lczbę");
                return;
            }
            CreateBox();
            AddImage();
        }
        private async void BoxClick(object sender, EventArgs e)
        {

            tr1 = new Task(ImageCheck);
            PictureBox send = (PictureBox)sender;
            if (send.BackColor == Color.Black)
            {
                int Imageid = int.Parse(send.Name.Trim());
                send.Image = PicImage.Images[Imageid];
                send.Tag = "click";
                send.BackColor = DefaultBackColor;
                ImageCheck();
                PointsChanger();
            }
            else
            {
                send.Image = null;
                send.BackColor = Color.Black;
                send.Tag = "";
            }           
        }
        #endregion
    }
}
