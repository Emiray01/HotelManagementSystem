namespace HotelManagementSystem
{
    partial class IKform
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
            this.personelLst = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yonetimpnl = new System.Windows.Forms.Panel();
            this.zamgbp = new System.Windows.Forms.GroupBox();
            this.zambtn = new System.Windows.Forms.Button();
            this.gzambtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.zamcbx = new System.Windows.Forms.ComboBox();
            this.personelekgbp = new System.Windows.Forms.GroupBox();
            this.Prsgirbtn = new System.Windows.Forms.Button();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yastxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Personelcbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.psoyadtxt = new System.Windows.Forms.TextBox();
            this.padtxt = new System.Windows.Forms.TextBox();
            this.vardiyagbx = new System.Windows.Forms.GroupBox();
            this.vardiyabtn = new System.Windows.Forms.Button();
            this.Vardiyacmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iscikar = new System.Windows.Forms.Button();
            this.geribtn1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.yonetimpnl.SuspendLayout();
            this.zamgbp.SuspendLayout();
            this.personelekgbp.SuspendLayout();
            this.vardiyagbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // personelLst
            // 
            this.personelLst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personelLst.HideSelection = false;
            this.personelLst.Location = new System.Drawing.Point(0, 312);
            this.personelLst.Name = "personelLst";
            this.personelLst.Size = new System.Drawing.Size(1638, 271);
            this.personelLst.TabIndex = 0;
            this.personelLst.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.sistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1638, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelYönetimToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // personelYönetimToolStripMenuItem
            // 
            this.personelYönetimToolStripMenuItem.Name = "personelYönetimToolStripMenuItem";
            this.personelYönetimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelYönetimToolStripMenuItem.Text = "Personel Yönetim";
            this.personelYönetimToolStripMenuItem.Click += new System.EventHandler(this.personelYönetimToolStripMenuItem_Click);
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.sistemToolStripMenuItem.Text = "Sistem";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yonetimpnl
            // 
            this.yonetimpnl.Controls.Add(this.zamgbp);
            this.yonetimpnl.Controls.Add(this.personelekgbp);
            this.yonetimpnl.Controls.Add(this.vardiyagbx);
            this.yonetimpnl.Controls.Add(this.iscikar);
            this.yonetimpnl.Controls.Add(this.geribtn1);
            this.yonetimpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yonetimpnl.Location = new System.Drawing.Point(0, 30);
            this.yonetimpnl.Name = "yonetimpnl";
            this.yonetimpnl.Size = new System.Drawing.Size(1638, 282);
            this.yonetimpnl.TabIndex = 2;
            // 
            // zamgbp
            // 
            this.zamgbp.Controls.Add(this.zambtn);
            this.zamgbp.Controls.Add(this.gzambtn);
            this.zamgbp.Controls.Add(this.label7);
            this.zamgbp.Controls.Add(this.zamcbx);
            this.zamgbp.Location = new System.Drawing.Point(719, 28);
            this.zamgbp.Name = "zamgbp";
            this.zamgbp.Size = new System.Drawing.Size(268, 250);
            this.zamgbp.TabIndex = 7;
            this.zamgbp.TabStop = false;
            // 
            // zambtn
            // 
            this.zambtn.Location = new System.Drawing.Point(173, 209);
            this.zambtn.Name = "zambtn";
            this.zambtn.Size = new System.Drawing.Size(75, 23);
            this.zambtn.TabIndex = 3;
            this.zambtn.Text = "Zam Yap";
            this.zambtn.UseVisualStyleBackColor = true;
            this.zambtn.Click += new System.EventHandler(this.zambtn_Click);
            // 
            // gzambtn
            // 
            this.gzambtn.Location = new System.Drawing.Point(15, 209);
            this.gzambtn.Name = "gzambtn";
            this.gzambtn.Size = new System.Drawing.Size(115, 23);
            this.gzambtn.TabIndex = 2;
            this.gzambtn.Text = "Genel Zam Yap";
            this.gzambtn.UseVisualStyleBackColor = true;
            this.gzambtn.Click += new System.EventHandler(this.gzambtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Zam Yüzdesi";
            // 
            // zamcbx
            // 
            this.zamcbx.FormattingEnabled = true;
            this.zamcbx.Location = new System.Drawing.Point(15, 31);
            this.zamcbx.Name = "zamcbx";
            this.zamcbx.Size = new System.Drawing.Size(121, 24);
            this.zamcbx.TabIndex = 0;
            // 
            // personelekgbp
            // 
            this.personelekgbp.Controls.Add(this.Prsgirbtn);
            this.personelekgbp.Controls.Add(this.teltxt);
            this.personelekgbp.Controls.Add(this.label6);
            this.personelekgbp.Controls.Add(this.yastxt);
            this.personelekgbp.Controls.Add(this.label5);
            this.personelekgbp.Controls.Add(this.Personelcbx);
            this.personelekgbp.Controls.Add(this.label4);
            this.personelekgbp.Controls.Add(this.label3);
            this.personelekgbp.Controls.Add(this.label2);
            this.personelekgbp.Controls.Add(this.psoyadtxt);
            this.personelekgbp.Controls.Add(this.padtxt);
            this.personelekgbp.Location = new System.Drawing.Point(81, 28);
            this.personelekgbp.Name = "personelekgbp";
            this.personelekgbp.Size = new System.Drawing.Size(258, 250);
            this.personelekgbp.TabIndex = 6;
            this.personelekgbp.TabStop = false;
            this.personelekgbp.Text = "Personel Giriş";
            // 
            // Prsgirbtn
            // 
            this.Prsgirbtn.Location = new System.Drawing.Point(131, 210);
            this.Prsgirbtn.Name = "Prsgirbtn";
            this.Prsgirbtn.Size = new System.Drawing.Size(108, 23);
            this.Prsgirbtn.TabIndex = 10;
            this.Prsgirbtn.Text = "Personel Giriş";
            this.Prsgirbtn.UseVisualStyleBackColor = true;
            this.Prsgirbtn.Click += new System.EventHandler(this.Prsgirbtn_Click);
            // 
            // teltxt
            // 
            this.teltxt.Location = new System.Drawing.Point(6, 210);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(100, 22);
            this.teltxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefon:";
            // 
            // yastxt
            // 
            this.yastxt.Location = new System.Drawing.Point(6, 166);
            this.yastxt.Name = "yastxt";
            this.yastxt.Size = new System.Drawing.Size(100, 22);
            this.yastxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yaş:";
            // 
            // Personelcbx
            // 
            this.Personelcbx.FormattingEnabled = true;
            this.Personelcbx.Location = new System.Drawing.Point(6, 120);
            this.Personelcbx.Name = "Personelcbx";
            this.Personelcbx.Size = new System.Drawing.Size(100, 24);
            this.Personelcbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pozisyon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim:";
            // 
            // psoyadtxt
            // 
            this.psoyadtxt.Location = new System.Drawing.Point(6, 76);
            this.psoyadtxt.Name = "psoyadtxt";
            this.psoyadtxt.Size = new System.Drawing.Size(100, 22);
            this.psoyadtxt.TabIndex = 1;
            // 
            // padtxt
            // 
            this.padtxt.Location = new System.Drawing.Point(6, 33);
            this.padtxt.Name = "padtxt";
            this.padtxt.Size = new System.Drawing.Size(100, 22);
            this.padtxt.TabIndex = 0;
            // 
            // vardiyagbx
            // 
            this.vardiyagbx.Controls.Add(this.vardiyabtn);
            this.vardiyagbx.Controls.Add(this.Vardiyacmb);
            this.vardiyagbx.Controls.Add(this.label1);
            this.vardiyagbx.Location = new System.Drawing.Point(386, 28);
            this.vardiyagbx.Name = "vardiyagbx";
            this.vardiyagbx.Size = new System.Drawing.Size(276, 250);
            this.vardiyagbx.TabIndex = 5;
            this.vardiyagbx.TabStop = false;
            // 
            // vardiyabtn
            // 
            this.vardiyabtn.Location = new System.Drawing.Point(22, 178);
            this.vardiyabtn.Name = "vardiyabtn";
            this.vardiyabtn.Size = new System.Drawing.Size(147, 33);
            this.vardiyabtn.TabIndex = 0;
            this.vardiyabtn.Text = "Vardiya Değiştir";
            this.vardiyabtn.UseVisualStyleBackColor = true;
            this.vardiyabtn.Click += new System.EventHandler(this.vardiyabtn_Click);
            // 
            // Vardiyacmb
            // 
            this.Vardiyacmb.FormattingEnabled = true;
            this.Vardiyacmb.Items.AddRange(new object[] {
            "Gece",
            "Gündüz",
            "Sabit"});
            this.Vardiyacmb.Location = new System.Drawing.Point(22, 39);
            this.Vardiyacmb.Name = "Vardiyacmb";
            this.Vardiyacmb.Size = new System.Drawing.Size(121, 24);
            this.Vardiyacmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vardiyalar :";
            // 
            // iscikar
            // 
            this.iscikar.Location = new System.Drawing.Point(1032, 227);
            this.iscikar.Name = "iscikar";
            this.iscikar.Size = new System.Drawing.Size(147, 33);
            this.iscikar.TabIndex = 4;
            this.iscikar.Text = "Personel Çıkışı";
            this.iscikar.UseVisualStyleBackColor = true;
            this.iscikar.Click += new System.EventHandler(this.iscikar_Click);
            // 
            // geribtn1
            // 
            this.geribtn1.Location = new System.Drawing.Point(12, 255);
            this.geribtn1.Name = "geribtn1";
            this.geribtn1.Size = new System.Drawing.Size(21, 23);
            this.geribtn1.TabIndex = 1;
            this.geribtn1.Text = "←";
            this.geribtn1.UseVisualStyleBackColor = true;
            this.geribtn1.Click += new System.EventHandler(this.geribtn1_Click);
            // 
            // IKform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 583);
            this.Controls.Add(this.yonetimpnl);
            this.Controls.Add(this.personelLst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IKform";
            this.Text = "Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IKform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.yonetimpnl.ResumeLayout(false);
            this.zamgbp.ResumeLayout(false);
            this.zamgbp.PerformLayout();
            this.personelekgbp.ResumeLayout(false);
            this.personelekgbp.PerformLayout();
            this.vardiyagbx.ResumeLayout(false);
            this.vardiyagbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView personelLst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel yonetimpnl;
        private System.Windows.Forms.Button vardiyabtn;
        private System.Windows.Forms.Button geribtn1;
        private System.Windows.Forms.Button iscikar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Vardiyacmb;
        private System.Windows.Forms.GroupBox vardiyagbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox personelekgbp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psoyadtxt;
        private System.Windows.Forms.TextBox padtxt;
        private System.Windows.Forms.ComboBox Personelcbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yastxt;
        private System.Windows.Forms.Button Prsgirbtn;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox zamgbp;
        private System.Windows.Forms.ComboBox zamcbx;
        private System.Windows.Forms.Button gzambtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button zambtn;
    }
}