namespace HotelManagementSystem
{
    partial class kathizmet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hizmetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTemizlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlsipariş = new System.Windows.Forms.Panel();
            this.btngeri1 = new System.Windows.Forms.Button();
            this.btnonay = new System.Windows.Forms.Button();
            this.lstsiparis = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlsipariş.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hizmetlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hizmetlerToolStripMenuItem
            // 
            this.hizmetlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem,
            this.odaTemizlikToolStripMenuItem,
            this.değişimToolStripMenuItem});
            this.hizmetlerToolStripMenuItem.Name = "hizmetlerToolStripMenuItem";
            this.hizmetlerToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hizmetlerToolStripMenuItem.Text = "Hizmetler";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // odaTemizlikToolStripMenuItem
            // 
            this.odaTemizlikToolStripMenuItem.Name = "odaTemizlikToolStripMenuItem";
            this.odaTemizlikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.odaTemizlikToolStripMenuItem.Text = "Oda Temizlik";
            // 
            // değişimToolStripMenuItem
            // 
            this.değişimToolStripMenuItem.Name = "değişimToolStripMenuItem";
            this.değişimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.değişimToolStripMenuItem.Text = "Değişim";
            // 
            // pnlsipariş
            // 
            this.pnlsipariş.Controls.Add(this.btngeri1);
            this.pnlsipariş.Controls.Add(this.btnonay);
            this.pnlsipariş.Controls.Add(this.lstsiparis);
            this.pnlsipariş.Location = new System.Drawing.Point(0, 31);
            this.pnlsipariş.Name = "pnlsipariş";
            this.pnlsipariş.Size = new System.Drawing.Size(800, 421);
            this.pnlsipariş.TabIndex = 1;
            // 
            // btngeri1
            // 
            this.btngeri1.Location = new System.Drawing.Point(12, 177);
            this.btngeri1.Name = "btngeri1";
            this.btngeri1.Size = new System.Drawing.Size(23, 23);
            this.btngeri1.TabIndex = 2;
            this.btngeri1.Text = "←";
            this.btngeri1.UseVisualStyleBackColor = true;
            this.btngeri1.Click += new System.EventHandler(this.btngeri1_Click);
            // 
            // btnonay
            // 
            this.btnonay.Location = new System.Drawing.Point(657, 175);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(131, 26);
            this.btnonay.TabIndex = 1;
            this.btnonay.Text = "Sipariş teslim";
            this.btnonay.UseVisualStyleBackColor = true;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // lstsiparis
            // 
            this.lstsiparis.HideSelection = false;
            this.lstsiparis.Location = new System.Drawing.Point(0, 207);
            this.lstsiparis.Name = "lstsiparis";
            this.lstsiparis.Size = new System.Drawing.Size(800, 211);
            this.lstsiparis.TabIndex = 0;
            this.lstsiparis.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // kathizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlsipariş);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kathizmet";
            this.Text = "Kat Hizmetleri";
            this.Load += new System.EventHandler(this.kathizmet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlsipariş.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hizmetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTemizlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değişimToolStripMenuItem;
        private System.Windows.Forms.Panel pnlsipariş;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.ListView lstsiparis;
        private System.Windows.Forms.Button btngeri1;
        private System.Windows.Forms.Timer timer1;
    }
}