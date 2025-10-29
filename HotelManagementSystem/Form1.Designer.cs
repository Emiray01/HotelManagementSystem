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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Mid_txt = new System.Windows.Forms.TextBox();
            this.girisMbtn = new System.Windows.Forms.Button();
            this.Msifre_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisPbtn
            // 
            this.girisPbtn.Location = new System.Drawing.Point(0, 216);
            this.girisPbtn.Name = "girisPbtn";
            this.girisPbtn.Size = new System.Drawing.Size(75, 23);
            this.girisPbtn.TabIndex = 0;
            this.girisPbtn.Text = "Giriş";
            this.girisPbtn.UseVisualStyleBackColor = true;
            this.girisPbtn.Click += new System.EventHandler(this.girisPbtn_Click);
            // 
            // Pid_txt
            // 
            this.Pid_txt.Location = new System.Drawing.Point(0, 36);
            this.Pid_txt.Name = "Pid_txt";
            this.Pid_txt.Size = new System.Drawing.Size(100, 22);
            this.Pid_txt.TabIndex = 2;
            this.Pid_txt.Tag = "";
            this.Pid_txt.Text = "05";
            // 
            // Psifre_txt
            // 
            this.Psifre_txt.Location = new System.Drawing.Point(0, 75);
            this.Psifre_txt.Name = "Psifre_txt";
            this.Psifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Psifre_txt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Pid_txt);
            this.groupBox1.Controls.Add(this.girisPbtn);
            this.groupBox1.Controls.Add(this.Psifre_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Girişi";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 16);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Telefon:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Mid_txt);
            this.groupBox2.Controls.Add(this.girisMbtn);
            this.groupBox2.Controls.Add(this.Msifre_txt);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 316);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Girişi";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Şifre";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 16);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Müşteri ID:";
            // 
            // Mid_txt
            // 
            this.Mid_txt.Location = new System.Drawing.Point(0, 36);
            this.Mid_txt.Name = "Mid_txt";
            this.Mid_txt.Size = new System.Drawing.Size(100, 22);
            this.Mid_txt.TabIndex = 2;
            // 
            // girisMbtn
            // 
            this.girisMbtn.Location = new System.Drawing.Point(0, 216);
            this.girisMbtn.Name = "girisMbtn";
            this.girisMbtn.Size = new System.Drawing.Size(75, 23);
            this.girisMbtn.TabIndex = 0;
            this.girisMbtn.Text = "Giriş";
            this.girisMbtn.UseVisualStyleBackColor = true;
            this.girisMbtn.Click += new System.EventHandler(this.girisMbtn_Click);
            // 
            // Msifre_txt
            // 
            this.Msifre_txt.Location = new System.Drawing.Point(0, 75);
            this.Msifre_txt.Name = "Msifre_txt";
            this.Msifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Msifre_txt.TabIndex = 3;
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formGiris";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button girisPbtn;
        private System.Windows.Forms.TextBox Pid_txt;
        private System.Windows.Forms.TextBox Psifre_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox Mid_txt;
        private System.Windows.Forms.Button girisMbtn;
        private System.Windows.Forms.TextBox Msifre_txt;
    }
}

