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
            TitleLbl.Text = "Poni�ej jest menu w kt�rym b�d� dodawa� wszystkie stworzone gry.\n" +
                "Aktualnie w bazie jest " + My_Games.Properties.Settings.Default.QtyGame + " gier.\n" +
                "�ycz� mi�ej zabawy :)";
            TitleLbl.TextAlign = ContentAlignment.TopCenter;
            TitleLbl.Location = new Point((this.Size.Width / 2) - (TitleLbl.Size.Width / 2), 10);
        }
    }
}