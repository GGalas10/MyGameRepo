namespace My_Games.Games
{
    partial class KiK
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
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoundLbl = new System.Windows.Forms.Label();
            this.PktLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(12, 12);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
            this.NewGameBtn.TabIndex = 10;
            this.NewGameBtn.Text = "Nowa Gra";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(93, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 350);
            this.panel1.TabIndex = 11;
            // 
            // RoundLbl
            // 
            this.RoundLbl.AutoSize = true;
            this.RoundLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLbl.Location = new System.Drawing.Point(211, 13);
            this.RoundLbl.Name = "RoundLbl";
            this.RoundLbl.Size = new System.Drawing.Size(0, 22);
            this.RoundLbl.TabIndex = 12;
            // 
            // PktLbl
            // 
            this.PktLbl.AutoSize = true;
            this.PktLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PktLbl.Location = new System.Drawing.Point(12, 420);
            this.PktLbl.Name = "PktLbl";
            this.PktLbl.Size = new System.Drawing.Size(0, 22);
            this.PktLbl.TabIndex = 13;
            // 
            // KiK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 451);
            this.Controls.Add(this.PktLbl);
            this.Controls.Add(this.RoundLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewGameBtn);
            this.MinimumSize = new System.Drawing.Size(530, 490);
            this.Name = "KiK";
            this.Text = "Kółko i krzyżyk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NewGameBtn;
        private Panel panel1;
        private Label RoundLbl;
        private Label PktLbl;
    }
}