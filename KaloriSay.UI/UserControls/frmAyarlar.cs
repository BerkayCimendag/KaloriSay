using KaloriSay.BL.Repositories;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.UI.Metotlar;
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
    public partial class frmAyarlar : UserControl
    {
        KaloriSayContext _db;
        KullaniciIslemleriDal kullaniciIslemleri;
        Kullanici guncellenecekKullanici;
        public frmAyarlar()
        {
            InitializeComponent();
            _db = new KaloriSayContext();
            kullaniciIslemleri = new KullaniciIslemleriDal(_db);
            guncellenecekKullanici = _db.Kullanicilar.FirstOrDefault(x => x.Email == Properties.Settings.Default.HatirlanacakMail);
            BilgileriGetir();
        }


        private void btn_BilgiGuncelle_Click(object sender, EventArgs e)
        {

            string sifre = txt_Sifre.Text;
            string sifreTekrar = txt_SifreTekrar.Text;

            if (!KontrolMetotlari.BosAlanVarmı(pnl_Ayarlar))
            {
                try
                {
                    if (Convert.ToDouble(txt_Boy.Text) > 100 && Convert.ToDouble(txt_Boy.Text)<300)
                        guncellenecekKullanici.Boy = Convert.ToDouble(txt_Boy.Text);
                    else if (Convert.ToDouble(txt_Boy.Text) > 0 && Convert.ToDouble(txt_Boy.Text) < 3)
                        guncellenecekKullanici.Boy = Convert.ToDouble(txt_Boy.Text) * 100;
                    else
                        guncellenecekKullanici.Boy = 160;
                    if (Convert.ToDouble(txt_Kilo.Text) > 0 && Convert.ToDouble(txt_Kilo.Text)<200)
                        guncellenecekKullanici.Kilo = Convert.ToDouble(txt_Kilo.Text);
                    if (Convert.ToInt32(txt_Yas.Text) > 0 && Convert.ToInt32(txt_Yas.Text)<200)
                        guncellenecekKullanici.Yas = Convert.ToInt32(txt_Yas.Text);
                    guncellenecekKullanici.GunlukKalori = UserControlMetotları.HarrisBenedict(guncellenecekKullanici.Yas, guncellenecekKullanici.Boy,guncellenecekKullanici.Kilo, guncellenecekKullanici.Aktivite);
                    if (txt_Sifre.Text != string.Empty)
                    {
                        if (SifreKontrol.SifreGecerliMi(sifre))
                        {
                            if (sifre == sifreTekrar)
                            {
                                DialogResult dr = new DialogResult();
                                dr = MessageBox.Show("Güncelleme İşlemi Sonrası Tekrar Giriş Yapmanız Gerekmektedir.", "Üyelik Güncelleme", MessageBoxButtons.YesNo);
                                if (dr == DialogResult.Yes)
                                {
                                    guncellenecekKullanici.Sifre = sifre;
                                    
                                    kullaniciIslemleri.Guncelle();
                                    MessageBox.Show("Ayarlarınız Kaydedildi.");
                                    Application.Restart();
                                }
                            }
                            else
                                UserControlMetotları.LblUyari("Şifreniz Uyuşmuyor.", lbl_AyarBilgilendirme);
                        }
                        else
                        {
                            UserControlMetotları.LblUyari("Şifreniz Kriterlere Uymuyor", lbl_AyarBilgilendirme);
                            lbl_Sifre.Visible = true;
                        }
                    }
                    else
                    {
                        DialogResult dr = new DialogResult();
                        dr = MessageBox.Show("Güncelleme İşlemi Sonrası Tekrar Giriş Yapmanız Gerekmektedir.", "Üyelik Güncelleme", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            kullaniciIslemleri.Guncelle();
                            MessageBox.Show("Ayarlarınız Kaydedildi.");
                            Application.Restart();
                        }
                    }

                }
                catch (Exception)
                {

                    UserControlMetotları.LblUyari("Lütfen Bilgileri Kontrol Ediniz.", lbl_AyarBilgilendirme);
                }
            }
            else
                UserControlMetotları.LblUyari("Boş Alan Bırakmayınız.", lbl_AyarBilgilendirme);


        }

        private void txt_Boy__TextChanged(object sender, EventArgs e)
        {
            lbl_AyarBilgilendirme.Visible = false;
            lbl_Sifre.Visible = false;
        }
        private void BilgileriGetir()
        {
            txt_Boy.Text = guncellenecekKullanici.Boy.ToString();
            txt_Kilo.Text = guncellenecekKullanici.Kilo.ToString();
            txt_Yas.Text = guncellenecekKullanici.Yas.ToString();
        }

        private void btn_UyelikSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Üyeliğinizi Silmek İstediğinize Emin Misiniz?", "Üyelik Silme", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                kullaniciIslemleri.Sil(guncellenecekKullanici);
                Application.Restart();
            }
        }
    }
}
