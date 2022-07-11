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
                "Aktualnie w bazie jest " + My_Games.Properties.Settings.Default.QtyGame + " gier.\n" +
                "¯yczê mi³ej zabawy :)";
            TitleLbl.TextAlign = ContentAlignment.TopCenter;
            TitleLbl.Location = new Point((this.Size.Width / 2) - (TitleLbl.Size.Width / 2), 10);
        }

        private void WisielecBtn_Click(object sender, EventArgs e)
        {
            Games.Wisielec wisielec = new Games.Wisielec();
            wisielec.ShowDialog();
        }
    }
}