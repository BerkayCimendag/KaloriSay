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

namespace KaloriSay.UI
{
    public partial class KullaniciPanelForm : Form
    {
        KaloriSayContext _db;
        Kullanici girisYapanKullanici;        
        
        public KullaniciPanelForm()
        {
            InitializeComponent();
            _db= new KaloriSayContext();
            VerileriGetir();            
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CıkısYap_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Application.Restart();
            }
        }       

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol);
            VerileriGetir();
        }
        private void btn_OgunOlustur_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmOgunOlustur1);
            VerileriGetir();
        }

        private void btn_VkiHesapla_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmbmıHesaplama1);
            VerileriGetir();
        }

        private void btn_IdealKiloHesapla_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmIdealKiloHesapla1);
            VerileriGetir();

        }

        private void btn_BeslenmeGecmisi_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmBeslenmeGecmisi1);
            VerileriGetir();

        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmAyarlar1);
            VerileriGetir();
        }

        private void btn_Iletisim_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserKontrol, frmIletisim1);
            VerileriGetir();
        }
        private void UserControlGoster(Panel panel, UserControl userControl = null!)
        {
            foreach (var _userControl in panel.Controls)
            {
                if (_userControl is not PictureBox)
                {
                    if (_userControl == userControl)
                        ((UserControl)_userControl).Visible = true;
                    else
                        ((UserControl)_userControl).Visible = false;
                }               

            }
        }
        private void VerileriGetir()
        {
            girisYapanKullanici = _db.Kullanicilar.FirstOrDefault(x => x.Email == Properties.Settings.Default.HatirlanacakMail);
            lbl_AdSoyad.Text = girisYapanKullanici.AdSoyad;
            lbl_Kalori.Text = girisYapanKullanici.GunlukKalori.ToString("00.0");
            lbl_Kahvaltı.Text = UserControlMetotları.EnCokTercihEdilenBesinGetir(_db,Ogun.Sabah);
            lbl_OgleYemegi.Text = UserControlMetotları.EnCokTercihEdilenBesinGetir(_db, Ogun.Ogle);
            lbl_AksamYemegi.Text = UserControlMetotları.EnCokTercihEdilenBesinGetir(_db, Ogun.Aksam);
            lbl_AraOgun.Text = UserControlMetotları.EnCokTercihEdilenBesinGetir(_db, Ogun.AraOgun);
        }
    }
}
