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
    public partial class FormHesabim : Form
    {
        public event EventHandler<KitapDegistiEventArgs> KitapDegisti;
        public event EventHandler<TeslimSuresiEventArgs> TeslimGeldi;
        private readonly Kullanici _k;
        private readonly KutuphaneYoneticisi _kutup;
        public FormHesabim(Kullanici kullanici, KutuphaneYoneticisi kutup)
        {
            _k = kullanici;
            _kutup = kutup;
            InitializeComponent();
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            lblAdSoyad.Text = _k.AdSoyad;
            lblId.Text = _k.Id.ToString();
            lblKullaniciAdi.Text = _k.KullaniciAdi;
            lblParola.Text = _k.Sifre;
            dgvOduncKitaplar.DataSource = _k.OduncAlinanKitaplar;
            dgvOduncKitaplar.Columns[0].Visible = false;
            dgvOduncKitaplar.Columns[2].Visible = false;
            dgvOduncKitaplar.Columns[3].Visible = false;
            dgvOduncKitaplar.Columns[4].Visible = false;
            dgvOduncKitaplar.Columns[5].Visible = false;
            dgvOduncKitaplar.Columns[6].Visible = false;
            dgvOduncKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvOduncKitaplar.Columns[7].HeaderText = "Basım Tarihi";
            dgvOduncKitaplar.Columns[8].HeaderText = "Ödünç Alma Tarihi";
        }

        private void dgvOduncKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncKitaplar.SelectedRows.Count > 0)
            {
                Kitap seciliKitap = (Kitap)dgvOduncKitaplar.SelectedRows[0].DataBoundItem;
                DateTime tarih = (DateTime)seciliKitap.OduncAlmaTarihi;
                tarih = tarih.AddSeconds(10);
                dtpSonTeslim.Value = tarih;
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncKitaplar.SelectedRows.Count < 1)
            {
                return;
            }
            Kitap seciliKitap = (Kitap)dgvOduncKitaplar.SelectedRows[0].DataBoundItem;
            _kutup.KitapTeslimEt(seciliKitap, _k);
            dgvOduncKitaplar.DataSource = null;
            if (KitapDegisti != null)
            {
                KitapDegisti(this, new KitapDegistiEventArgs());
            }
            BilgileriGetir();
        }

        private void dtpSonTeslim_ValueChanged(object sender, EventArgs e)
        {
            Task.Run(UyariVer);
        }

        private void UyariVer()
        {
            if (TeslimGeldi != null)
            {
                TeslimGeldi(this, new TeslimSuresiEventArgs(dtpSonTeslim.Value));
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            FormParolaDegistir frm = new FormParolaDegistir(_k);
            frm.ShowDialog();
            BilgileriGetir();
        }
    }
}
