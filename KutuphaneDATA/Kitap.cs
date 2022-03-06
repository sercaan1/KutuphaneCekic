using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDATA
{
    public class Kitap
    {
        public Kitap()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string YazarAd { get; set; }
        public string Aciklama { get; set; }
        public int SayfaSayisi { get; set; }
        public EnumKitapTuru Tur { get; set; }
        public int Adet { get; set; } = 1;
        public DateTime? BasimTarihi { get; set; }
        public DateTime? OduncAlmaTarihi { get; set; }
    }
}
