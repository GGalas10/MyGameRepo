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
    public partial class KiK : Form
    {

        #region Variable
        /// <summary>
        /// WHO variable
        /// X = 1
        /// O = 2
        /// </summary>
        private int who=0;
        private int whoWin;
        private int pktX = 0;
        private int pktO = 0;
        private Button[,] btnList = new Button[3, 3];
        #endregion
        public KiK()
        {
            InitializeComponent();
            SetPktText();
        }
        #region Methods
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            pktX=0;
            pktO=0;
            Start();           
        }
        private void BtnClick(object sender, EventArgs e)
        {
            
            Button send = (sender as Button);
            if (who == 1)
            {
                send.Text = "X".ToUpper();
                send.Name = "X";
                send.BackColor = Color.Black;
                Font font = new Font(FontFamily.GenericSansSerif, 50f, FontStyle.Bold);
                send.Font = font;
                send.ForeColor = Color.White;
                send.Click -= BtnClick;
                who = 2;
                RoundLbl.Text = "Teraz kolej O";
            }
            else
            {
                send.Text = "O";
                send.Name = "O";
                send.BackColor = Color.Black;
                Font font = new Font(FontFamily.GenericSansSerif, 50f, FontStyle.Bold);
                send.Font = font;
                send.ForeColor = Color.White;
                send.Click -= BtnClick;
                who = 1;
                RoundLbl.Text = "Teraz kolej X";
            }
            checkWIn();
        }
        private void checkWIn()
        {
            int WinX = 0;
            int WinY = 0;
            int WinC = 0;
            for (int i = 0; i < 3; i++)
            {
                WinX = 0;
                WinY = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (btnList[i, j].Name == "X")
                        WinX++;
                    if (btnList[j, i].Name == "X")
                        WinY++;
                }
                if (btnList[i, i].Name == "X")
                    WinC++;             
                if (WinX == 3 || WinY == 3 || WinC == 3)
                {
                    MessageBox.Show("Wygrał X");
                    whoWin = 1;
                    pktX++;
                    Start();
                    SetPktText();
                    return;
                }
            }
            WinC= 0;
            for(int i = 0; i < 3; i++)
            {
                if (btnList[i, 2 - i].Name == "X")
                    WinC++;
            }
            if (WinC == 3)
            {
                MessageBox.Show("Wygrał X");
                whoWin = 1;
                pktX++;
                Start();
                SetPktText();
                return;
            }
            WinC = 0;
            for (int i = 0; i < 3; i++)
            {
                WinX = 0;
                WinY = 0;
                
                for (int j = 0; j < 3; j++)
                {
                    if (btnList[i, j].Name == "O")
                    {
                        WinX++;
                    }
                    if (btnList[j, i].Name == "O")
                    {
                        WinY++;
                    }
                }
                if (btnList[i, i].Name == "O")
                {
                    WinC++;
                }
                if (WinX == 3 || WinY == 3 || WinC == 3)
                {
                    MessageBox.Show("Wygrał O");
                    whoWin = 2;
                    pktO++;
                    Start();
                    SetPktText();
                    return;
                }              
            }
            WinC = 0;
            for (int i = 0; i < 3; i++)
            {
                if (btnList[i, 2 - i].Name == "O")
                    WinC++;
            }
            if (WinC == 3)
            {
                MessageBox.Show("Wygrał O");
                pktO++;
                whoWin = 2;
                Start();
                SetPktText();
                return;
            }
            int temp = 0;
            foreach(Button item in btnList)
            {
                if (!(item.Name == "1"))
                    temp++;
            }
            if(temp == 9)
            {
                MessageBox.Show("Remis");
                whoWin = 0;
                Start();
                SetPktText();
                return;
            }
        }
        private void Start()
        {
            if (btnList[0, 0] != null)
            {
                foreach (var it in btnList)
                {
                    panel1.Controls.Remove(it);
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        btnList[i, j] = null;
                    }
                }
            }
            Pen pen = new Pen(Color.Black, 4f);
            Graphics Graph = panel1.CreateGraphics();
            int x = 6;
            int y = 6;
            if (whoWin == 2 && who != 0) {
                who = 1;
                RoundLbl.Text = "Zaczyna X";
            }
            else
            {
                if (whoWin == 1 && who != 0)
                {
                    who = 2;
                    RoundLbl.Text = "Zaczyna O";
                }
                else
                {
                    who = 1;
                    RoundLbl.Text = "Zaczyna X";
                }
            }
            
            Graph.Clear(panel1.BackColor);
            for (int i = 0; i <= 2; i++)
            {
                x = 6;
                for (int j = 0; j <= 2; j++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.Name = "1";
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.White;
                    btn.Enabled = true;
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(x + (j * 112), y + (i * 112));
                    btn.Click += new System.EventHandler(BtnClick);
                    panel1.Controls.Add(btn);
                    btnList[i, j] = btn;
                }

            }
            Graph.DrawLine(pen, 112f, 0f, 112f, 336f);
            Graph.DrawLine(pen, 224f, 0f, 224f, 336f);
            Graph.DrawLine(pen, 0f, 112f, 336f, 112f);
            Graph.DrawLine(pen, 0f, 224f, 336f, 224f);
        }
        private void SetPktText()
        {
            PktLbl.Text = "Punktacja: X=" + pktX + "                    Punktacja: O= " + pktO;
        }
        #endregion
    }
}
