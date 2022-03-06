using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDATA
{
    public class KutuphaneYoneticisi
    {
        public List<Kitap> kitaplar { get; set; } = new List<Kitap>();
        public void KitapEkle(Kitap k)
        {
            kitaplar.Add(k);
        }
        public void KitapImhaEt(Kitap k)
        {
            kitaplar.Remove(k);
        }
        public void KitapOduncAl(Kitap k, Kullanici kullanici)
        {
            k.OduncAlmaTarihi = DateTime.Now;
            kitaplar.Remove(k);
            kullanici.OduncAlinanKitaplar.Add(k);
        }
        public void KitapTeslimEt(Kitap k, Kullanici kullanici)
        {
            k.OduncAlmaTarihi = null;
            kullanici.OduncAlinanKitaplar.Remove(k);
            kitaplar.Add(k);
        }
    }
}
