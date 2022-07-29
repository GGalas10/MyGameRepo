namespace My_Games.Games
{
    partial class KPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KPN));
            this.POneBox = new System.Windows.Forms.PictureBox();
            this.PcPlayerBox = new System.Windows.Forms.PictureBox();
            this.POneLbl = new System.Windows.Forms.Label();
            this.PcPlayerLbl = new System.Windows.Forms.Label();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DrawLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.POneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            this.SuspendLayout();
            // 
            // POneBox
            // 
            this.POneBox.BackColor = System.Drawing.Color.Transparent;
            this.POneBox.Location = new System.Drawing.Point(24, 70);
            this.POneBox.Name = "POneBox";
            this.POneBox.Size = new System.Drawing.Size(64, 64);
            this.POneBox.TabIndex = 1;
            this.POneBox.TabStop = false;
            // 
            // PcPlayerBox
            // 
            this.PcPlayerBox.BackColor = System.Drawing.Color.Transparent;
            this.PcPlayerBox.Location = new System.Drawing.Point(202, 70);
            this.PcPlayerBox.Name = "PcPlayerBox";
            this.PcPlayerBox.Size = new System.Drawing.Size(64, 64);
            this.PcPlayerBox.TabIndex = 2;
            this.PcPlayerBox.TabStop = false;
            // 
            // POneLbl
            // 
            this.POneLbl.AutoSize = true;
            this.POneLbl.BackColor = System.Drawing.Color.Transparent;
            this.POneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.POneLbl.ForeColor = System.Drawing.Color.White;
            this.POneLbl.Location = new System.Drawing.Point(24, 13);
            this.POneLbl.Name = "POneLbl";
            this.POneLbl.Size = new System.Drawing.Size(54, 42);
            this.POneLbl.TabIndex = 3;
            this.POneLbl.Text = "Gracz \r\nPkt:";
            // 
            // PcPlayerLbl
            // 
            this.PcPlayerLbl.AutoSize = true;
            this.PcPlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.PcPlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PcPlayerLbl.ForeColor = System.Drawing.Color.White;
            this.PcPlayerLbl.Location = new System.Drawing.Point(202, 13);
            this.PcPlayerLbl.Name = "PcPlayerLbl";
            this.PcPlayerLbl.Size = new System.Drawing.Size(40, 40);
            this.PcPlayerLbl.TabIndex = 4;
            this.PcPlayerLbl.Text = "PC\r\nPkt:";
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.White;
            this.Paper.Image = global::My_Games.Properties.Resources.hand;
            this.Paper.Location = new System.Drawing.Point(24, 156);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(64, 68);
            this.Paper.TabIndex = 5;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.Click);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.White;
            this.Rock.Image = global::My_Games.Properties.Resources.rock;
            this.Rock.Location = new System.Drawing.Point(114, 156);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(64, 68);
            this.Rock.TabIndex = 6;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Click);
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.White;
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(202, 156);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(64, 68);
            this.Scissors.TabIndex = 7;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hand.png");
            this.imageList1.Images.SetKeyName(1, "rock.png");
            this.imageList1.Images.SetKeyName(2, "scissors.png");
            // 
            // DrawLbl
            // 
            this.DrawLbl.AutoSize = true;
            this.DrawLbl.BackColor = System.Drawing.Color.Transparent;
            this.DrawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DrawLbl.ForeColor = System.Drawing.Color.White;
            this.DrawLbl.Location = new System.Drawing.Point(114, 92);
            this.DrawLbl.Name = "DrawLbl";
            this.DrawLbl.Size = new System.Drawing.Size(59, 20);
            this.DrawLbl.TabIndex = 8;
            this.DrawLbl.Text = "Remis";
            this.DrawLbl.Visible = false;
            // 
            // KPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Games.Properties.Resources.samy_saadi_fFC7IOFT_OM_unsplash;
            this.ClientSize = new System.Drawing.Size(354, 249);
            this.Controls.Add(this.DrawLbl);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.PcPlayerLbl);
            this.Controls.Add(this.POneLbl);
            this.Controls.Add(this.PcPlayerBox);
            this.Controls.Add(this.POneBox);
            this.Name = "KPN";
            this.Text = "KPN";
            ((System.ComponentModel.ISupportInitialize)(this.POneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox POneBox;
        private PictureBox PcPlayerBox;
        private Label POneLbl;
        private Label PcPlayerLbl;
        private PictureBox Paper;
        private PictureBox Rock;
        private PictureBox Scissors;
        private ImageList imageList1;
        private Label DrawLbl;
    }
}