using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class TalepSikayet
    {
        public int ID { get; set; }
        public string Talep_Sikayet { get; set; } = null!;
        public string Acıklama { get; set; } = null!;
        public bool OkunduMu { get; set; }

        public int KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
