using KaloriSay.ENTITIES.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class BaseKullanici
    {
        
        public int ID { get; set; }      

        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }

        }
        public string Email { get; set; } = null!;

        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = Sifreleme.Sifrele(value); }
        }
        
        public KullanıcıStatu Statu { get; set; } = KullanıcıStatu.Aktif;
        public DateTime KayitOlmaTarihi { get; set; }



    }

}
