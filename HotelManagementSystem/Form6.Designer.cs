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
            this.personelGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yonetimpnl = new System.Windows.Forms.Panel();
            this.iscikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vardiyacmb = new System.Windows.Forms.ComboBox();
            this.geribtn1 = new System.Windows.Forms.Button();
            this.vardiyabtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.yonetimpnl.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1638, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelYönetimToolStripMenuItem,
            this.personelGirişToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // personelYönetimToolStripMenuItem
            // 
            this.personelYönetimToolStripMenuItem.Name = "personelYönetimToolStripMenuItem";
            this.personelYönetimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelYönetimToolStripMenuItem.Text = "Personel Yönetim";
            this.personelYönetimToolStripMenuItem.Click += new System.EventHandler(this.personelYönetimToolStripMenuItem_Click);
            // 
            // personelGirişToolStripMenuItem
            // 
            this.personelGirişToolStripMenuItem.Name = "personelGirişToolStripMenuItem";
            this.personelGirişToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelGirişToolStripMenuItem.Text = "Personel Giriş";
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sistemToolStripMenuItem.Text = "Sistem";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yonetimpnl
            // 
            this.yonetimpnl.Controls.Add(this.iscikar);
            this.yonetimpnl.Controls.Add(this.label1);
            this.yonetimpnl.Controls.Add(this.Vardiyacmb);
            this.yonetimpnl.Controls.Add(this.geribtn1);
            this.yonetimpnl.Controls.Add(this.vardiyabtn);
            this.yonetimpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yonetimpnl.Location = new System.Drawing.Point(0, 28);
            this.yonetimpnl.Name = "yonetimpnl";
            this.yonetimpnl.Size = new System.Drawing.Size(1638, 284);
            this.yonetimpnl.TabIndex = 2;
            // 
            // iscikar
            // 
            this.iscikar.Location = new System.Drawing.Point(1069, 207);
            this.iscikar.Name = "iscikar";
            this.iscikar.Size = new System.Drawing.Size(147, 33);
            this.iscikar.TabIndex = 4;
            this.iscikar.Text = "Personel Çıkışı";
            this.iscikar.UseVisualStyleBackColor = true;
            this.iscikar.Click += new System.EventHandler(this.iscikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vardiyalar :";
            // 
            // Vardiyacmb
            // 
            this.Vardiyacmb.FormattingEnabled = true;
            this.Vardiyacmb.Items.AddRange(new object[] {
            "Gece",
            "Gündüz",
            "Sabit"});
            this.Vardiyacmb.Location = new System.Drawing.Point(656, 68);
            this.Vardiyacmb.Name = "Vardiyacmb";
            this.Vardiyacmb.Size = new System.Drawing.Size(121, 24);
            this.Vardiyacmb.TabIndex = 2;
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
            // vardiyabtn
            // 
            this.vardiyabtn.Location = new System.Drawing.Point(656, 207);
            this.vardiyabtn.Name = "vardiyabtn";
            this.vardiyabtn.Size = new System.Drawing.Size(147, 33);
            this.vardiyabtn.TabIndex = 0;
            this.vardiyabtn.Text = "Vardiya Değiştir";
            this.vardiyabtn.UseVisualStyleBackColor = true;
            this.vardiyabtn.Click += new System.EventHandler(this.vardiyabtn_Click);
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
            this.yonetimpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView personelLst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişToolStripMenuItem;
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
    }
}