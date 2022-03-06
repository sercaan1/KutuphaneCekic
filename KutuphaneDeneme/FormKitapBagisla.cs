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
    public partial class FormKitapBagisla : Form
    {
        public event EventHandler<KitapDegistiEventArgs> KitapBagislandi;
        private readonly KutuphaneYoneticisi _kutup;
        public FormKitapBagisla(KutuphaneYoneticisi kutup)
        {
            _kutup = kutup;
            InitializeComponent();
            TurleriGetir();
            Yenile();
        }

        private void TurleriGetir()
        {
            cboTur.DataSource = Enum.GetValues(typeof(EnumKitapTuru));
        }

        private Kitap KitabıGetir()
        {
            Kitap kitap = new Kitap() { Aciklama = txtAciklama.Text, Ad = txtKitapAd.Text, BasimTarihi = dtpBasimTarihi.Value, SayfaSayisi = (int)nudSayfaSayisi.Value, YazarAd = txtYazarAd.Text, Tur = (EnumKitapTuru)cboTur.SelectedItem };
            return kitap;
        }

        private void btnBagisla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudAdet.Value; i++)
            {
                _kutup.KitapEkle(KitabıGetir());
            }
            if (!string.IsNullOrEmpty(txtKitapAd.Text))
            {
                DialogResult dr = MessageBox.Show("Başka kitap eklemek istiyor musunuz?", "Bağış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    if (KitapBagislandi != null)
                    {
                        KitapBagislandi(this, new KitapDegistiEventArgs());
                    }
                    Yenile();
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kitap adı boş bırakılamaz.");
            }
        }

        private void Yenile()
        {
            txtAciklama.Text = null;
            txtKitapAd.Text = null;
            txtYazarAd.Text = null;
            nudAdet.Value = 1;
            nudSayfaSayisi.Value = 1;
            cboTur.SelectedIndex = 0;
            dtpBasimTarihi.Value = DateTime.Now;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
