using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDATA
{
    public class TeslimSuresiEventArgs : EventArgs
    {
        public TeslimSuresiEventArgs(DateTime oduncSuresi)
        {
            OduncAlmaZamani = oduncSuresi;
        }
        public DateTime OduncAlmaZamani { get; set; }
    }
}
