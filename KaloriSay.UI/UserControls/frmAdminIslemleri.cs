using KaloriSay.BL.Repositories;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
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
    public partial class frmAdminIslemleri : UserControl
    {
        
        AdminIslemleriDal adminIslemleri;
        public frmAdminIslemleri()
        {
            InitializeComponent();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using KaloriSayContext _db = new KaloriSayContext();
            adminIslemleri = new AdminIslemleriDal(_db);
            dgv_Adminler.DataSource = _db.Adminler.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.Email,
                x.Sifre,                
                x.Statu
            }).ToList();
        }
        Admin seciliAdmin;
        private void btn_YoneticiEkle_Click(object sender, EventArgs e)
        {
            using KaloriSayContext _db = new KaloriSayContext();
            adminIslemleri = new AdminIslemleriDal(_db);
            Admin admin = new Admin();
            try
            {
                if (!KontrolMetotlari.BosAlanVarmı(pnl_Yonetici))
                {
                    admin.Ad = txt_KullaniciAdi.Text.Trim();
                    admin.Soyad = txt_KullaniciSoyadi.Text.Trim();
                    admin.Email = txt_KullaniciMail.Text.Trim();                    
                    admin.Statu = rb_Aktif.Checked ? KullanıcıStatu.Aktif : KullanıcıStatu.Pasif;
                    if (SifreKontrol.SifreGecerliMi(txt_YoneticiSifre.Text.Trim()))
                    {
                        admin.Sifre = txt_YoneticiSifre.Text.Trim();
                        adminIslemleri.Ekle(admin);
                        MessageBox.Show("Yönetici Eklendi.");
                        Listele();
                        seciliAdmin = null;
                        KontrolMetotlari.Temizle(pnl_Yonetici);
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

        private void btn_YoneticiGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliAdmin != null)
            {
                if (!KontrolMetotlari.BosAlanVarmı(pnl_Yonetici))
                {
                    seciliAdmin.Ad = txt_KullaniciAdi.Text.Trim();
                    seciliAdmin.Soyad = txt_KullaniciSoyadi.Text.Trim();
                    seciliAdmin.Email = txt_KullaniciMail.Text.Trim();                    
                    seciliAdmin.Statu = rb_Aktif.Checked ? KullanıcıStatu.Aktif : KullanıcıStatu.Pasif;
                    if (SifreKontrol.SifreGecerliMi(txt_YoneticiSifre.Text.Trim()))
                    {
                        seciliAdmin.Sifre = txt_YoneticiSifre.Text.Trim();
                        adminIslemleri.Guncelle();
                        MessageBox.Show("Yönetici Güncellendi.");
                        Listele();
                        seciliAdmin = null;
                        KontrolMetotlari.Temizle(pnl_Yonetici);
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
                MessageBox.Show("Lütfen Yönetici Seçiniz.");
        }

        private void btn_YoneticiSil_Click(object sender, EventArgs e)
        {
            if (seciliAdmin != null)
            {
                adminIslemleri.Sil(seciliAdmin);
                MessageBox.Show("Yönetici Silinmiştir.");
                Listele();
                seciliAdmin = null;
                KontrolMetotlari.Temizle(pnl_Yonetici);
            }
            else
                MessageBox.Show("Lütfen Kullanıcı Seçiniz.");
        }

        private void dgv_Adminler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliAdmin = null!;
            KontrolMetotlari.Temizle(pnl_Yonetici);
        }

        private void dgv_Adminler_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Adminler.RowCount>0)
            {
                int seciliID = Convert.ToInt32(dgv_Adminler.CurrentRow.Cells[0].Value);
                seciliAdmin = adminIslemleri.IdyeGoreGetir(seciliID);
                txt_KullaniciAdi.Text = seciliAdmin.Ad;
                txt_KullaniciSoyadi.Text = seciliAdmin.Soyad;
                txt_KullaniciMail.Text = seciliAdmin.Email;
                if (seciliAdmin.Statu == KullanıcıStatu.Aktif)
                    rb_Aktif.Checked = true;
                else
                    rb_Pasif.Checked = true; 
            }
        }                
    }
}
