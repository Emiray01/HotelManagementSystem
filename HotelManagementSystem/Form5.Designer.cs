namespace HotelManagementSystem
{
    partial class MusteriForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizlikDeğişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparispnl = new System.Windows.Forms.Panel();
            this.geri1btn = new System.Windows.Forms.Button();
            this.fiyatlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.siparisgbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sepetlst = new System.Windows.Forms.ListView();
            this.gondersipbtn = new System.Windows.Forms.Button();
            this.Urunlst = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsiparis = new System.Windows.Forms.ComboBox();
            this.istpnl = new System.Windows.Forms.Panel();
            this.istgbtn = new System.Windows.Forms.Button();
            this.geri2btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hizmetlst = new System.Windows.Forms.ListView();
            this.cmbistek = new System.Windows.Forms.ComboBox();
            this.glabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.siparispnl.SuspendLayout();
            this.istpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.sisteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1786, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem,
            this.temizlikDeğişimToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // temizlikDeğişimToolStripMenuItem
            // 
            this.temizlikDeğişimToolStripMenuItem.Name = "temizlikDeğişimToolStripMenuItem";
            this.temizlikDeğişimToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.temizlikDeğişimToolStripMenuItem.Text = "Temizlik&Değişim";
            this.temizlikDeğişimToolStripMenuItem.Click += new System.EventHandler(this.temizlikDeğişimToolStripMenuItem_Click);
            // 
            // sisteToolStripMenuItem
            // 
            this.sisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.sisteToolStripMenuItem.Name = "sisteToolStripMenuItem";
            this.sisteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sisteToolStripMenuItem.Text = "Sistem";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // siparispnl
            // 
            this.siparispnl.Controls.Add(this.geri1btn);
            this.siparispnl.Controls.Add(this.fiyatlbl);
            this.siparispnl.Controls.Add(this.label4);
            this.siparispnl.Controls.Add(this.siparisgbtn);
            this.siparispnl.Controls.Add(this.label3);
            this.siparispnl.Controls.Add(this.sepetlst);
            this.siparispnl.Controls.Add(this.gondersipbtn);
            this.siparispnl.Controls.Add(this.Urunlst);
            this.siparispnl.Controls.Add(this.label1);
            this.siparispnl.Controls.Add(this.cmbsiparis);
            this.siparispnl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siparispnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparispnl.Location = new System.Drawing.Point(0, 30);
            this.siparispnl.Name = "siparispnl";
            this.siparispnl.Size = new System.Drawing.Size(1786, 721);
            this.siparispnl.TabIndex = 1;
            // 
            // geri1btn
            // 
            this.geri1btn.Location = new System.Drawing.Point(3, 319);
            this.geri1btn.Name = "geri1btn";
            this.geri1btn.Size = new System.Drawing.Size(25, 23);
            this.geri1btn.TabIndex = 9;
            this.geri1btn.Text = "←";
            this.geri1btn.UseVisualStyleBackColor = true;
            this.geri1btn.Click += new System.EventHandler(this.geri1btn_Click);
            // 
            // fiyatlbl
            // 
            this.fiyatlbl.AutoSize = true;
            this.fiyatlbl.Location = new System.Drawing.Point(1112, 494);
            this.fiyatlbl.Name = "fiyatlbl";
            this.fiyatlbl.Size = new System.Drawing.Size(14, 16);
            this.fiyatlbl.TabIndex = 8;
            this.fiyatlbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sepet Toplamı:";
            // 
            // siparisgbtn
            // 
            this.siparisgbtn.Location = new System.Drawing.Point(1045, 513);
            this.siparisgbtn.Name = "siparisgbtn";
            this.siparisgbtn.Size = new System.Drawing.Size(114, 23);
            this.siparisgbtn.TabIndex = 6;
            this.siparisgbtn.Text = "Siparişi Gönder";
            this.siparisgbtn.UseVisualStyleBackColor = true;
            this.siparisgbtn.Click += new System.EventHandler(this.siparisgbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1110, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sepet :";
            // 
            // sepetlst
            // 
            this.sepetlst.Dock = System.Windows.Forms.DockStyle.Right;
            this.sepetlst.HideSelection = false;
            this.sepetlst.Location = new System.Drawing.Point(908, 0);
            this.sepetlst.Name = "sepetlst";
            this.sepetlst.Size = new System.Drawing.Size(878, 348);
            this.sepetlst.TabIndex = 4;
            this.sepetlst.UseCompatibleStateImageBehavior = false;
            // 
            // gondersipbtn
            // 
            this.gondersipbtn.Location = new System.Drawing.Point(886, 511);
            this.gondersipbtn.Name = "gondersipbtn";
            this.gondersipbtn.Size = new System.Drawing.Size(127, 27);
            this.gondersipbtn.TabIndex = 3;
            this.gondersipbtn.Text = "Sepete gönder";
            this.gondersipbtn.UseVisualStyleBackColor = true;
            this.gondersipbtn.Click += new System.EventHandler(this.gondersipbtn_Click);
            // 
            // Urunlst
            // 
            this.Urunlst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Urunlst.HideSelection = false;
            this.Urunlst.Location = new System.Drawing.Point(0, 348);
            this.Urunlst.Name = "Urunlst";
            this.Urunlst.Size = new System.Drawing.Size(1786, 373);
            this.Urunlst.TabIndex = 2;
            this.Urunlst.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparişler";
            // 
            // cmbsiparis
            // 
            this.cmbsiparis.FormattingEnabled = true;
            this.cmbsiparis.Items.AddRange(new object[] {
            "İçecekler",
            "Yemekler",
            "Menüler"});
            this.cmbsiparis.Location = new System.Drawing.Point(32, 35);
            this.cmbsiparis.Name = "cmbsiparis";
            this.cmbsiparis.Size = new System.Drawing.Size(121, 24);
            this.cmbsiparis.TabIndex = 0;
            this.cmbsiparis.SelectedIndexChanged += new System.EventHandler(this.cmbsiparis_SelectedIndexChanged);
            // 
            // istpnl
            // 
            this.istpnl.Controls.Add(this.istgbtn);
            this.istpnl.Controls.Add(this.geri2btn);
            this.istpnl.Controls.Add(this.label2);
            this.istpnl.Controls.Add(this.hizmetlst);
            this.istpnl.Controls.Add(this.cmbistek);
            this.istpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.istpnl.Location = new System.Drawing.Point(0, 30);
            this.istpnl.Name = "istpnl";
            this.istpnl.Size = new System.Drawing.Size(1786, 721);
            this.istpnl.TabIndex = 2;
            this.istpnl.Visible = false;
            // 
            // istgbtn
            // 
            this.istgbtn.Location = new System.Drawing.Point(1656, 315);
            this.istgbtn.Name = "istgbtn";
            this.istgbtn.Size = new System.Drawing.Size(127, 27);
            this.istgbtn.TabIndex = 6;
            this.istgbtn.Text = "İsteği Gönder";
            this.istgbtn.UseVisualStyleBackColor = true;
            this.istgbtn.Click += new System.EventHandler(this.istgbtn_Click);
            // 
            // geri2btn
            // 
            this.geri2btn.Location = new System.Drawing.Point(3, 237);
            this.geri2btn.Name = "geri2btn";
            this.geri2btn.Size = new System.Drawing.Size(26, 23);
            this.geri2btn.TabIndex = 5;
            this.geri2btn.Text = "←";
            this.geri2btn.UseVisualStyleBackColor = true;
            this.geri2btn.Click += new System.EventHandler(this.geri2btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İstekler";
            // 
            // hizmetlst
            // 
            this.hizmetlst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hizmetlst.HideSelection = false;
            this.hizmetlst.Location = new System.Drawing.Point(0, 348);
            this.hizmetlst.Name = "hizmetlst";
            this.hizmetlst.Size = new System.Drawing.Size(1786, 373);
            this.hizmetlst.TabIndex = 3;
            this.hizmetlst.UseCompatibleStateImageBehavior = false;
            // 
            // cmbistek
            // 
            this.cmbistek.FormattingEnabled = true;
            this.cmbistek.Items.AddRange(new object[] {
            "Değişim",
            "Bakım",
            "Temizlik"});
            this.cmbistek.Location = new System.Drawing.Point(32, 43);
            this.cmbistek.Name = "cmbistek";
            this.cmbistek.Size = new System.Drawing.Size(121, 24);
            this.cmbistek.TabIndex = 0;
            this.cmbistek.SelectedIndexChanged += new System.EventHandler(this.cmbistek_SelectedIndexChanged);
            // 
            // glabel
            // 
            this.glabel.AutoSize = true;
            this.glabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glabel.Location = new System.Drawing.Point(46, 47);
            this.glabel.Name = "glabel";
            this.glabel.Size = new System.Drawing.Size(0, 38);
            this.glabel.TabIndex = 2;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 751);
            this.Controls.Add(this.glabel);
            this.Controls.Add(this.istpnl);
            this.Controls.Add(this.siparispnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusteriForm";
            this.Text = "Müşteri Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.siparispnl.ResumeLayout(false);
            this.siparispnl.PerformLayout();
            this.istpnl.ResumeLayout(false);
            this.istpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel siparispnl;
        private System.Windows.Forms.ComboBox cmbsiparis;
        private System.Windows.Forms.Panel istpnl;
        private System.Windows.Forms.ComboBox cmbistek;
        private System.Windows.Forms.Button gondersipbtn;
        private System.Windows.Forms.ListView Urunlst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView hizmetlst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button siparisgbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView sepetlst;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.Label fiyatlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem temizlikDeğişimToolStripMenuItem;
        private System.Windows.Forms.Button geri1btn;
        private System.Windows.Forms.Button geri2btn;
        private System.Windows.Forms.Label glabel;
        private System.Windows.Forms.Button istgbtn;
    }
}