using My_Games.GameClass;
using System.Drawing.Drawing2D;
namespace My_Games.Games
{
    public partial class Wisielec : Form
    {
        private List<TextBox> lettersBoxes = new List<TextBox>();
        private List<string> Category = new List<string>()
        {
            "Losowe","Jedzenie","Kraje","Miasta","Sport","Kwiaty","Zwierzęta"
        };
        private List<string> allCategoryWords = new List<string>();
        private string Word="";
        private int points = 0;
        private int life = 10;
        public Wisielec()
        {
            InitializeComponent();
        }

        private void Wisielec_Load(object sender, EventArgs e)
        {
            CategoryBox.Items.AddRange(Category.ToArray());
            TextChanger();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {           
            points = 0;
            life = 10;
            TextChanger();
            allCategoryWords.Clear();
            foreach(var Cat in CategoryBox.CheckedItems)
            {
                if(!String.IsNullOrEmpty(Cat.ToString()))
                    CategoryAdd(Cat.ToString(), allCategoryWords);
            };
            if (allCategoryWords.Count == 0)
                allCategoryWords.AddRange(Words.RandomWords);
            GetWord(allCategoryWords);
            MessageBox.Show(Word);
            SetTextBox(Word);
        }
        private void CategoryAdd(string Name, List<string> WordsList)
        {
            switch (Name)
            {
                case "Losowe":
                    WordsList.AddRange(Words.RandomWords);
                    break;
                case "Jedzenie":
                    WordsList.AddRange(Words.FoodWords);
                    break;
                case "Kraje":
                    WordsList.AddRange(Words.CountryWords);
                    break;
                case "Miasta":
                    WordsList.AddRange(Words.CityWords);
                    break;
                case "Sport":
                    WordsList.AddRange(Words.SportWords);
                    break;
                case "Kwiaty":
                    WordsList.AddRange(Words.FlowerWords);
                    break;
                case "Zwierzęta":
                    WordsList.AddRange(Words.AnimalWords);
                    break;
                default:
                    break;
            }
            
        }
        private void GetWord(List<string> WordsList)
        {
            Random IndexOfWord = new Random();
            Word = WordsList[IndexOfWord.Next(0, WordsList.Count-1)];
        }
        private void SetTextBox(string text)
        {
            int startlocation = (580-(34 * text.Length))/2;
            int x = startlocation-34;
            int y = 350;
            Dictionary<int, Char> Letter = new Dictionary<int, char>();
            for (int i = 0; i < text.Count(); i++)
                Letter.Add(i, text[i]);
            lettersBoxes.Clear();
            if (Word != "")
            {
                foreach (char letter in Word)
                {
                    foreach (var item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            this.Controls.Remove((Control)item);
                        }
                    }
                }
            }
            foreach (char item in Letter.Values)
            {
                TextBox LetterBox = new TextBox();
                LetterBox.MaxLength = 1;
                LetterBox.Size = new Size(24,24);
                if(item.ToString()==" " || item.ToString() == "-")
                {
                    LetterBox.Text = item.ToString();
                    LetterBox.Enabled = false;
                }
                LetterBox.Name = item.ToString();
                LetterBox.Font = new Font(FontFamily.GenericSerif,10f,FontStyle.Bold);
                LetterBox.Location = new Point(x, y);
                LetterBox.TextAlign = HorizontalAlignment.Center;
                LetterBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckedLetter);
                x += 34;
                this.Controls.Add(LetterBox);
                lettersBoxes.Add(LetterBox);
            }
        }
        private void CheckedLetter(Object textBox, KeyEventArgs e)
        {
            int how = 0;
            foreach(TextBox box in lettersBoxes)
            {
                if (box.Enabled == false)
                    how++;
            }
            if(how == lettersBoxes.Count-1)
            {                
                GetWord(allCategoryWords);
                SetTextBox(Word);
                MessageBox.Show("Brawo !!!");
            }
            TextBox sender = textBox as TextBox;
            if (sender.Name.ToLower().Trim() == sender.Text.ToLower().Trim())
            {
                points++;
                sender.Enabled = false;
                TextChanger();
            }
            else
            {
                if(life == 0)
                {
                    MessageBox.Show("Niestety przegrałeś\nZdobyłeś "+points+" punktów");
                    points = 0;
                    life = 10;
                    Painting();
                    TextChanger();
                    GetWord(allCategoryWords);
                    MessageBox.Show(Word);
                    SetTextBox(Word);
                    return;
                }
                life--;
                sender.Text = null;
                TextChanger();
                Painting();
            }
        }
        private void Painting()
        {
            Graphics graphicObject;
            graphicObject = panel1.CreateGraphics();
            switch (life)
            {
                case 0:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 115f, 190f, 145f);
                    break;
                case 1:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 115f, 230f, 145f);
                    break;
                case 2:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 155f, 190f, 185f);
                    break;
                case 3:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 155f, 230f, 185f);
                    break;
                case 4:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 105f, 210f, 155f);
                    break;
                case 5:
                    graphicObject.DrawEllipse(new Pen(Color.Black, 2),195f, 75f,30f,30f);
                    break;
                case 6:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 210f, 25f, 210f, 75f);
                    break;
                case 7:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 150.5f, 25f, 210f, 25f);
                    break;
                case 8:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 150.5f, 275f, 150.5f, 25f);
                    break;
                case 9:
                    graphicObject.DrawLine(new Pen(Color.Black, 2), 25f, 275f, 275f, 275f);
                    break;
                case 10:
                    graphicObject.Clear(panel1.BackColor);
                    break;

            }
            

        }
        private void TextChanger()
        {
            PointLbl.Text = "Punkty : " + points + "\n" +
                            "Zycia: " + life;
        }
    }
}
