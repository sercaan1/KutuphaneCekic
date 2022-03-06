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
    public partial class FormKutuphaneArayuz : Form
    {
        private readonly Kullanici _k;
        KutuphaneYoneticisi kutup;
        public FormKutuphaneArayuz(Kullanici kullanici)
        {
            _k = kullanici;
            InitializeComponent();
        }

        private void OrnekKitaplariGetir()
        {
            kutup.kitaplar.Add(new Kitap() { Ad = "Limon Ağacı", Aciklama = "İsrail Filistin savaşı", BasimTarihi = new DateTime(1960, 05, 20), SayfaSayisi = 300, Tur = EnumKitapTuru.Roman, YazarAd = "Sandy Tolan", Adet = 1 });
            kutup.kitaplar.Add(new Kitap() { Ad = "1984", Aciklama = "Günümüz", BasimTarihi = new DateTime(1965, 03, 21), SayfaSayisi = 350, Tur = EnumKitapTuru.Roman, YazarAd = "George Orwell", Adet = 1 });
            ComboBoxGetir();
        }

        private void ComboBoxGetir()
        {
            cboTurler.Items.Add("Hepsi");
            cboTurler.Items.AddRange(Enum.GetValues(typeof(EnumKitapTuru)).Cast<object>().ToArray());
            Yenile();
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            FormHesabim frm = new FormHesabim(_k, kutup);
            frm.KitapDegisti += Frm_KitapDegisti;
            frm.TeslimGeldi += Frm_TeslimGeldi;
            frm.ShowDialog();
        }

        private void Frm_TeslimGeldi(object sender, TeslimSuresiEventArgs e)
        {
            if (e.OduncAlmaZamani < DateTime.Now)
            {
                MessageBox.Show($"{_k.AdSoyad} adlı kullanıcının kitabı teslim etmesi gerekiyor.");
            }
        }

        private void Frm_KitapDegisti(object sender, KitapDegistiEventArgs e)
        {
            Yenile();
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKitaplar, e.X, e.Y);
                    dgvKitaplar.Rows[position].Selected = true;
                }
            }
        }

        private void kitapİmhaEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            kutup.KitapImhaEt(kitap);
            Yenile();
        }

        private void kitapÖdünçAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            kutup.KitapOduncAl(kitap, _k);
            Yenile();
        }

        private void Yenile()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kutup.kitaplar;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Yazar Adı";
            dgvKitaplar.Columns[3].HeaderText = "Açıklama";
            dgvKitaplar.Columns[4].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[5].HeaderText = "Türü";
            dgvKitaplar.Columns[6].HeaderText = "Adet";
            dgvKitaplar.Columns[7].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[8].Visible = false;
            cboTurler.SelectedIndex = 0;
        }

        private void tsmiCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiBagis_Click(object sender, EventArgs e)
        {
            FormKitapBagisla frm = new FormKitapBagisla(kutup);
            frm.KitapBagislandi += Frm_KitapBagislandi;
            frm.ShowDialog();
            Yenile();
        }

        private void Frm_KitapBagislandi(object sender, KitapDegistiEventArgs e)
        {
            Yenile();
        }

        private void cboTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTurler.SelectedIndex != 0)
            {
                dgvKitaplar.DataSource = SeciliTurdeKitaplariGetir();
                dgvKitaplar.Columns[0].Visible = false;
                dgvKitaplar.Columns[8].Visible = false;
            }
            else if (cboTurler.SelectedIndex == 0)
            {
                Yenile();
            }
        }

        private List<Kitap> SeciliTurdeKitaplariGetir()
        {
            EnumKitapTuru seciliTur = (EnumKitapTuru)cboTurler.SelectedItem;
            List<Kitap> seciliKitaplar = kutup.kitaplar.Where(x => x.Tur == seciliTur).ToList();
            return seciliKitaplar;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (cboTurler.SelectedIndex != 0 && !string.IsNullOrEmpty(txtArama.Text))
            {
                List<Kitap> seciliKitaplar = SeciliTurdeKitaplariGetir();
                seciliKitaplar = seciliKitaplar.Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower()) || x.YazarAd.ToLower().Contains(txtArama.Text.ToLower())).ToList();
                dgvKitaplar.DataSource = seciliKitaplar;
            }
            else if (!string.IsNullOrEmpty(txtArama.Text))
            {
                List<Kitap> seciliKitaplar = kutup.kitaplar.Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower()) || x.YazarAd.ToLower().Contains(txtArama.Text.ToLower())).ToList();
                dgvKitaplar.DataSource = seciliKitaplar;
            }
            else if (string.IsNullOrEmpty(txtArama.Text) && cboTurler.SelectedIndex == 0)
            {
                dgvKitaplar.DataSource = kutup.kitaplar;
            }
        }

        private void FormKutuphaneArayuz_Load(object sender, EventArgs e)
        {
            VerileriOku();
        }

        private void VerileriOku()
        {
            try
            {
                string fromJson = File.ReadAllText("kutuphaneVeri.json");
                kutup = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(fromJson);
                dgvKitaplar.DataSource = kutup.kitaplar;
                ComboBoxGetir();
            }
            catch (Exception)
            {
                kutup = new KutuphaneYoneticisi();
                OrnekKitaplariGetir();
            }
        }

        private void FormKutuphaneArayuz_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string toJson = JsonConvert.SerializeObject(kutup);
            File.WriteAllText("kutuphaneVeri.json", toJson);
        }
    }
}
