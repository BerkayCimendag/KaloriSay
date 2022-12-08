using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.ENTITIES.Enumlar;
using KullaniciPanel.EjderhaControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.UI.Metotlar
{
    public class UserControlMetotları
    {
        public static void BeniHatirlaYukle(EjderhaTextBox txt_Mail, EjderhaTextBox txt_Sifre, CheckBox cb_BeniHatirla)
        {
            txt_Mail.Text = Properties.Settings.Default.HatirlanacakMail;
            txt_Sifre.Text = Properties.Settings.Default.HatirlanacakSifre;
            if (Properties.Settings.Default.Hatirla)
                cb_BeniHatirla.Checked = true;
            else
                cb_BeniHatirla.Checked = false;
        }
        public static void BeniHatirlaKaydet(EjderhaTextBox txt_Mail, EjderhaTextBox txt_Sifre, CheckBox cb_BeniHatirla)
        {
            if (cb_BeniHatirla.Checked)
            {
                Properties.Settings.Default.HatirlanacakMail = txt_Mail.Text;
                Properties.Settings.Default.HatirlanacakSifre = txt_Sifre.Text;
                Properties.Settings.Default.Hatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {                
                Properties.Settings.Default.HatirlanacakSifre = string.Empty;
                Properties.Settings.Default.Hatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        public static double HarrisBenedict(int yas, double boy, double kilo,Aktivite aktivite)
        {
            double _aktivite;
            if (aktivite == Aktivite.DusukTempoAktivite)
                _aktivite = 1.2;
            else if (aktivite == Aktivite.OrtaTempoAktivite)
                _aktivite = 1.375;
            else
                _aktivite = 1.55;
            double BMR = 655 + 9.6 * kilo + 1.8 * boy - 4.7 * yas;
            return BMR * _aktivite;
        }
        public static void KullaniciAyarBilgileriSifirla()
        {
            Properties.Settings.Default.Adi = string.Empty;
            Properties.Settings.Default.Soyadi = string.Empty;
            Properties.Settings.Default.Sifre = string.Empty;
            Properties.Settings.Default.Email = string.Empty;
        }
        public static void LblUyari(string msj, Label lbl)
        {
            lbl.Text = msj;
            lbl.Visible = true;
        }
        public static string EnCokTercihEdilenBesinGetir(KaloriSayContext _db,Ogun ogun)
        {
            string besinAdi;
            var EnCokTercihEdilenler = (from ke in _db.KullanıcıEtkilesim
                                        where ke.Ogun == ogun
                                        group ke by ke.BesinID into TercihEdilenBesinler
                                        select new
                                        {

                                            Adet = TercihEdilenBesinler.Count(),
                                            BesinAdi = TercihEdilenBesinler.FirstOrDefault(x => x.BesinID == TercihEdilenBesinler.Key).KullanicininBesini.Adi

                                        }).ToList();
            string EnCokTerhicEdilenBesin;
            foreach (var item in EnCokTercihEdilenler)
            {
                if (item.Adet == EnCokTercihEdilenler.Max(x => x.Adet))
                {
                    EnCokTerhicEdilenBesin = item.BesinAdi.ToString();
                    return EnCokTerhicEdilenBesin;

                }
            }

            return "";
        }
        public static double KaloriHesapla(double _miktar,KaloriSayContext _db,ComboBox comboBox)
        {
            double BesinKalorisi = _db.Besinler.Find(((Besin)comboBox.SelectedItem).ID).Kalori;
            double Miktar = _db.Besinler.Find(((Besin)comboBox.SelectedItem).ID).Miktar;

            double alinanKalori = (_miktar * BesinKalorisi) / Miktar;
            return alinanKalori;

        }

        


    }
}
