using KaloriSay.BL.Repositories;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
using KaloriSay.UI.Metotlar;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriSay.UI
{
    public partial class FrmKayitDevamForm : UserControl
    {
        
        KullaniciIslemleriDal kullaniciIslemleri;
        public FrmKayitDevamForm()
        {
            InitializeComponent();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frmKayitFormu1.Visible = true;
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {            
            if (!KontrolMetotlari.BosAlanVarmı(pnl_KayitDevam))
            {
                using KaloriSayContext _db = new KaloriSayContext();
                kullaniciIslemleri = new KullaniciIslemleriDal(_db);            
                int Boy;
                int Yas = Convert.ToInt32(nud_Yas.Value);

                if (nud_Boy.Value > 100)
                    Boy = Convert.ToInt32(nud_Boy.Value);
                else if (nud_Boy.Value > 0 && nud_Boy.Value < 3)
                    Boy = Convert.ToInt32(nud_Boy.Value) * 100;
                else
                    Boy = 160;
                int Kilo = Convert.ToInt32(nud_Kilo.Value);
                

                Kullanici yeniKullanici = new Kullanici();
                yeniKullanici.Ad = Properties.Settings.Default.Adi;
                yeniKullanici.Soyad = Properties.Settings.Default.Soyadi;
                yeniKullanici.Email = Properties.Settings.Default.Email;
                yeniKullanici.Sifre = Properties.Settings.Default.Sifre;
                yeniKullanici.Yas = Yas;
                yeniKullanici.Boy = Boy;
                yeniKullanici.Kilo = Kilo;
                if (cmb_GunlukAktivite.Text == "Düşük Tempo Aktivite")
                    yeniKullanici.Aktivite = Aktivite.DusukTempoAktivite;
                else if (cmb_GunlukAktivite.Text == "Orta Tempo Aktivite")
                    yeniKullanici.Aktivite = Aktivite.OrtaTempoAktivite;
                else if (cmb_GunlukAktivite.Text == "Yüksek Tempo Aktivite)")
                    yeniKullanici.Aktivite = Aktivite.YuksekTempoAktivite;
                double GunlukKalori = UserControlMetotları.HarrisBenedict(Yas, Boy, Kilo, yeniKullanici.Aktivite);
                yeniKullanici.GunlukKalori = GunlukKalori;
                kullaniciIslemleri.Ekle(yeniKullanici);
                MessageBox.Show("Kayıt Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
                UserControlMetotları.KullaniciAyarBilgileriSifirla();
            }
            else            
                lbl_KayitDevamBilgilendirme.Visible = true;            
        }

        private void nud_Yas_MouseUp(object sender, MouseEventArgs e)
        {
            lbl_KayitDevamBilgilendirme.Visible = false;
        }

        
    }
}
