namespace My_Games.Games
{
    partial class Wisielec
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.CheckedListBox();
            this.PointLbl = new System.Windows.Forms.Label();
            this.HardModeCheck = new System.Windows.Forms.CheckBox();
            this.EasyBox = new System.Windows.Forms.TextBox();
            this.EasyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wisielec";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 1;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.BackColor = System.Drawing.Color.Lime;
            this.NewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGameBtn.Location = new System.Drawing.Point(12, 290);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(214, 27);
            this.NewGameBtn.TabIndex = 4;
            this.NewGameBtn.Text = "Nowa gra";
            this.NewGameBtn.UseVisualStyleBackColor = false;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLbl.Location = new System.Drawing.Point(12, 9);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(71, 17);
            this.CategoryLbl.TabIndex = 5;
            this.CategoryLbl.Text = "Kategorie:";
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(12, 34);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(214, 166);
            this.CategoryBox.TabIndex = 6;
            // 
            // PointLbl
            // 
            this.PointLbl.AutoSize = true;
            this.PointLbl.Location = new System.Drawing.Point(12, 230);
            this.PointLbl.Name = "PointLbl";
            this.PointLbl.Size = new System.Drawing.Size(0, 15);
            this.PointLbl.TabIndex = 7;
            // 
            // HardModeCheck
            // 
            this.HardModeCheck.AutoSize = true;
            this.HardModeCheck.Location = new System.Drawing.Point(374, 10);
            this.HardModeCheck.Name = "HardModeCheck";
            this.HardModeCheck.Size = new System.Drawing.Size(86, 19);
            this.HardModeCheck.TabIndex = 8;
            this.HardModeCheck.TabStop = false;
            this.HardModeCheck.Text = "Hard Mode";
            this.HardModeCheck.UseVisualStyleBackColor = true;
            // 
            // EasyBox
            // 
            this.EasyBox.Location = new System.Drawing.Point(189, 401);
            this.EasyBox.MaxLength = 1;
            this.EasyBox.Name = "EasyBox";
            this.EasyBox.Size = new System.Drawing.Size(37, 23);
            this.EasyBox.TabIndex = 9;
            this.EasyBox.Visible = false;
            // 
            // EasyBtn
            // 
            this.EasyBtn.Location = new System.Drawing.Point(232, 400);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(75, 23);
            this.EasyBtn.TabIndex = 10;
            this.EasyBtn.Text = "Sprawdź";
            this.EasyBtn.UseVisualStyleBackColor = true;
            this.EasyBtn.Visible = false;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // Wisielec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 436);
            this.Controls.Add(this.EasyBtn);
            this.Controls.Add(this.EasyBox);
            this.Controls.Add(this.HardModeCheck);
            this.Controls.Add(this.PointLbl);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(560, 425);
            this.Name = "Wisielec";
            this.Text = "Wisielec";
            this.Load += new System.EventHandler(this.Wisielec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button NewGameBtn;
        private Label CategoryLbl;
        private CheckedListBox CategoryBox;
        private Label PointLbl;
        private CheckBox HardModeCheck;
        private TextBox EasyBox;
        private Button EasyBtn;
    }
}