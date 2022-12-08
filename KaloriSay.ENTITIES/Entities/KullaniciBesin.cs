using KaloriSay.ENTITIES.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class KullaniciBesin
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public int BesinID { get; set; }
        public double AlınanMiktar { get; set; }
        public string Birim { get; set; }
        public double AlınanKalori { get; set; }
        public Ogun Ogun { get; set; }
        public string OgunEklenmeTarihi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }


        public virtual Kullanici BesininKullanicisi{ get; set; }
        public virtual Besin KullanicininBesini { get; set; }
    }
}
