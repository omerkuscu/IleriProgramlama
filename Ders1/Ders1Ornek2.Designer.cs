namespace Ders1
{
    partial class Ders1Ornek2
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
            this.txt_Bilgi = new System.Windows.Forms.TextBox();
            this.lbl_Mesaj = new System.Windows.Forms.Label();
            this.lbl_KarakterSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Bilgi
            // 
            this.txt_Bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Bilgi.Location = new System.Drawing.Point(56, 47);
            this.txt_Bilgi.Name = "txt_Bilgi";
            this.txt_Bilgi.Size = new System.Drawing.Size(321, 38);
            this.txt_Bilgi.TabIndex = 0;
            this.txt_Bilgi.TextChanged += new System.EventHandler(this.txtBilgi_TextChanged);
            // 
            // lbl_Mesaj
            // 
            this.lbl_Mesaj.AutoSize = true;
            this.lbl_Mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mesaj.Location = new System.Drawing.Point(50, 88);
            this.lbl_Mesaj.Name = "lbl_Mesaj";
            this.lbl_Mesaj.Size = new System.Drawing.Size(38, 31);
            this.lbl_Mesaj.TabIndex = 1;
            this.lbl_Mesaj.Text = "...";
            // 
            // lbl_KarakterSayisi
            // 
            this.lbl_KarakterSayisi.AutoSize = true;
            this.lbl_KarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KarakterSayisi.Location = new System.Drawing.Point(50, 128);
            this.lbl_KarakterSayisi.Name = "lbl_KarakterSayisi";
            this.lbl_KarakterSayisi.Size = new System.Drawing.Size(38, 31);
            this.lbl_KarakterSayisi.TabIndex = 1;
            this.lbl_KarakterSayisi.Text = "...";
            // 
            // Ders1Ornek2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 203);
            this.Controls.Add(this.lbl_KarakterSayisi);
            this.Controls.Add(this.lbl_Mesaj);
            this.Controls.Add(this.txt_Bilgi);
            this.Name = "Ders1Ornek2";
            this.Text = "Ders1Ornek2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Bilgi;
        private System.Windows.Forms.Label lbl_Mesaj;
        private System.Windows.Forms.Label lbl_KarakterSayisi;
    }
}