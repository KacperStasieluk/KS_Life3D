namespace KS_Life3D
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
            this.components = new System.ComponentModel.Container();
            this.przybornik = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonKrok = new System.Windows.Forms.Button();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAnimacja = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRozstaw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownLosowanie = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownUmieraDo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownUmieraOd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrzezywaOd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrzezywaDo = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.symulacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nowyPanel1 = new KS_Life3D.NowyPanel();
            this.przybornik.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLosowanie)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUmieraDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUmieraOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrzezywaOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrzezywaDo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // przybornik
            // 
            this.przybornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.przybornik.Controls.Add(this.groupBox4);
            this.przybornik.Controls.Add(this.groupBox3);
            this.przybornik.Controls.Add(this.groupBox2);
            this.przybornik.Controls.Add(this.groupBox1);
            this.przybornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.przybornik.Location = new System.Drawing.Point(0, 24);
            this.przybornik.Name = "przybornik";
            this.przybornik.Size = new System.Drawing.Size(116, 522);
            this.przybornik.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonKrok);
            this.groupBox4.Controls.Add(this.numericUpDownTimer);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.buttonAnimacja);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 103);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animacja";
            // 
            // buttonKrok
            // 
            this.buttonKrok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKrok.Location = new System.Drawing.Point(9, 74);
            this.buttonKrok.Name = "buttonKrok";
            this.buttonKrok.Size = new System.Drawing.Size(85, 23);
            this.buttonKrok.TabIndex = 15;
            this.buttonKrok.Text = "Jedna Iteracja";
            this.buttonKrok.UseVisualStyleBackColor = true;
            this.buttonKrok.Click += new System.EventHandler(this.buttonKrok_Click);
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Location = new System.Drawing.Point(64, 19);
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownTimer.TabIndex = 9;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimer.ValueChanged += new System.EventHandler(this.numericUpDownTimer_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tick timera:";
            // 
            // buttonAnimacja
            // 
            this.buttonAnimacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnimacja.Location = new System.Drawing.Point(9, 45);
            this.buttonAnimacja.Name = "buttonAnimacja";
            this.buttonAnimacja.Size = new System.Drawing.Size(85, 23);
            this.buttonAnimacja.TabIndex = 0;
            this.buttonAnimacja.Text = "Animuj";
            this.buttonAnimacja.UseVisualStyleBackColor = true;
            this.buttonAnimacja.Click += new System.EventHandler(this.buttonAnimacja_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 47);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Obszar roboczy ma\r\nwymiary 50x50x50.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownZ);
            this.groupBox2.Controls.Add(this.numericUpDownY);
            this.groupBox2.Controls.Add(this.numericUpDownX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonRozstaw);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownLosowanie);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 178);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roztaw ponownie";
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownZ.Location = new System.Drawing.Point(68, 119);
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.ReadOnly = true;
            this.numericUpDownZ.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownZ.TabIndex = 13;
            this.numericUpDownZ.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownY.Location = new System.Drawing.Point(37, 119);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.ReadOnly = true;
            this.numericUpDownY.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownY.TabIndex = 12;
            this.numericUpDownY.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.Location = new System.Drawing.Point(6, 119);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.ReadOnly = true;
            this.numericUpDownX.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownX.TabIndex = 11;
            this.numericUpDownX.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Wymiary obszaru:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "+ 1)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "1  /  (";
            // 
            // buttonRozstaw
            // 
            this.buttonRozstaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRozstaw.Location = new System.Drawing.Point(9, 145);
            this.buttonRozstaw.Name = "buttonRozstaw";
            this.buttonRozstaw.Size = new System.Drawing.Size(85, 23);
            this.buttonRozstaw.TabIndex = 1;
            this.buttonRozstaw.Text = "Rozstaw";
            this.buttonRozstaw.UseVisualStyleBackColor = true;
            this.buttonRozstaw.Click += new System.EventHandler(this.buttonRozstaw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 52);
            this.label6.TabIndex = 0;
            this.label6.Text = "Szansa generacji\r\nżywej komórki w\r\ndanym miejscu\r\nwynosi:";
            // 
            // numericUpDownLosowanie
            // 
            this.numericUpDownLosowanie.Location = new System.Drawing.Point(39, 71);
            this.numericUpDownLosowanie.Name = "numericUpDownLosowanie";
            this.numericUpDownLosowanie.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownLosowanie.TabIndex = 2;
            this.numericUpDownLosowanie.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownLosowanie.ValueChanged += new System.EventHandler(this.numericUpDownLosowanie_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonZatwierdz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownUmieraDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownUmieraOd);
            this.groupBox1.Controls.Add(this.numericUpDownPrzezywaOd);
            this.groupBox1.Controls.Add(this.numericUpDownPrzezywaDo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zasady";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "sąsiadów.";
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZatwierdz.Location = new System.Drawing.Point(9, 140);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(85, 23);
            this.buttonZatwierdz.TabIndex = 7;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "sąsiadów i ożywa,\r\njeśli ma od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "do:";
            // 
            // numericUpDownUmieraDo
            // 
            this.numericUpDownUmieraDo.Location = new System.Drawing.Point(64, 101);
            this.numericUpDownUmieraDo.Name = "numericUpDownUmieraDo";
            this.numericUpDownUmieraDo.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownUmieraDo.TabIndex = 6;
            this.numericUpDownUmieraDo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komórka przeżywa,\r\njeśli żyje i ma od:";
            // 
            // numericUpDownUmieraOd
            // 
            this.numericUpDownUmieraOd.Location = new System.Drawing.Point(9, 101);
            this.numericUpDownUmieraOd.Name = "numericUpDownUmieraOd";
            this.numericUpDownUmieraOd.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownUmieraOd.TabIndex = 5;
            this.numericUpDownUmieraOd.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownPrzezywaOd
            // 
            this.numericUpDownPrzezywaOd.Location = new System.Drawing.Point(9, 49);
            this.numericUpDownPrzezywaOd.Name = "numericUpDownPrzezywaOd";
            this.numericUpDownPrzezywaOd.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownPrzezywaOd.TabIndex = 3;
            this.numericUpDownPrzezywaOd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownPrzezywaDo
            // 
            this.numericUpDownPrzezywaDo.Location = new System.Drawing.Point(64, 49);
            this.numericUpDownPrzezywaDo.Name = "numericUpDownPrzezywaDo";
            this.numericUpDownPrzezywaDo.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownPrzezywaDo.TabIndex = 4;
            this.numericUpDownPrzezywaDo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symulacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // symulacjaToolStripMenuItem
            // 
            this.symulacjaToolStripMenuItem.Name = "symulacjaToolStripMenuItem";
            this.symulacjaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.symulacjaToolStripMenuItem.Text = "Symulacja";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nowyPanel1
            // 
            this.nowyPanel1.BackColor = System.Drawing.Color.Black;
            this.nowyPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowyPanel1.Location = new System.Drawing.Point(116, 24);
            this.nowyPanel1.Name = "nowyPanel1";
            this.nowyPanel1.Size = new System.Drawing.Size(684, 522);
            this.nowyPanel1.TabIndex = 2;
            this.nowyPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.nowyPanel1_Paint);
            this.nowyPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nowyPanel1_MouseDown);
            this.nowyPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nowyPanel1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.nowyPanel1);
            this.Controls.Add(this.przybornik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KS_Life3D";
            this.przybornik.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLosowanie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUmieraDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUmieraOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrzezywaOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrzezywaDo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel przybornik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem symulacjaToolStripMenuItem;
        private NowyPanel nowyPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRozstaw;
        private System.Windows.Forms.NumericUpDown numericUpDownUmieraDo;
        private System.Windows.Forms.NumericUpDown numericUpDownUmieraOd;
        private System.Windows.Forms.NumericUpDown numericUpDownPrzezywaDo;
        private System.Windows.Forms.NumericUpDown numericUpDownPrzezywaOd;
        private System.Windows.Forms.NumericUpDown numericUpDownLosowanie;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAnimacja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonKrok;
    }
}

