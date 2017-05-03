namespace PomocnikUcznia
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.cmdZnak = new PomocnikUcznia.Przycisk();
            this.cmdKropka = new PomocnikUcznia.Przycisk();
            this.cmdIloraz = new PomocnikUcznia.Przycisk();
            this.cmdIloczyn = new PomocnikUcznia.Przycisk();
            this.cmdRoznica = new PomocnikUcznia.Przycisk();
            this.cmdSuma = new PomocnikUcznia.Przycisk();
            this.cmd0 = new PomocnikUcznia.Przycisk();
            this.cmd9 = new PomocnikUcznia.Przycisk();
            this.cmd8 = new PomocnikUcznia.Przycisk();
            this.cmd7 = new PomocnikUcznia.Przycisk();
            this.cmd6 = new PomocnikUcznia.Przycisk();
            this.cmd5 = new PomocnikUcznia.Przycisk();
            this.cmd4 = new PomocnikUcznia.Przycisk();
            this.cmd3 = new PomocnikUcznia.Przycisk();
            this.cmd2 = new PomocnikUcznia.Przycisk();
            this.cmd1 = new PomocnikUcznia.Przycisk();
            this.cmdWynik = new PomocnikUcznia.Przycisk();
            this.cmdAnuluj = new PomocnikUcznia.Przycisk();
            this.SuspendLayout();
            // 
            // txtWynik
            // 
            this.txtWynik.BackColor = System.Drawing.Color.White;
            this.txtWynik.Enabled = false;
            this.txtWynik.Location = new System.Drawing.Point(13, 25);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWynik.Size = new System.Drawing.Size(188, 20);
            this.txtWynik.TabIndex = 18;
            this.txtWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdZnak
            // 
            this.cmdZnak.Enabled = false;
            this.cmdZnak.Location = new System.Drawing.Point(85, 233);
            this.cmdZnak.Name = "cmdZnak";
            this.cmdZnak.Size = new System.Drawing.Size(30, 23);
            this.cmdZnak.TabIndex = 17;
            this.cmdZnak.Text = "+/-";
            this.cmdZnak.UseVisualStyleBackColor = true;
            this.cmdZnak.Click += new System.EventHandler(this.cmdZnak_Click);
            // 
            // cmdKropka
            // 
            this.cmdKropka.Location = new System.Drawing.Point(12, 233);
            this.cmdKropka.Name = "cmdKropka";
            this.cmdKropka.Size = new System.Drawing.Size(30, 23);
            this.cmdKropka.TabIndex = 16;
            this.cmdKropka.Text = ",";
            this.cmdKropka.UseVisualStyleBackColor = true;
            this.cmdKropka.Click += new System.EventHandler(this.cmdKropka_Click);
            // 
            // cmdIloraz
            // 
            this.cmdIloraz.Enabled = false;
            this.cmdIloraz.Location = new System.Drawing.Point(171, 233);
            this.cmdIloraz.Name = "cmdIloraz";
            this.cmdIloraz.Size = new System.Drawing.Size(30, 23);
            this.cmdIloraz.TabIndex = 15;
            this.cmdIloraz.Text = "/";
            this.cmdIloraz.UseVisualStyleBackColor = true;
            this.cmdIloraz.Click += new System.EventHandler(this.cmdIloraz_Click);
            // 
            // cmdIloczyn
            // 
            this.cmdIloczyn.Enabled = false;
            this.cmdIloczyn.Location = new System.Drawing.Point(171, 204);
            this.cmdIloczyn.Name = "cmdIloczyn";
            this.cmdIloczyn.Size = new System.Drawing.Size(30, 23);
            this.cmdIloczyn.TabIndex = 14;
            this.cmdIloczyn.Text = "*";
            this.cmdIloczyn.UseVisualStyleBackColor = true;
            this.cmdIloczyn.Click += new System.EventHandler(this.cmdIloczyn_Click);
            // 
            // cmdRoznica
            // 
            this.cmdRoznica.Enabled = false;
            this.cmdRoznica.Location = new System.Drawing.Point(171, 175);
            this.cmdRoznica.Name = "cmdRoznica";
            this.cmdRoznica.Size = new System.Drawing.Size(30, 23);
            this.cmdRoznica.TabIndex = 13;
            this.cmdRoznica.Text = "-";
            this.cmdRoznica.UseVisualStyleBackColor = true;
            this.cmdRoznica.Click += new System.EventHandler(this.cmdRoznica_Click);
            // 
            // cmdSuma
            // 
            this.cmdSuma.Enabled = false;
            this.cmdSuma.Location = new System.Drawing.Point(171, 146);
            this.cmdSuma.Name = "cmdSuma";
            this.cmdSuma.Size = new System.Drawing.Size(30, 23);
            this.cmdSuma.TabIndex = 12;
            this.cmdSuma.Text = "+";
            this.cmdSuma.UseVisualStyleBackColor = true;
            this.cmdSuma.Click += new System.EventHandler(this.cmdSuma_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(49, 233);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(30, 23);
            this.cmd0.TabIndex = 11;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(85, 204);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(30, 23);
            this.cmd9.TabIndex = 10;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(49, 204);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(30, 23);
            this.cmd8.TabIndex = 9;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(13, 204);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(30, 23);
            this.cmd7.TabIndex = 8;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(85, 175);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(30, 23);
            this.cmd6.TabIndex = 7;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(49, 175);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(30, 23);
            this.cmd5.TabIndex = 6;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(13, 175);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(30, 23);
            this.cmd4.TabIndex = 5;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(85, 146);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(30, 23);
            this.cmd3.TabIndex = 4;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(49, 146);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(30, 23);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(13, 146);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(30, 23);
            this.cmd1.TabIndex = 2;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmdWynik
            // 
            this.cmdWynik.Enabled = false;
            this.cmdWynik.Location = new System.Drawing.Point(126, 84);
            this.cmdWynik.Name = "cmdWynik";
            this.cmdWynik.Size = new System.Drawing.Size(75, 23);
            this.cmdWynik.TabIndex = 1;
            this.cmdWynik.Text = "=";
            this.cmdWynik.UseVisualStyleBackColor = true;
            this.cmdWynik.Click += new System.EventHandler(this.cmdWynik_Click);
            // 
            // cmdAnuluj
            // 
            this.cmdAnuluj.Location = new System.Drawing.Point(12, 84);
            this.cmdAnuluj.Name = "cmdAnuluj";
            this.cmdAnuluj.Size = new System.Drawing.Size(75, 23);
            this.cmdAnuluj.TabIndex = 0;
            this.cmdAnuluj.Text = "Anuluj";
            this.cmdAnuluj.UseVisualStyleBackColor = true;
            this.cmdAnuluj.Click += new System.EventHandler(this.cmdAnuluj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 271);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.cmdZnak);
            this.Controls.Add(this.cmdKropka);
            this.Controls.Add(this.cmdIloraz);
            this.Controls.Add(this.cmdIloczyn);
            this.Controls.Add(this.cmdRoznica);
            this.Controls.Add(this.cmdSuma);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmdWynik);
            this.Controls.Add(this.cmdAnuluj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form3_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Przycisk cmdAnuluj;
        private Przycisk cmdWynik;
        private Przycisk cmd1;
        private Przycisk cmd2;
        private Przycisk cmd3;
        private Przycisk cmd4;
        private Przycisk cmd5;
        private Przycisk cmd6;
        private Przycisk cmd7;
        private Przycisk cmd8;
        private Przycisk cmd9;
        private Przycisk cmd0;
        private Przycisk cmdSuma;
        private Przycisk cmdRoznica;
        private Przycisk cmdIloczyn;
        private Przycisk cmdIloraz;
        private Przycisk cmdKropka;
        private Przycisk cmdZnak;
        private System.Windows.Forms.TextBox txtWynik;
    }
}