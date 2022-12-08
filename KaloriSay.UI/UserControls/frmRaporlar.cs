using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
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
    public partial class frmRaporlar : UserControl
    {
        public frmRaporlar()
        {
            InitializeComponent();         
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            UygulamaVerileriGetir();
        }

        private void UygulamaVerileriGetir()
        {
            using KaloriSayContext _db = new KaloriSayContext();
            dgv_Raporlar.DataSource = _db.Kullanicilar.Select(x => new {
                x.ID,
                x.Ad,
                x.Soyad,
                x.KayitOlmaTarihi,
            }).ToList();
            lbl_TalepSikayetSayisi.Text = _db.TalepSikayetler.Where(x=>x.OkunduMu==false).Count().ToString();
            lbl_KayitliUye.Text = _db.Kullanicilar.Count().ToString();
            lbl_AktifUye.Text = _db.Kullanicilar.Where(x => x.Statu == KullanıcıStatu.Aktif).Count().ToString();
            lbl_PasifUye.Text = _db.Kullanicilar.Where(x => x.Statu == KullanıcıStatu.Pasif).Count().ToString();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            UygulamaVerileriGetir();
        }
    }
}
