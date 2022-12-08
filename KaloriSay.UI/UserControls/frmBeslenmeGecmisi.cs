using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriSay.UI.UserControls
{
    public partial class frmBeslenmeGecmisi : UserControl
    {
        KaloriSayContext _db;
        int sistemdekiKullaniciID;
        public frmBeslenmeGecmisi()
        {
            InitializeComponent();
            _db = new KaloriSayContext();
            sistemdekiKullaniciID = _db.Kullanicilar.FirstOrDefault(x => x.Email == Properties.Settings.Default.HatirlanacakMail).ID;

        }

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {

            DateTime baslangıc = dtp_Baslangic.Value;
            DateTime bitis = dtp_Bitis.Value;

            dgv_BeslenmeGecmisi.DataSource = (from ke in _db.KullanıcıEtkilesim
                                              join besin in _db.Besinler on ke.BesinID equals besin.ID
                                              where ke.OlusturulmaTarihi >= baslangıc && ke.OlusturulmaTarihi <= bitis
                                              && ke.BesininKullanicisi.Email == Properties.Settings.Default.HatirlanacakMail
                                              select new
                                              {
                                                  besin.Adi,
                                                  ke.AlınanMiktar,
                                                  ke.Birim,
                                                  ke.AlınanKalori,
                                                  ke.Ogun,
                                                  ke.OlusturulmaTarihi
                                              }).ToList();
        }

        private void btn_TumunuGöster_Click(object sender, EventArgs e)
        {
            TumVerileriGetir();
        }
        private void TumVerileriGetir()
        {
            dgv_BeslenmeGecmisi.DataSource = (from ke in _db.KullanıcıEtkilesim
                                              join besin in _db.Besinler on ke.BesinID equals besin.ID
                                              where ke.BesininKullanicisi.Email == Properties.Settings.Default.HatirlanacakMail
                                              select new
                                              {
                                                  besin.Adi,
                                                  ke.AlınanMiktar,
                                                  ke.Birim,
                                                  ke.AlınanKalori,
                                                  ke.Ogun,
                                                  ke.OlusturulmaTarihi
                                              }).ToList();
        }
    }
}
