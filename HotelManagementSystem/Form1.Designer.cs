namespace HotelManagementSystem
{
    partial class formGiris
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
            this.girisPbtn = new System.Windows.Forms.Button();
            this.Pid_txt = new System.Windows.Forms.TextBox();
            this.Psifre_txt = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Mid_txt = new System.Windows.Forms.TextBox();
            this.girisMbtn = new System.Windows.Forms.Button();
            this.Msifre_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelpersonel = new System.Windows.Forms.Panel();
            this.btngeri2 = new System.Windows.Forms.Button();
            this.panelmusteri = new System.Windows.Forms.Panel();
            this.btngeri1 = new System.Windows.Forms.Button();
            this.sifgoster = new System.Windows.Forms.Button();
            this.sifgizle = new System.Windows.Forms.Button();
            this.sifgoster1 = new System.Windows.Forms.Button();
            this.sifgizle1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelpersonel.SuspendLayout();
            this.panelmusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisPbtn
            // 
            this.girisPbtn.Location = new System.Drawing.Point(33, 214);
            this.girisPbtn.Name = "girisPbtn";
            this.girisPbtn.Size = new System.Drawing.Size(75, 23);
            this.girisPbtn.TabIndex = 0;
            this.girisPbtn.Text = "Giriş";
            this.girisPbtn.UseVisualStyleBackColor = true;
            this.girisPbtn.Click += new System.EventHandler(this.girisPbtn_Click);
            // 
            // Pid_txt
            // 
            this.Pid_txt.Location = new System.Drawing.Point(33, 34);
            this.Pid_txt.Name = "Pid_txt";
            this.Pid_txt.Size = new System.Drawing.Size(100, 22);
            this.Pid_txt.TabIndex = 2;
            this.Pid_txt.Tag = "";
            this.Pid_txt.Text = "05";
            // 
            // Psifre_txt
            // 
            this.Psifre_txt.Location = new System.Drawing.Point(33, 73);
            this.Psifre_txt.Name = "Psifre_txt";
            this.Psifre_txt.PasswordChar = '*';
            this.Psifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Psifre_txt.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(36, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 16);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Telefon:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 62);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Şifre";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 19);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 16);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Müşteri ID:";
            // 
            // Mid_txt
            // 
            this.Mid_txt.Location = new System.Drawing.Point(12, 37);
            this.Mid_txt.Name = "Mid_txt";
            this.Mid_txt.Size = new System.Drawing.Size(100, 22);
            this.Mid_txt.TabIndex = 2;
            // 
            // girisMbtn
            // 
            this.girisMbtn.Location = new System.Drawing.Point(12, 217);
            this.girisMbtn.Name = "girisMbtn";
            this.girisMbtn.Size = new System.Drawing.Size(75, 23);
            this.girisMbtn.TabIndex = 0;
            this.girisMbtn.Text = "Giriş";
            this.girisMbtn.UseVisualStyleBackColor = true;
            this.girisMbtn.Click += new System.EventHandler(this.girisMbtn_Click);
            // 
            // Msifre_txt
            // 
            this.Msifre_txt.Location = new System.Drawing.Point(12, 76);
            this.Msifre_txt.Name = "Msifre_txt";
            this.Msifre_txt.PasswordChar = '*';
            this.Msifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Msifre_txt.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriGirişiToolStripMenuItem,
            this.personelGirişiToolStripMenuItem});
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.girişToolStripMenuItem.Text = "Giriş";
            // 
            // müşteriGirişiToolStripMenuItem
            // 
            this.müşteriGirişiToolStripMenuItem.Name = "müşteriGirişiToolStripMenuItem";
            this.müşteriGirişiToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.müşteriGirişiToolStripMenuItem.Text = "Müşteri Girişi";
            this.müşteriGirişiToolStripMenuItem.Click += new System.EventHandler(this.müşteriGirişiToolStripMenuItem_Click);
            // 
            // personelGirişiToolStripMenuItem
            // 
            this.personelGirişiToolStripMenuItem.Name = "personelGirişiToolStripMenuItem";
            this.personelGirişiToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.personelGirişiToolStripMenuItem.Text = "Personel Girişi";
            this.personelGirişiToolStripMenuItem.Click += new System.EventHandler(this.personelGirişiToolStripMenuItem_Click);
            // 
            // panelpersonel
            // 
            this.panelpersonel.Controls.Add(this.sifgizle);
            this.panelpersonel.Controls.Add(this.sifgoster);
            this.panelpersonel.Controls.Add(this.btngeri2);
            this.panelpersonel.Controls.Add(this.Label2);
            this.panelpersonel.Controls.Add(this.label1);
            this.panelpersonel.Controls.Add(this.Psifre_txt);
            this.panelpersonel.Controls.Add(this.Pid_txt);
            this.panelpersonel.Controls.Add(this.girisPbtn);
            this.panelpersonel.Location = new System.Drawing.Point(0, 33);
            this.panelpersonel.Name = "panelpersonel";
            this.panelpersonel.Size = new System.Drawing.Size(788, 420);
            this.panelpersonel.TabIndex = 9;
            // 
            // btngeri2
            // 
            this.btngeri2.Location = new System.Drawing.Point(12, 384);
            this.btngeri2.Name = "btngeri2";
            this.btngeri2.Size = new System.Drawing.Size(21, 23);
            this.btngeri2.TabIndex = 10;
            this.btngeri2.Text = "←";
            this.btngeri2.UseVisualStyleBackColor = true;
            this.btngeri2.Click += new System.EventHandler(this.btngeri2_Click);
            // 
            // panelmusteri
            // 
            this.panelmusteri.Controls.Add(this.sifgizle1);
            this.panelmusteri.Controls.Add(this.sifgoster1);
            this.panelmusteri.Controls.Add(this.btngeri1);
            this.panelmusteri.Controls.Add(this.Label4);
            this.panelmusteri.Controls.Add(this.Label3);
            this.panelmusteri.Controls.Add(this.Mid_txt);
            this.panelmusteri.Controls.Add(this.Msifre_txt);
            this.panelmusteri.Controls.Add(this.girisMbtn);
            this.panelmusteri.Location = new System.Drawing.Point(18, 31);
            this.panelmusteri.Name = "panelmusteri";
            this.panelmusteri.Size = new System.Drawing.Size(800, 421);
            this.panelmusteri.TabIndex = 10;
            // 
            // btngeri1
            // 
            this.btngeri1.Location = new System.Drawing.Point(12, 384);
            this.btngeri1.Name = "btngeri1";
            this.btngeri1.Size = new System.Drawing.Size(21, 23);
            this.btngeri1.TabIndex = 9;
            this.btngeri1.Text = "←";
            this.btngeri1.UseVisualStyleBackColor = true;
            this.btngeri1.Click += new System.EventHandler(this.btngeri1_Click);
            // 
            // sifgoster
            // 
            this.sifgoster.Location = new System.Drawing.Point(140, 71);
            this.sifgoster.Name = "sifgoster";
            this.sifgoster.Size = new System.Drawing.Size(21, 23);
            this.sifgoster.TabIndex = 11;
            this.sifgoster.Text = "*";
            this.sifgoster.UseVisualStyleBackColor = true;
            this.sifgoster.Click += new System.EventHandler(this.sifgoster_Click);
            // 
            // sifgizle
            // 
            this.sifgizle.Location = new System.Drawing.Point(140, 73);
            this.sifgizle.Name = "sifgizle";
            this.sifgizle.Size = new System.Drawing.Size(21, 23);
            this.sifgizle.TabIndex = 12;
            this.sifgizle.Text = "*";
            this.sifgizle.UseVisualStyleBackColor = true;
            this.sifgizle.Click += new System.EventHandler(this.sifgizle_Click);
            // 
            // sifgoster1
            // 
            this.sifgoster1.Location = new System.Drawing.Point(122, 75);
            this.sifgoster1.Name = "sifgoster1";
            this.sifgoster1.Size = new System.Drawing.Size(21, 23);
            this.sifgoster1.TabIndex = 10;
            this.sifgoster1.Text = "*";
            this.sifgoster1.UseVisualStyleBackColor = true;
            this.sifgoster1.Click += new System.EventHandler(this.sifgoster1_Click);
            // 
            // sifgizle1
            // 
            this.sifgizle1.Location = new System.Drawing.Point(122, 76);
            this.sifgizle1.Name = "sifgizle1";
            this.sifgizle1.Size = new System.Drawing.Size(21, 23);
            this.sifgizle1.TabIndex = 11;
            this.sifgizle1.Text = "*";
            this.sifgizle1.UseVisualStyleBackColor = true;
            this.sifgizle1.Click += new System.EventHandler(this.sifgizle1_Click);
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpersonel);
            this.Controls.Add(this.panelmusteri);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.formGiris_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelpersonel.ResumeLayout(false);
            this.panelpersonel.PerformLayout();
            this.panelmusteri.ResumeLayout(false);
            this.panelmusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisPbtn;
        private System.Windows.Forms.TextBox Pid_txt;
        private System.Windows.Forms.TextBox Psifre_txt;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox Mid_txt;
        private System.Windows.Forms.Button girisMbtn;
        private System.Windows.Forms.TextBox Msifre_txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişiToolStripMenuItem;
        private System.Windows.Forms.Panel panelpersonel;
        private System.Windows.Forms.Button btngeri2;
        private System.Windows.Forms.Panel panelmusteri;
        private System.Windows.Forms.Button btngeri1;
        private System.Windows.Forms.Button sifgoster;
        private System.Windows.Forms.Button sifgizle;
        private System.Windows.Forms.Button sifgoster1;
        private System.Windows.Forms.Button sifgizle1;
    }
}

