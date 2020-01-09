namespace ProjektPZ_Chrzanowski_Mozer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.grafButton = new System.Windows.Forms.Button();
            this.sciezkaButton = new System.Windows.Forms.Button();
            this.liczbaWierzcholkow = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wierzcholkiButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slowA = new System.Windows.Forms.Button();
            this.mediumA = new System.Windows.Forms.Button();
            this.fastA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.czasLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaWierzcholkow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafButton
            // 
            this.grafButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grafButton.Location = new System.Drawing.Point(152, 31);
            this.grafButton.Name = "grafButton";
            this.grafButton.Size = new System.Drawing.Size(114, 23);
            this.grafButton.TabIndex = 0;
            this.grafButton.Text = "Rysuj Graf";
            this.grafButton.UseVisualStyleBackColor = false;
            // 
            // sciezkaButton
            // 
            this.sciezkaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sciezkaButton.Location = new System.Drawing.Point(152, 60);
            this.sciezkaButton.Name = "sciezkaButton";
            this.sciezkaButton.Size = new System.Drawing.Size(114, 23);
            this.sciezkaButton.TabIndex = 1;
            this.sciezkaButton.Text = "Rysuj Ścieżkę";
            this.sciezkaButton.UseVisualStyleBackColor = false;
            // 
            // liczbaWierzcholkow
            // 
            this.liczbaWierzcholkow.LargeChange = 100;
            this.liczbaWierzcholkow.Location = new System.Drawing.Point(9, 25);
            this.liczbaWierzcholkow.Maximum = 3000;
            this.liczbaWierzcholkow.Minimum = 1000;
            this.liczbaWierzcholkow.Name = "liczbaWierzcholkow";
            this.liczbaWierzcholkow.Size = new System.Drawing.Size(90, 45);
            this.liczbaWierzcholkow.SmallChange = 100;
            this.liczbaWierzcholkow.TabIndex = 100;
            this.liczbaWierzcholkow.TickFrequency = 100;
            this.liczbaWierzcholkow.Value = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Liczba wierzchołków";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "3000";
            // 
            // wierzcholkiButton
            // 
            this.wierzcholkiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wierzcholkiButton.Location = new System.Drawing.Point(152, 4);
            this.wierzcholkiButton.Name = "wierzcholkiButton";
            this.wierzcholkiButton.Size = new System.Drawing.Size(114, 23);
            this.wierzcholkiButton.TabIndex = 104;
            this.wierzcholkiButton.Text = "Generuj wierzcholki";
            this.wierzcholkiButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(591, 28);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(61, 28);
            this.resetButton.TabIndex = 105;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.wierzcholkiButton);
            this.panel1.Controls.Add(this.grafButton);
            this.panel1.Controls.Add(this.sciezkaButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.liczbaWierzcholkow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 91);
            this.panel1.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "3.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(119, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 109;
            this.label7.Text = "PRM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.slowA);
            this.panel2.Controls.Add(this.mediumA);
            this.panel2.Controls.Add(this.fastA);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(287, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 91);
            this.panel2.TabIndex = 109;
            // 
            // slowA
            // 
            this.slowA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.slowA.Location = new System.Drawing.Point(153, 60);
            this.slowA.Name = "slowA";
            this.slowA.Size = new System.Drawing.Size(114, 23);
            this.slowA.TabIndex = 111;
            this.slowA.Text = "Szukaj ";
            this.slowA.UseVisualStyleBackColor = false;
            this.slowA.Click += new System.EventHandler(this.AlgorytmAGwiazdka);
            // 
            // mediumA
            // 
            this.mediumA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mediumA.Location = new System.Drawing.Point(155, 34);
            this.mediumA.Name = "mediumA";
            this.mediumA.Size = new System.Drawing.Size(114, 23);
            this.mediumA.TabIndex = 110;
            this.mediumA.Text = "Szukaj ";
            this.mediumA.UseVisualStyleBackColor = false;
            this.mediumA.Click += new System.EventHandler(this.AlgorytmAGwiazdka);
            // 
            // fastA
            // 
            this.fastA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fastA.Location = new System.Drawing.Point(155, 7);
            this.fastA.Name = "fastA";
            this.fastA.Size = new System.Drawing.Size(114, 23);
            this.fastA.TabIndex = 109;
            this.fastA.Text = "Szukaj ";
            this.fastA.UseVisualStyleBackColor = false;
            this.fastA.Click += new System.EventHandler(this.AlgorytmAGwiazdka);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "3. Wolno (Nakrótsza Trasa)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "2. Średnio (Optymalna Trasa)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "1. Szybko (Dłuższa Trasa)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(283, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 24);
            this.label11.TabIndex = 110;
            this.label11.Text = "Metoda rastrowa -Algorytm A*";
            // 
            // czasLabel
            // 
            this.czasLabel.AutoSize = true;
            this.czasLabel.Location = new System.Drawing.Point(604, 89);
            this.czasLabel.Name = "czasLabel";
            this.czasLabel.Size = new System.Drawing.Size(31, 13);
            this.czasLabel.TabIndex = 1002;
            this.czasLabel.Text = "--:--:--";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(604, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 1003;
            this.label19.Text = "CZAS:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Londyn",
            "Sydney",
            "NY",
            "Gdansk"});
            this.listBox1.Location = new System.Drawing.Point(687, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 56);
            this.listBox1.TabIndex = 1004;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(687, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 1006;
            this.button1.Text = "Wybierz Miasto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(907, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.czasLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.liczbaWierzcholkow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grafButton;
        private System.Windows.Forms.Button sciezkaButton;
        private System.Windows.Forms.TrackBar liczbaWierzcholkow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wierzcholkiButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button fastA;
        private System.Windows.Forms.Button slowA;
        private System.Windows.Forms.Button mediumA;
        private System.Windows.Forms.Label czasLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
    
}

