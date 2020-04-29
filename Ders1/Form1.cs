using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {

        int sayac = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txt_KullaniciAdi.Text;
            var sifre = txt_Sifre.Text;

            


            if (kullaniciAdi == KullaniciBilgileri.KullaniciAdi && sifre == KullaniciBilgileri.Sifre)
            {
                MessageBox.Show("Giriş Başarılı");
                sayac = 0;
                lbl_YanlisDenemeSayisi.Text = "Giriş Başarılı";
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı");
                sayac++;
                lbl_YanlisDenemeSayisi.Text = sayac.ToString();
            }

        }
    }
}
