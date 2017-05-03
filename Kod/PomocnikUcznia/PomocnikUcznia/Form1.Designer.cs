namespace PomocnikUcznia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planLekcjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wprowadźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uruchomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uruchomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPlan = new System.Windows.Forms.Label();
            this.labelLekcje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planLekcjiToolStripMenuItem,
            this.kalkulatorToolStripMenuItem,
            this.notatnikToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planLekcjiToolStripMenuItem
            // 
            this.planLekcjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wprowadźToolStripMenuItem,
            this.pokażToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.planLekcjiToolStripMenuItem.Name = "planLekcjiToolStripMenuItem";
            this.planLekcjiToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.planLekcjiToolStripMenuItem.Text = "Plan lekcji";
            // 
            // wprowadźToolStripMenuItem
            // 
            this.wprowadźToolStripMenuItem.Name = "wprowadźToolStripMenuItem";
            this.wprowadźToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wprowadźToolStripMenuItem.Text = "Wprowadź";
            this.wprowadźToolStripMenuItem.Click += new System.EventHandler(this.wprowadźToolStripMenuItem_Click);
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pokażToolStripMenuItem.Text = "Podpowiedz";
            this.pokażToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uruchomToolStripMenuItem});
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            // 
            // uruchomToolStripMenuItem
            // 
            this.uruchomToolStripMenuItem.Name = "uruchomToolStripMenuItem";
            this.uruchomToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.uruchomToolStripMenuItem.Text = "Uruchom";
            this.uruchomToolStripMenuItem.Click += new System.EventHandler(this.uruchomToolStripMenuItem_Click);
            // 
            // notatnikToolStripMenuItem
            // 
            this.notatnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uruchomToolStripMenuItem1});
            this.notatnikToolStripMenuItem.Name = "notatnikToolStripMenuItem";
            this.notatnikToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.notatnikToolStripMenuItem.Text = "Notatnik";
            // 
            // uruchomToolStripMenuItem1
            // 
            this.uruchomToolStripMenuItem1.Name = "uruchomToolStripMenuItem1";
            this.uruchomToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.uruchomToolStripMenuItem1.Text = "Uruchom";
            this.uruchomToolStripMenuItem1.Click += new System.EventHandler(this.uruchomToolStripMenuItem1_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.aboutClick);
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlan.ForeColor = System.Drawing.Color.Red;
            this.labelPlan.Location = new System.Drawing.Point(203, 67);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(126, 15);
            this.labelPlan.TabIndex = 1;
            this.labelPlan.Text = "Plan Lekcji na najbliższy ";
            this.labelPlan.Visible = false;
            this.labelPlan.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLekcje
            // 
            this.labelLekcje.AutoSize = true;
            this.labelLekcje.Location = new System.Drawing.Point(143, 96);
            this.labelLekcje.Name = "labelLekcje";
            this.labelLekcje.Size = new System.Drawing.Size(39, 13);
            this.labelLekcje.TabIndex = 2;
            this.labelLekcje.Text = "Lekcje";
            this.labelLekcje.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "4. ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "5. ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "6. ";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "7. ";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "8. ";
            this.label8.Visible = false;
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Location = new System.Drawing.Point(323, 96);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(112, 13);
            this.labelGodzina.TabIndex = 4;
            this.labelGodzina.Text = "Godzina rozpoczęcia: ";
            this.labelGodzina.Visible = false;
            this.labelGodzina.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ukryj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGodzina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLekcje);
            this.Controls.Add(this.labelPlan);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomocnik Ucznia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planLekcjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wprowadźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uruchomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uruchomToolStripMenuItem1;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelLekcje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.Button button1;
    }
}

