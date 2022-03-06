using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDATA
{
    public class KullaniciYoneticisi
    {
        public List<Kullanici> kullanicilar { get; set; } = new List<Kullanici>();
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            return kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            Kullanici k = kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == parola);
            return k;
        }
    }
}
