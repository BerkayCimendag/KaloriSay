using KaloriSay.BL.Repositories;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
using KaloriSay.UI.Metotlar;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriSay.UI.UserControls
{
    public partial class frmKullaniciIslemleri : UserControl
    {
        KullaniciIslemleriDal kullaniciIslemleri;
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
            cmb_GunlukAktivite.SelectedIndex = 0;
        }

        private void Listele()
        {
            KaloriSayContext _db = new KaloriSayContext();
            kullaniciIslemleri = new KullaniciIslemleriDal(_db);
            dgv_Kullanicilar.DataSource = _db.Kullanicilar.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.Email,
                x.Sifre,
                x.Boy,
                x.Yas,
                x.Kilo,
                x.Statu
            }).ToList();
        }

        Kullanici seciliKullanici;
        private void dgv_Kullanicilar_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Kullanicilar.RowCount>0)
            {
                int seciliID = Convert.ToInt32(dgv_Kullanicilar.CurrentRow.Cells[0].Value);
                seciliKullanici = kullaniciIslemleri.IdyeGoreGetir(seciliID);
                txt_KullaniciAdi.Text = seciliKullanici.Ad;
                txt_KullaniciSoyadi.Text = seciliKullanici.Soyad;
                txt_KullaniciMail.Text = seciliKullanici.Email;
                txt_kullaniciBoy.Text = seciliKullanici.Boy.ToString();
                txt_KullaniciYas.Text = seciliKullanici.Yas.ToString();
                txt_KullaniciKilo.Text = seciliKullanici.Kilo.ToString();
                if (seciliKullanici.Statu == KullanıcıStatu.Aktif)
                    rb_AktifKullanici.Checked = true;
                else
                    rb_PasifKullanici.Checked = true; 
            }
        }
        private void dgv_Kullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliKullanici = null!;
            KontrolMetotlari.Temizle(pnl_KullaniciIslemleri);
        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            KaloriSayContext _db = new KaloriSayContext();
            kullaniciIslemleri = new KullaniciIslemleriDal(_db);
            Kullanici kullanici = new Kullanici();
            try
            {
                if (!KontrolMetotlari.BosAlanVarmı(pnl_KullaniciIslemleri))
                {
                    kullanici.Ad = txt_KullaniciAdi.Text.Trim();
                    kullanici.Soyad = txt_KullaniciSoyadi.Text.Trim();
                    kullanici.Email = txt_KullaniciMail.Text.Trim();

                    if (Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) > 100 && Convert.ToDouble(txt_kullaniciBoy.Text.Trim())<300)
                        kullanici.Boy = Convert.ToDouble(txt_kullaniciBoy.Text.Trim());
                    else if (Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) > 0 && Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) < 3)
                        kullanici.Boy = Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) * 100;
                    else
                        kullanici.Boy = 160;
                    if (Convert.ToInt32(txt_KullaniciYas.Text.Trim()) > 0 && Convert.ToInt32(txt_KullaniciYas.Text.Trim())<200)
                        kullanici.Yas = Convert.ToInt32(txt_KullaniciYas.Text.Trim());
                    if (Convert.ToDouble(txt_KullaniciKilo.Text.Trim()) > 0 && Convert.ToDouble(txt_KullaniciKilo.Text.Trim()) < 200 )
                        kullanici.Kilo = Convert.ToDouble(txt_KullaniciKilo.Text.Trim());
                    kullanici.Statu = rb_AktifKullanici.Checked ? KullanıcıStatu.Aktif : KullanıcıStatu.Pasif;
                    if (cmb_GunlukAktivite.Text == "Düşük Tempo Aktivite")
                        kullanici.Aktivite = Aktivite.DusukTempoAktivite;
                    else if (cmb_GunlukAktivite.Text == "Orta Tempo Aktivite")
                        kullanici.Aktivite = Aktivite.OrtaTempoAktivite;
                    else if (cmb_GunlukAktivite.Text == "Yüksek Tempo Aktivite)")
                        kullanici.Aktivite = Aktivite.YuksekTempoAktivite;
                    if (SifreKontrol.SifreGecerliMi(txt_KullaniciSifre.Text.Trim()))
                    {
                        kullanici.Sifre = txt_KullaniciSifre.Text;
                        kullanici.GunlukKalori = UserControlMetotları.HarrisBenedict(kullanici.Yas, kullanici.Boy, kullanici.Kilo, kullanici.Aktivite);
                        kullaniciIslemleri.Ekle(kullanici);
                        MessageBox.Show("Kullanıcı Eklendi.");
                        Listele();
                        seciliKullanici = null;
                        KontrolMetotlari.Temizle(pnl_KullaniciIslemleri);
                    }
                    else
                    {
                        lbl_Sifre.Visible = true;
                    }

                }
                else
                    MessageBox.Show("Boş Alan Bırakmayınız.");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz.");
            }
        }

        private void btn_KullaniciGuncelle_Click(object sender, EventArgs e)
        {

            if (seciliKullanici != null)
            {
                if (!KontrolMetotlari.BosAlanVarmı(pnl_KullaniciIslemleri))
                {
                    seciliKullanici.Ad = txt_KullaniciAdi.Text.Trim();
                    seciliKullanici.Soyad = txt_KullaniciSoyadi.Text.Trim();
                    seciliKullanici.Email = txt_KullaniciMail.Text.Trim();
                    if (Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) > 100 && Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) < 300)
                        seciliKullanici.Boy = Convert.ToDouble(txt_kullaniciBoy.Text.Trim());
                    else if (Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) > 0 && Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) < 3)
                        seciliKullanici.Boy = Convert.ToDouble(txt_kullaniciBoy.Text.Trim()) * 100;
                    else
                        seciliKullanici.Boy = 160;
                    if (Convert.ToInt32(txt_KullaniciYas.Text.Trim()) > 0 && Convert.ToInt32(txt_KullaniciYas.Text.Trim()) < 200)
                        seciliKullanici.Yas = Convert.ToInt32(txt_KullaniciYas.Text.Trim());
                    if (Convert.ToDouble(txt_KullaniciKilo.Text.Trim()) > 0 && Convert.ToDouble(txt_KullaniciKilo.Text.Trim()) < 200)
                        seciliKullanici.Kilo = Convert.ToDouble(txt_KullaniciKilo.Text.Trim());
                    seciliKullanici.Statu = rb_AktifKullanici.Checked ? KullanıcıStatu.Aktif : KullanıcıStatu.Pasif;
                    if ( SifreKontrol.SifreGecerliMi(txt_KullaniciSifre.Text.Trim()))
                    {
                        seciliKullanici.Sifre = txt_KullaniciSifre.Text.Trim();
                        kullaniciIslemleri.Guncelle();
                        MessageBox.Show("Kullanıcı Güncellendi.");
                        Listele();
                        seciliKullanici = null;
                        KontrolMetotlari.Temizle(pnl_KullaniciIslemleri);
                    }
                    else if(txt_KullaniciSifre.Text.Trim() == string.Empty)
                    {
                        kullaniciIslemleri.Guncelle();
                        MessageBox.Show("Kullanıcı Güncellendi.");
                        Listele();
                        seciliKullanici = null;
                        KontrolMetotlari.Temizle(pnl_KullaniciIslemleri);
                    }                        
                    else
                    {
                        lbl_Sifre.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Boş Alan Bırakmayınız.");

            }
            else
                MessageBox.Show("Lütfen Kullanıcı Seçiniz.");
        }

        private void btn_KullaniciSil_Click(object sender, EventArgs e)
        {
            if (seciliKullanici != null)
            {
                kullaniciIslemleri.Sil(seciliKullanici);
                MessageBox.Show("Kullanıcı Silinmiştir.");
                Listele();
                seciliKullanici = null;
                KontrolMetotlari.Temizle(pnl_KullaniciIslemleri);
            }
            else
                MessageBox.Show("Lütfen Kullanıcı Seçiniz.");
        }

        private void txt_KullaniciAdi__TextChanged(object sender, EventArgs e)
        {
            lbl_Sifre.Visible = false;
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
