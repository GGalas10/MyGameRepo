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
    public partial class KPN : Form
    {
        int _pktPC = 0, _pktPlayer = 0;
        public KPN()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            DrawLbl.Visible = false;
            PictureBox PcBox = sender as PictureBox;
            Random rand = new Random();
            POneBox.BackColor = Color.White;
            int pc=4, player=4;
            switch (PcBox.Name)
            {
                case "Paper":
                    POneBox.Image = imageList1.Images[0];
                    player = 0;
                    break;
                case "Rock":
                    POneBox.Image = imageList1.Images[1];
                    player = 1;
                    break;
                case "Scissors":
                    POneBox.Image = imageList1.Images[2];
                    player = 2;
                    break;
            }
            int choise = rand.Next(0, 3);
            PcPlayerBox.BackColor = Color.White;
            switch (choise)
            {
                case 0:
                    PcPlayerBox.Image = imageList1.Images[0];
                    pc = 0;
                    break;
                case 1:
                    PcPlayerBox.Image = imageList1.Images[1];
                    pc = 1;
                    break;
                case 2:
                    PcPlayerBox.Image = imageList1.Images[2];
                    pc = 2;
                    break;
                default:
                    pc = player;
                    break;
            }
            if (pc == player)
            {
                DrawLbl.Visible = true;
                return;
            }
            if(pc==0 && player == 1)
            {
                _pktPC++;
                TextChange();
                return;
            }
            if (pc == 1 && player == 2)
            {
                _pktPC++;
                TextChange();
                return;
            }
            if (pc == 2 && player == 0)
            {
                _pktPC++;
                TextChange();
                return;
            }
            if (pc == 1 && player == 0)
            {
                _pktPlayer++;
                TextChange();
                return;
            }
            if (pc == 2 && player == 1)
            {
                _pktPlayer++;
                TextChange();
                return;
            }
            if (pc == 0 && player == 2)
            {
                _pktPlayer++;
                TextChange();
                return;
            }
        }
        private void TextChange()
        {
            POneLbl.Text = "Gracz\nPkt:" + _pktPlayer.ToString();
            PcPlayerLbl.Text = "PC\nPkt:" + _pktPC.ToString();
        }
    }
}
