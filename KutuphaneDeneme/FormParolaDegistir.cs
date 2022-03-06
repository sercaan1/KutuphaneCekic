using KutuphaneDATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneDeneme
{
    public partial class FormParolaDegistir : Form
    {
        private readonly Kullanici _k;
        public FormParolaDegistir(Kullanici kullanici)
        {
            _k = kullanici;
            InitializeComponent();
            txtKullaniciAd.Text = _k.KullaniciAdi;
            btnKaydet.Enabled = false;
        }

        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {
            if (_k.Sifre == txtEskiSifre.Text)
            {
                lblEskiSifre.ForeColor = Color.Green;
                lblEskiSifre.Text = "Eski şifre doğru";
            }
            else
            {
                lblEskiSifre.ForeColor = Color.Red;
                lblEskiSifre.Text = "Eski şifre yanlış";
            }
        }

        private void txtTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == txtTekrar.Text && txtTekrar.Text != txtEskiSifre.Text)
            {
                if (lblEskiSifre.ForeColor == Color.Green)
                {
                    btnKaydet.Enabled = true;
                }
                lblUygunluk.ForeColor = Color.Green;
                lblUygunluk.Text = "Şifre Uygun";
            }
            else if (txtTekrar.Text == txtEskiSifre.Text)
            {
                lblUygunluk.ForeColor = Color.Red;
                lblUygunluk.Text = "Yeni şifre eskisiyle aynı olamaz";
            }
            else if (txtEskiSifre.Text != txtTekrar.Text)
            {
                lblUygunluk.ForeColor = Color.Red;
                lblUygunluk.Text = "Şifreler uyumsuz";
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _k.Sifre = txtTekrar.Text;
            this.Close();
        }
    }
}
