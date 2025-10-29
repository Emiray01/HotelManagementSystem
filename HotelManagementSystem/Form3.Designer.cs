namespace HotelManagementSystem
{
    partial class Envanter
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
            this.lstUrun = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kategoricbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.miktarTXT = new System.Windows.Forms.TextBox();
            this.urunadiTXT = new System.Windows.Forms.TextBox();
            this.aciklamaTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünKaldırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.panelurungiris = new System.Windows.Forms.Panel();
            this.ürünGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelurungiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrun
            // 
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(2, 246);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(801, 204);
            this.lstUrun.TabIndex = 0;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // kategoricbx
            // 
            this.kategoricbx.FormattingEnabled = true;
            this.kategoricbx.Location = new System.Drawing.Point(214, 38);
            this.kategoricbx.Name = "kategoricbx";
            this.kategoricbx.Size = new System.Drawing.Size(121, 24);
            this.kategoricbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Kategorisi:";
            // 
            // miktarTXT
            // 
            this.miktarTXT.Location = new System.Drawing.Point(383, 40);
            this.miktarTXT.Name = "miktarTXT";
            this.miktarTXT.Size = new System.Drawing.Size(100, 22);
            this.miktarTXT.TabIndex = 3;
            // 
            // urunadiTXT
            // 
            this.urunadiTXT.Location = new System.Drawing.Point(36, 38);
            this.urunadiTXT.Name = "urunadiTXT";
            this.urunadiTXT.Size = new System.Drawing.Size(100, 22);
            this.urunadiTXT.TabIndex = 3;
            // 
            // aciklamaTXT
            // 
            this.aciklamaTXT.Location = new System.Drawing.Point(519, 40);
            this.aciklamaTXT.Name = "aciklamaTXT";
            this.aciklamaTXT.Size = new System.Drawing.Size(100, 22);
            this.aciklamaTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ürün Girişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünToolStripMenuItem,
            this.sistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünKaldırmaToolStripMenuItem,
            this.ürünGirişiToolStripMenuItem});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // ürünKaldırmaToolStripMenuItem
            // 
            this.ürünKaldırmaToolStripMenuItem.Name = "ürünKaldırmaToolStripMenuItem";
            this.ürünKaldırmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ürünKaldırmaToolStripMenuItem.Text = "Ürün Kaldırma";
            this.ürünKaldırmaToolStripMenuItem.Click += new System.EventHandler(this.ürünKaldırmaToolStripMenuItem_Click);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(653, 6);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(135, 22);
            this.aratxt.TabIndex = 10;
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(572, 6);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 11;
            this.arabtn.Text = "Ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // panelurungiris
            // 
            this.panelurungiris.Controls.Add(this.button2);
            this.panelurungiris.Controls.Add(this.button1);
            this.panelurungiris.Controls.Add(this.kategoricbx);
            this.panelurungiris.Controls.Add(this.label1);
            this.panelurungiris.Controls.Add(this.miktarTXT);
            this.panelurungiris.Controls.Add(this.label4);
            this.panelurungiris.Controls.Add(this.urunadiTXT);
            this.panelurungiris.Controls.Add(this.label3);
            this.panelurungiris.Controls.Add(this.aciklamaTXT);
            this.panelurungiris.Controls.Add(this.label2);
            this.panelurungiris.Location = new System.Drawing.Point(2, 35);
            this.panelurungiris.Name = "panelurungiris";
            this.panelurungiris.Size = new System.Drawing.Size(798, 205);
            this.panelurungiris.TabIndex = 12;
            // 
            // ürünGirişiToolStripMenuItem
            // 
            this.ürünGirişiToolStripMenuItem.Name = "ürünGirişiToolStripMenuItem";
            this.ürünGirişiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ürünGirişiToolStripMenuItem.Text = "Ürün Girişi";
            this.ürünGirişiToolStripMenuItem.Click += new System.EventHandler(this.ürünGirişiToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sistemToolStripMenuItem.Text = "Sistem";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Envanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelurungiris);
            this.Controls.Add(this.arabtn);
            this.Controls.Add(this.aratxt);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Envanter";
            this.Text = "Envanter";
            this.Load += new System.EventHandler(this.Envanter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelurungiris.ResumeLayout(false);
            this.panelurungiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox kategoricbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miktarTXT;
        private System.Windows.Forms.TextBox urunadiTXT;
        private System.Windows.Forms.TextBox aciklamaTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünKaldırmaToolStripMenuItem;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.ToolStripMenuItem ürünGirişiToolStripMenuItem;
        private System.Windows.Forms.Panel panelurungiris;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem sistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}