using KutuphaneDATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneDeneme
{
    public partial class RegisterForm : Form
    {
        private readonly KullaniciYoneticisi _ky;
        public RegisterForm(KullaniciYoneticisi ky)
        {
            _ky = ky;
            InitializeComponent();
            btnKayitOl.Enabled = false;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici() { AdSoyad = txtAdSoyad.Text, KullaniciAdi = txtKullaniciAdi.Text, Sifre = txtSifre.Text };
            _ky.kullanicilar.Add(kullanici);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (_ky.KullaniciVarMi(txtKullaniciAdi.Text))
            {
                lblKullaniciAdi.ForeColor = Color.Red;
                lblKullaniciAdi.Text = "Kullanıcı adı mevcut";
            }
            else
            {
                lblKullaniciAdi.ForeColor = Color.Green;
                lblKullaniciAdi.Text = "Kullanıcı adı uygun";
            }
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != null)
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    lblParola.ForeColor = Color.Red;
                    lblParola.Text = "Parolalar uyuşmuyor";
                }
                else
                {
                    lblParola.ForeColor = Color.Green;
                    lblParola.Text = "Parola uygun";
                    if (lblKullaniciAdi.ForeColor == Color.Green)
                    {
                        btnKayitOl.Enabled = true;
                    }
                }
            }
        }
    }
}
