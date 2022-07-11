namespace My_Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemoryBtn = new System.Windows.Forms.Button();
            this.KiKBtn = new System.Windows.Forms.Button();
            this.WisielecBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(180, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(65, 22);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemoryBtn);
            this.panel1.Controls.Add(this.KiKBtn);
            this.panel1.Controls.Add(this.WisielecBtn);
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 417);
            this.panel1.TabIndex = 1;
            // 
            // MemoryBtn
            // 
            this.MemoryBtn.Location = new System.Drawing.Point(9, 82);
            this.MemoryBtn.Name = "MemoryBtn";
            this.MemoryBtn.Size = new System.Drawing.Size(97, 48);
            this.MemoryBtn.TabIndex = 2;
            this.MemoryBtn.Text = "Ćwiczenie pamięci";
            this.MemoryBtn.UseVisualStyleBackColor = true;
            // 
            // KiKBtn
            // 
            this.KiKBtn.Location = new System.Drawing.Point(9, 32);
            this.KiKBtn.Name = "KiKBtn";
            this.KiKBtn.Size = new System.Drawing.Size(97, 44);
            this.KiKBtn.TabIndex = 1;
            this.KiKBtn.Text = "Kółko i krzyżyk 2 graczy";
            this.KiKBtn.UseVisualStyleBackColor = true;
            // 
            // WisielecBtn
            // 
            this.WisielecBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.WisielecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WisielecBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WisielecBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WisielecBtn.Location = new System.Drawing.Point(9, 3);
            this.WisielecBtn.Name = "WisielecBtn";
            this.WisielecBtn.Size = new System.Drawing.Size(97, 23);
            this.WisielecBtn.TabIndex = 0;
            this.WisielecBtn.Text = "Wisielec";
            this.WisielecBtn.UseVisualStyleBackColor = false;
            this.WisielecBtn.Click += new System.EventHandler(this.WisielecBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLbl);
            this.MinimumSize = new System.Drawing.Size(480, 600);
            this.Name = "Form1";
            this.Text = "Game by Grzegorz Galas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private Panel panel1;
        private Button WisielecBtn;
        private Button KiKBtn;
        private Button MemoryBtn;
    }
}