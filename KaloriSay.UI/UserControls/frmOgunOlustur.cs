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
    public partial class frmOgunOlustur : UserControl
    {
        KaloriSayContext _db;
        KullaniciBesinIslemleriDal _kullaniciBesin;
        int sistemdekiKullaniciID;
        public frmOgunOlustur()
        {
            InitializeComponent();
            _db = new KaloriSayContext();
            cmb_Kategoriler.DisplayMember = "KategoriAdi";
            cmb_Kategoriler.DataSource = _db.Kategoriler.ToList();
            cmb_Besinler.DisplayMember = "Adi";
            rb_Kahvalti.Checked = true;
            _kullaniciBesin = new KullaniciBesinIslemleriDal(_db);
            sistemdekiKullaniciID = _db.Kullanicilar.FirstOrDefault(x => x.Email == Properties.Settings.Default.HatirlanacakMail).ID;
            listele();

        }

        private void cmb_Kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Besinler.DataSource =
                (from kategori in _db.Kategoriler join besin in _db.Besinler on ((Kategori)cmb_Kategoriler.SelectedItem).ID equals besin.KategoriID select besin).Distinct().ToList();
        }
        private void cmb_Besinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_MiktarBirim.Text = ((Besin)cmb_Besinler.SelectedItem).Birim.ToString();
            if (!string.IsNullOrWhiteSpace(((Besin)cmb_Besinler.SelectedItem).BesinResmiUzantisi))
            {
                pb_BesinResmi.Image = Image.FromFile("Images/" + ((Besin)cmb_Besinler.SelectedItem).BesinResmiUzantisi);
                pb_BesinResmi.Tag = Path.GetExtension(((Besin)cmb_Besinler.SelectedItem).BesinResmiUzantisi);
            }
            else
            {
                pb_BesinResmi.Image = null;
            }
        }
        private void btn_BesinEkle_Click(object sender, EventArgs e)
        {
            if (nud_Miktar.Value > 0)
            {
                if (!KontrolMetotlari.BosAlanVarmı(pnl_BesinEkle))
                {
                    KullaniciBesin kullaniciBesin = new KullaniciBesin();
                    kullaniciBesin.KullaniciID = sistemdekiKullaniciID;
                    kullaniciBesin.BesinID = ((Besin)cmb_Besinler.SelectedItem).ID;
                    kullaniciBesin.AlınanKalori = UserControlMetotları.KaloriHesapla(Convert.ToDouble(nud_Miktar.Value), _db, cmb_Besinler);
                    kullaniciBesin.Birim = lbl_MiktarBirim.Text;
                    kullaniciBesin.AlınanMiktar = Convert.ToDouble(nud_Miktar.Value);
                    if (rb_Kahvalti.Checked)
                        kullaniciBesin.Ogun = Ogun.Sabah;
                    else if (rb_OgleYemegi.Checked)
                        kullaniciBesin.Ogun = Ogun.Ogle;
                    else if (rb_AksamYemegi.Checked)
                        kullaniciBesin.Ogun = Ogun.Aksam;
                    else if (rb_AraOgun.Checked)
                        kullaniciBesin.Ogun = Ogun.AraOgun;
                    kullaniciBesin.OgunEklenmeTarihi = DateTime.Now.ToShortDateString();
                    kullaniciBesin.OlusturulmaTarihi = DateTime.Now;
                    _kullaniciBesin.Ekle(kullaniciBesin);
                    listele();
                    kullaniciEtkilesim = null;
                    KontrolMetotlari.Temizle(pnl_BesinEkle);

                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Miktarı Giriniz.");
            }
        }

        private void listele()
        {
            string bugun = DateTime.Now.ToShortDateString();
            dgv_Kahvaltı.DataSource = _db.KullanıcıEtkilesim.Where(x => x.KullaniciID == sistemdekiKullaniciID && x.Ogun == Ogun.Sabah && x.OgunEklenmeTarihi == bugun).Select(x => new { x.ID, x.KullanicininBesini.Adi, x.AlınanKalori }).ToList();
            dgv_Kahvaltı.Columns["ID"].Visible = false;

            dgv_OgleYemegi.DataSource = _db.KullanıcıEtkilesim.Where(x => x.KullaniciID == sistemdekiKullaniciID && x.Ogun == Ogun.Ogle && x.OgunEklenmeTarihi == bugun).Select(x => new { x.ID, x.KullanicininBesini.Adi, x.AlınanKalori }).ToList();
            dgv_OgleYemegi.Columns["ID"].Visible = false;

            dgv_AksamYemegi.DataSource = _db.KullanıcıEtkilesim.Where(x => x.KullaniciID == sistemdekiKullaniciID && x.Ogun == Ogun.Aksam && x.OgunEklenmeTarihi == bugun).Select(x => new { x.ID, x.KullanicininBesini.Adi, x.AlınanKalori }).ToList();
            dgv_AksamYemegi.Columns["ID"].Visible = false;

            dgv_AraOgun.DataSource = _db.KullanıcıEtkilesim.Where(x => x.KullaniciID == sistemdekiKullaniciID && x.Ogun == Ogun.AraOgun && x.OgunEklenmeTarihi == bugun).Select(x => new { x.ID, x.KullanicininBesini.Adi, x.AlınanKalori }).ToList();
            dgv_AraOgun.Columns["ID"].Visible = false;

            if (dgv_Kahvaltı.RowCount == 0 && dgv_AksamYemegi.RowCount == 0 && dgv_OgleYemegi.RowCount == 0 && dgv_AraOgun.RowCount == 0)
                lbl_AlinanKalori.Text = "00" + " " + "Kcal";
            else
                lbl_AlinanKalori.Text = _db.KullanıcıEtkilesim.Where(x => x.KullaniciID == sistemdekiKullaniciID).Sum(x => x.AlınanKalori).ToString("00" + " " + "Kcal");
        }

        KullaniciBesin kullaniciEtkilesim;
        int SeciliId;

        private void btn_BesinSİl_Click(object sender, EventArgs e)
        {
            if (SeciliId >= 0 && kullaniciEtkilesim != null)
            {
                _kullaniciBesin.Sil(kullaniciEtkilesim);
                listele();
                kullaniciEtkilesim = null;
                KontrolMetotlari.Temizle(pnl_BesinEkle);
            }
            else
            {
                MessageBox.Show("Silmek İstediğini Besini Seçiniz.");
            }
        }
        private void SecileniAktar()
        {
            var secilen = _kullaniciBesin.IdyeGoreGetir(SeciliId);
            cmb_Kategoriler.Text = _db.Besinler.FirstOrDefault(x => x.ID == secilen.BesinID).Kategori.KategoriAdi;
            cmb_Besinler.Text = _db.Besinler.FirstOrDefault(x => x.ID == secilen.BesinID).Adi;
            nud_Miktar.Value = Convert.ToDecimal(secilen.AlınanMiktar);
            if (secilen.Ogun == Ogun.Sabah)
                rb_Kahvalti.Checked = true;
            else if (secilen.Ogun == Ogun.Ogle)
                rb_OgleYemegi.Checked = true;
            else if (secilen.Ogun == Ogun.Aksam)
                rb_AksamYemegi.Checked = true;
            else if (secilen.Ogun == Ogun.AraOgun)
                rb_AraOgun.Checked = true;
            if (!string.IsNullOrWhiteSpace(secilen.KullanicininBesini.BesinResmiUzantisi))
            {
                pb_BesinResmi.Image = Image.FromFile("Images/" + secilen.KullanicininBesini.BesinResmiUzantisi);
                pb_BesinResmi.Tag = Path.GetExtension(secilen.KullanicininBesini.BesinResmiUzantisi);
            }
            else
            {
                pb_BesinResmi.Image = null;
            }
        }


        private void btn_BesinGuncelle_Click(object sender, EventArgs e)
        {
            if (kullaniciEtkilesim != null)
            {
                kullaniciEtkilesim = _db.KullanıcıEtkilesim.FirstOrDefault(x => x.ID == SeciliId);
                kullaniciEtkilesim.BesinID = ((Besin)cmb_Besinler.SelectedItem).ID;
                if (Convert.ToDouble(nud_Miktar.Value) > 0)
                {
                    kullaniciEtkilesim.AlınanMiktar = Convert.ToDouble(nud_Miktar.Value);
                    kullaniciEtkilesim.AlınanKalori = UserControlMetotları.KaloriHesapla(Convert.ToDouble(nud_Miktar.Value), _db, cmb_Besinler);
                    if (rb_Kahvalti.Checked)
                        kullaniciEtkilesim.Ogun = Ogun.Sabah;
                    else if (rb_OgleYemegi.Checked)
                        kullaniciEtkilesim.Ogun = Ogun.Ogle;
                    else if (rb_AksamYemegi.Checked)
                        kullaniciEtkilesim.Ogun = Ogun.Aksam;
                    else if (rb_AraOgun.Checked)
                        kullaniciEtkilesim.Ogun = Ogun.AraOgun;
                    _kullaniciBesin.Guncelle();
                    listele();
                    kullaniciEtkilesim = null;
                    KontrolMetotlari.Temizle(pnl_BesinEkle);
                }
                else
                {
                    MessageBox.Show("Lütfen Miktarı Giriniz.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Ürünü Seçiniz");
            }
        }

        private void dgv_Kahvaltı_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_Kahvaltı.RowCount > 0)
            {
                SeciliId = (int)dgv_Kahvaltı.CurrentRow.Cells[0].Value;
                if (SeciliId != null)
                {
                    kullaniciEtkilesim = _kullaniciBesin.IdyeGoreGetir(SeciliId);
                    SecileniAktar();
                }
            }
        }

        private void dgv_OgleYemegi_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_OgleYemegi.RowCount > 0)
            {
                SeciliId = (int)dgv_OgleYemegi.CurrentRow.Cells[0].Value;

                if (SeciliId != null)
                {
                    kullaniciEtkilesim = _kullaniciBesin.IdyeGoreGetir(SeciliId);
                    SecileniAktar();
                }
            }
        }

        private void dgv_AksamYemegi_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_AksamYemegi.RowCount > 0)
            {
                SeciliId = (int)dgv_AksamYemegi.CurrentRow.Cells[0].Value;
                if (SeciliId != null)
                {
                    kullaniciEtkilesim = _kullaniciBesin.IdyeGoreGetir(SeciliId);
                    SecileniAktar();
                }
            }
        }

        private void dgv_AraOgun_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_AraOgun.RowCount > 0)
            {
                SeciliId = (int)dgv_AraOgun.CurrentRow.Cells[0].Value;
                if (SeciliId != null)
                {
                    kullaniciEtkilesim = _kullaniciBesin.IdyeGoreGetir(SeciliId);
                    SecileniAktar();
                }
            }
        }

        private void dgv_Kahvaltı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_Besinler.SelectedIndex = 0;
            cmb_Kategoriler.SelectedIndex = 0;
            rb_Kahvalti.Checked = true;
            nud_Miktar.Value = 0;
            pb_BesinResmi.Image = null;
        }
    }
}
