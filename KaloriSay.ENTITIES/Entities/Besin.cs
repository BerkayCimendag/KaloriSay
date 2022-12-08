using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class Besin
    {
        public int ID { get; set; }
        public string Adi { get; set; } = null!;
        public double Miktar { get; set; }
        public string Birim { get; set; } = null!;
        public string Porsiyon { get; set; } = null!;
        public double Karbonhidrat { get; set; }
        public double Protein { get; set; }
        public double Yag { get; set; }
        public double Kalori { get; set; }
        public string? BesinResmiUzantisi { get; set; }
        public byte[]? BesinResim { get; set; }


        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public virtual ICollection<KullaniciBesin> BesininKullanicilari { get; set; }

    }
}
