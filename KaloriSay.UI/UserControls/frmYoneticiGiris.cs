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
    public partial class frmYoneticiGiris : UserControl
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using KaloriSayContext _db = new KaloriSayContext();
                if (!KontrolMetotlari.BosAlanVarmı(pnl_YoneticiGiris))
                {
                    string mail = txt_Mail.Text.Trim();
                    string sifre = txt_Sifre.Text.Trim(); ;
                    var girisYapacakKullanici = _db.Adminler.FirstOrDefault(x => x.Email == mail);
                    if (girisYapacakKullanici.Statu == KullanıcıStatu.Aktif)
                    {
                        if (girisYapacakKullanici != null && girisYapacakKullanici.Sifre == Sifreleme.Sifrele(sifre) && MailKontrol.MailGecerliMi(mail))
                        {
                            YoneticiPanelForm yoneticiPanel = new YoneticiPanelForm();
                            yoneticiPanel.Show();
                            ((AnaForm)this.TopLevelControl).Hide();
                        }
                        else
                            UserControlMetotları.LblUyari("Mail Adresi Veya Şifreniz Yanlış", lbl_YoneticiBilgilendirme);
                    }
                    else
                        UserControlMetotları.LblUyari("Kullanıcı Bilgileri Aktif Değildir.", lbl_YoneticiBilgilendirme);
                }
                else
                    UserControlMetotları.LblUyari("Lütfen Boş Alan Bırakmayınız.", lbl_YoneticiBilgilendirme);

            }
            catch (Exception)
            {
                UserControlMetotları.LblUyari("Mail Adresi Veya Şifreniz Yanlış.", lbl_YoneticiBilgilendirme);
            }
        }
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txt_Mail__TextChanged(object sender, EventArgs e)
        {
            lbl_YoneticiBilgilendirme.Visible = false;
        }
    }
}
