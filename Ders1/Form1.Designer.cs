namespace Ders1
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
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_YanlisDenemeSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(203, 81);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 23);
            this.btn_Giris.TabIndex = 0;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(103, 29);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(175, 20);
            this.txt_KullaniciAdi.TabIndex = 1;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(103, 55);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(175, 20);
            this.txt_Sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yanlış Giriş Sayısı";
            // 
            // lbl_YanlisDenemeSayisi
            // 
            this.lbl_YanlisDenemeSayisi.AutoSize = true;
            this.lbl_YanlisDenemeSayisi.Location = new System.Drawing.Point(206, 121);
            this.lbl_YanlisDenemeSayisi.Name = "lbl_YanlisDenemeSayisi";
            this.lbl_YanlisDenemeSayisi.Size = new System.Drawing.Size(16, 13);
            this.lbl_YanlisDenemeSayisi.TabIndex = 4;
            this.lbl_YanlisDenemeSayisi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 171);
            this.Controls.Add(this.lbl_YanlisDenemeSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.btn_Giris);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Giriş Formu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_YanlisDenemeSayisi;
    }
}

