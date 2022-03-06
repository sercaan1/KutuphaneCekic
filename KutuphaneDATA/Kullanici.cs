using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDATA
{
    public class Kullanici
    {
        public List<Kitap> OduncAlinanKitaplar { get; set; } = new List<Kitap>();
        public Kullanici()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
