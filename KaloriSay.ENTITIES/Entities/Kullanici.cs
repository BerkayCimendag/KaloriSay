using KaloriSay.ENTITIES.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class Kullanici : BaseKullanici
    {
        public double Boy { get; set; }
        public int Yas { get; set; }
        public double Kilo { get; set; }
        public Aktivite Aktivite { get; set; }
        public double GunlukKalori { get; set; }

        public virtual ICollection<TalepSikayet> KullanicininSikayetleri { get; set; } 
        public virtual ICollection<KullaniciBesin> KullanicininBesinleri { get; set; } 
    }

    
}
