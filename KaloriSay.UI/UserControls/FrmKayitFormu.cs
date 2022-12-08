using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.UI.Metotlar;
using KaloriSay.UI.UserControls;
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
    public partial class FrmKayitFormu : UserControl
    {
        
        public FrmKayitFormu()
        {
            InitializeComponent();

        }
        private void btn_Ileri_Click(object sender, EventArgs e)
        {           
            try
            {
                using KaloriSayContext _db = new KaloriSayContext();
                string mail = txt_Mail.Text.Trim();
                string sifre = txt_Sifre.Text.Trim();
                string SifreTekrar = txt_SifreTekrar.Text.Trim();
                if (!KontrolMetotlari.BosAlanVarmı(pnl_KayitOl))
                {
                    if (_db.Kullanicilar.FirstOrDefault(x => x.Email == mail) == null)
                    {
                        if (MailKontrol.MailGecerliMi(mail))
                        {
                            if (SifreKontrol.SifreGecerliMi(sifre))
                            {
                                if (sifre == SifreTekrar)
                                {
                                    this.Visible = false;
                                    Properties.Settings.Default.Adi = txt_Ad.Text.Trim();
                                    Properties.Settings.Default.Soyadi = txt_Soyad.Text.Trim();
                                    Properties.Settings.Default.Email = txt_Mail.Text.Trim();
                                    Properties.Settings.Default.Sifre = txt_Sifre.Text.Trim();
                                }
                                else
                                    UserControlMetotları.LblUyari("Şifreler Uyuşmuyor", lbl_BilgilendirmeKayit);
                            }
                            else
                            {
                                UserControlMetotları.LblUyari("Şifrenizi Belirtilen Formatta Giriniz", lbl_BilgilendirmeKayit);
                                lbl_Sifre.Visible = true;
                            }
                        }
                        else
                            UserControlMetotları.LblUyari("Lütfen Mail Adresinizi Kontrol Ediniz", lbl_BilgilendirmeKayit);
                    }
                    else
                        UserControlMetotları.LblUyari("Bu Mail Adresi Kayıtlıdır.Başka Mail Adresi Deneyiniz", lbl_BilgilendirmeKayit);
                }
                else
                    UserControlMetotları.LblUyari("Boş Alan Bırakmayınız", lbl_BilgilendirmeKayit);
            }
            catch (Exception)
            {
                UserControlMetotları.LblUyari("Lütfen Adınızı Veya Soyadınızı Doğru Giriniz", lbl_BilgilendirmeKayit);
            }
        }

        private void pb_ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Sifre.PasswordChar = true;
            txt_SifreTekrar.PasswordChar = true;
        }

        private void pb_ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Sifre.PasswordChar = false;
            txt_SifreTekrar.PasswordChar = false;
        }

        private void txt_Ad__TextChanged(object sender, EventArgs e)
        {
            lbl_BilgilendirmeKayit.Visible = false;
            lbl_Sifre.Visible = false;
        }
    }
}
