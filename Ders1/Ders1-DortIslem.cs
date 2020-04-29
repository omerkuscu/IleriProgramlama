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
    public partial class Ders1_DortIslem : Form
    {
        public Ders1_DortIslem()
        {
            InitializeComponent();
        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            var sayi1 = int.Parse(txt_Sayi1.Text);
            var sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            var sonuc = sayi1 + sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            var sayi1 = int.Parse(txt_Sayi1.Text);
            var sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            var sonuc = sayi1 - sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Carp_Click(object sender, EventArgs e)
        {
            var sayi1 = int.Parse(txt_Sayi1.Text);
            var sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            var sonuc = sayi1 * sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Bol_Click(object sender, EventArgs e)
        {
            var sayi1 = int.Parse(txt_Sayi1.Text);
            var sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            var sonuc = sayi1 / sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }
    }
}
