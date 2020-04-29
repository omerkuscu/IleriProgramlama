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
    public partial class Ders1Ornek2 : Form
    {
        public Ders1Ornek2()
        {
            InitializeComponent();
        }

        private void txtBilgi_TextChanged(object sender, EventArgs e)
        {
            //var bilgi = txt_Bilgi.Text;
            //lbl_Mesaj.Text = bilgi;
            lbl_Mesaj.Text = txt_Bilgi.Text;
            lbl_KarakterSayisi.Text = txt_Bilgi.Text.Length.ToString();
        }
    }
}
