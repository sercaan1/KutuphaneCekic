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
    public partial class LoginForm : Form
    {
        KullaniciYoneticisi ky;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frm = new RegisterForm(ky);
            frm.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = ky.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);
            if (kullanici != null)
            {
                FormKutuphaneArayuz frm = new FormKutuphaneArayuz(kullanici);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            VerileriOku();
        }

        private void VerileriOku()
        {
            try
            {
                string fromJson = File.ReadAllText("KullaniciVeri.json");
                ky = JsonConvert.DeserializeObject<KullaniciYoneticisi>(fromJson);
            }
            catch (Exception)
            {
                ky = new KullaniciYoneticisi();
            }
        }

        private void VerileriKaydet()
        {
            string toJson = JsonConvert.SerializeObject(ky);
            File.WriteAllText("KullaniciVeri.json", toJson);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void cbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreGoster.Checked == false)
            {
                txtSifre.PasswordChar = '*';
            }
            else
            {
                txtSifre.PasswordChar = '\0';
            }
        }
    }
}
