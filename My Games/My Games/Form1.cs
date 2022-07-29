namespace My_Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TitleLbl.Text = "Poni¿ej znajduj¹ siê wszystkie moje.\n" +
                "Aktualnie w bazie s¹ " + My_Games.Properties.Settings.Default.QtyGame + " gry.\n" +
                "¯yczê mi³ej zabawy :)";
            TitleLbl.TextAlign = ContentAlignment.TopCenter;
            TitleLbl.Location = new Point((this.Size.Width / 2) - (TitleLbl.Size.Width / 2), 10);
        }

        private void WisielecBtn_Click(object sender, EventArgs e)
        {
            Games.Wisielec wisielec = new Games.Wisielec();
            wisielec.ShowDialog();
        }

        private void KiKBtn_Click(object sender, EventArgs e)
        {
            Games.KiK kik = new Games.KiK();
            kik.ShowDialog();
        }

        private void MemoryBtn_Click(object sender, EventArgs e)
        {
            Games.MemTraining mem = new Games.MemTraining();
            mem.ShowDialog();
        }

        private void KPN_Click(object sender, EventArgs e)
        {
            Games.KPN kpn = new Games.KPN();
            kpn.ShowDialog();
        }
    }
}