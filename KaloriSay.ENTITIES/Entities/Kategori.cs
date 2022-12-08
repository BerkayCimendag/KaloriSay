using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class Kategori
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; } = null!;
        public ICollection<Besin> Besinler { get; set; } 

    }
}
