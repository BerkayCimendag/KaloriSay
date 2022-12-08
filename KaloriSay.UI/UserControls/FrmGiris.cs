using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
using KaloriSay.UI.Metotlar;

namespace KaloriSay.UI
{
    public partial class FrmGiris : UserControl
    {

        public FrmGiris()
        {
            InitializeComponent();
            UserControlMetotları.BeniHatirlaYukle(txt_Mail, txt_Sifre, cb_BeniHatirla);
            lbl_GirisBilgilendirme.Visible = false;

        }
        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using KaloriSayContext _db = new KaloriSayContext();
                if (!KontrolMetotlari.BosAlanVarmı(pnl_KullaniciGirisi))
                {
                    string mail = txt_Mail.Text.Trim();
                    string sifre = txt_Sifre.Text.Trim();
                    var girisYapacakKullanici = _db.Kullanicilar.FirstOrDefault(x => x.Email == mail);
                    if (girisYapacakKullanici.Statu == KullanıcıStatu.Aktif)
                    {                        
                        if (girisYapacakKullanici != null && girisYapacakKullanici.Sifre == Sifreleme.Sifrele(sifre) && MailKontrol.MailGecerliMi(mail))
                        {
                            Properties.Settings.Default.HatirlanacakMail = mail;
                            KullaniciPanelForm kullaniciPanel = new KullaniciPanelForm();
                            kullaniciPanel.Show();
                            UserControlMetotları.BeniHatirlaKaydet(txt_Mail, txt_Sifre, cb_BeniHatirla);
                            ((AnaForm)this.TopLevelControl).Hide();
                        }
                        else
                            UserControlMetotları.LblUyari("Mail Adresi Veya Şifreniz Yanlış", lbl_GirisBilgilendirme);
                    }
                    else
                        UserControlMetotları.LblUyari("Kullanıcı Bilgileri Aktif Değildir.", lbl_GirisBilgilendirme);
                }
                else
                    UserControlMetotları.LblUyari("Lütfen Boş Alan Bırakmayınız.", lbl_GirisBilgilendirme);
            }
            catch (Exception)
            {
                UserControlMetotları.LblUyari("Mail Adresi Veya Şifreniz Yanlış.", lbl_GirisBilgilendirme);
            }
        }

        private void btn_YoneticiGiris_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris1.Visible = true;
        }

        private void btn_ProjeYoneticisiGiris_Click(object sender, EventArgs e)
        {
            frmProjeYoneticisiGirisi1.Visible = true;
        }

        private void txt_Mail__TextChanged(object sender, EventArgs e)
        {
            lbl_GirisBilgilendirme.Visible = false;
        }


    }
}
