namespace HotelManagementSystem
{
    partial class OnBuroform
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
            this.lstOdaliste = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gtarih = new System.Windows.Forms.DateTimePicker();
            this.ctarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChin = new System.Windows.Forms.Button();
            this.btnChout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaYazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediBankaKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nakitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOdaliste
            // 
            this.lstOdaliste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstOdaliste.FullRowSelect = true;
            this.lstOdaliste.HideSelection = false;
            this.lstOdaliste.Location = new System.Drawing.Point(0, 211);
            this.lstOdaliste.Name = "lstOdaliste";
            this.lstOdaliste.Size = new System.Drawing.Size(800, 239);
            this.lstOdaliste.TabIndex = 0;
            this.lstOdaliste.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(10, 53);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(121, 22);
            this.txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(10, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 22);
            this.txtsoyad.TabIndex = 2;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(10, 141);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(121, 22);
            this.txttc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad:";
            // 
            // gtarih
            // 
            this.gtarih.Location = new System.Drawing.Point(286, 47);
            this.gtarih.Name = "gtarih";
            this.gtarih.Size = new System.Drawing.Size(200, 22);
            this.gtarih.TabIndex = 6;
            // 
            // ctarih
            // 
            this.ctarih.Location = new System.Drawing.Point(286, 91);
            this.ctarih.Name = "ctarih";
            this.ctarih.Size = new System.Drawing.Size(200, 22);
            this.ctarih.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC Kimlik NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giriş Tarihi:";
            // 
            // btnChin
            // 
            this.btnChin.Location = new System.Drawing.Point(531, 173);
            this.btnChin.Name = "btnChin";
            this.btnChin.Size = new System.Drawing.Size(101, 23);
            this.btnChin.TabIndex = 11;
            this.btnChin.Text = "Check-in";
            this.btnChin.UseVisualStyleBackColor = true;
            this.btnChin.Click += new System.EventHandler(this.btnChin_Click);
            // 
            // btnChout
            // 
            this.btnChout.Location = new System.Drawing.Point(670, 173);
            this.btnChout.Name = "btnChout";
            this.btnChout.Size = new System.Drawing.Size(101, 23);
            this.btnChout.TabIndex = 12;
            this.btnChout.Text = "Check-out";
            this.btnChout.UseVisualStyleBackColor = true;
            this.btnChout.Click += new System.EventHandler(this.btnChout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaYazdırToolStripMenuItem,
            this.ödemeToolStripMenuItem});
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // faturaYazdırToolStripMenuItem
            // 
            this.faturaYazdırToolStripMenuItem.Name = "faturaYazdırToolStripMenuItem";
            this.faturaYazdırToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.faturaYazdırToolStripMenuItem.Text = "Fatura Yazdır";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krediBankaKartıToolStripMenuItem,
            this.nakitToolStripMenuItem});
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            // 
            // krediBankaKartıToolStripMenuItem
            // 
            this.krediBankaKartıToolStripMenuItem.Name = "krediBankaKartıToolStripMenuItem";
            this.krediBankaKartıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.krediBankaKartıToolStripMenuItem.Text = "Kredi/Banka kartı";
            this.krediBankaKartıToolStripMenuItem.Click += new System.EventHandler(this.krediBankaKartıToolStripMenuItem_Click);
            // 
            // nakitToolStripMenuItem
            // 
            this.nakitToolStripMenuItem.Name = "nakitToolStripMenuItem";
            this.nakitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nakitToolStripMenuItem.Text = "Nakit";
            // 
            // OnBuroform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChout);
            this.Controls.Add(this.btnChin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctarih);
            this.Controls.Add(this.gtarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lstOdaliste);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OnBuroform";
            this.Text = "Ön Büro";
            this.Load += new System.EventHandler(this.OnBuroform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOdaliste;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker gtarih;
        private System.Windows.Forms.DateTimePicker ctarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChin;
        private System.Windows.Forms.Button btnChout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaYazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediBankaKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nakitToolStripMenuItem;
    }
}