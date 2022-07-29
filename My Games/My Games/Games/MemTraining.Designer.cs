namespace My_Games.Games
{
    partial class MemTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemTraining));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PktLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.PicImage = new System.Windows.Forms.ImageList(this.components);
            this._Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 277);
            this.panel1.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.ForeColor = System.Drawing.Color.Snow;
            this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartBtn.Location = new System.Drawing.Point(139, 49);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 33);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PktLbl
            // 
            this.PktLbl.AutoSize = true;
            this.PktLbl.BackColor = System.Drawing.Color.Transparent;
            this.PktLbl.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PktLbl.ForeColor = System.Drawing.Color.Snow;
            this.PktLbl.Location = new System.Drawing.Point(220, 53);
            this.PktLbl.Name = "PktLbl";
            this.PktLbl.Size = new System.Drawing.Size(56, 24);
            this.PktLbl.TabIndex = 2;
            this.PktLbl.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(12, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "2";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(139, 6);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(292, 47);
            this.TitleLbl.TabIndex = 3;
            this.TitleLbl.Text = "Ćwiczenie pamięci";
            // 
            // PicImage
            // 
            this.PicImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.PicImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PicImage.ImageStream")));
            this.PicImage.TransparentColor = System.Drawing.Color.Transparent;
            this.PicImage.Images.SetKeyName(0, "bear.png");
            this.PicImage.Images.SetKeyName(1, "burger.png");
            this.PicImage.Images.SetKeyName(2, "car.png");
            this.PicImage.Images.SetKeyName(3, "duck.png");
            this.PicImage.Images.SetKeyName(4, "fox.png");
            this.PicImage.Images.SetKeyName(5, "heart.png");
            this.PicImage.Images.SetKeyName(6, "moon.png");
            this.PicImage.Images.SetKeyName(7, "rocket.png");
            this.PicImage.Images.SetKeyName(8, "Rose.png");
            this.PicImage.Images.SetKeyName(9, "satellite.png");
            this.PicImage.Images.SetKeyName(10, "telescope.png");
            this.PicImage.Images.SetKeyName(11, "waterfall.png");
            // 
            // _Timer
            // 
            this._Timer.Enabled = true;
            this._Timer.Tick += new System.EventHandler(this._Timer_Tick);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.TimeLbl.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLbl.ForeColor = System.Drawing.Color.Snow;
            this.TimeLbl.Location = new System.Drawing.Point(12, 20);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(0, 24);
            this.TimeLbl.TabIndex = 4;
            // 
            // MemTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.BackgroundImage = global::My_Games.Properties.Resources.texture_background1;
            this.ClientSize = new System.Drawing.Size(459, 371);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PktLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(475, 410);
            this.Name = "MemTraining";
            this.Text = "MemTrain";
            this.Load += new System.EventHandler(this.MTLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button StartBtn;
        private Label PktLbl;
        private ComboBox comboBox1;
        private Label TitleLbl;
        private ImageList PicImage;
        private System.Windows.Forms.Timer _Timer;
        private Label TimeLbl;
    }
}