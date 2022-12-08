using KaloriSay.BL.Repositories;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using KaloriSay.UI.Metotlar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KaloriSay.UI.UserControls
{
    public partial class frmBesinIslemleri : UserControl
    {
        BesinIslemleriDal besinIslemleri;

        public frmBesinIslemleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            KaloriSayContext _db = new KaloriSayContext();
            besinIslemleri = new BesinIslemleriDal(_db);
            cmb_Kategoriler.DisplayMember = "KategoriAdi";
            cmb_Kategoriler.DataSource = _db.Kategoriler.ToList();
            dgv_Besinler.DataSource = _db.Besinler.Select(x => new
            {
                x.ID,
                x.Adi,
                x.Karbonhidrat,
                x.Yag,
                x.Protein,
                x.Kategori.KategoriAdi,
                x.Miktar,
                x.Birim,
                x.BesinResim

            }).ToList();
        }

        private void btn_BesinEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Kategoriler.SelectedIndex != -1)
                {
                    KaloriSayContext _db = new KaloriSayContext();
                    besinIslemleri = new BesinIslemleriDal(_db);
                    Besin _besin = new Besin();
                    if (pb_BesinResmi.Image != null)
                    {
                        using (var resizedImage = new Bitmap(pb_BesinResmi.Image, 70, 70))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                resizedImage.Save(memoryStream, pb_BesinResmi.Image.RawFormat);
                                var resizedImageData = memoryStream.ToArray();
                                _besin.BesinResim = resizedImageData;
                            }
                        }
                        _besin.BesinResmiUzantisi = Guid.NewGuid() + pb_BesinResmi.Tag.ToString();
                        pb_BesinResmi.Image.Save(Application.StartupPath + "/Images/" + _besin.BesinResmiUzantisi);
                    }
                    else
                        _besin.BesinResmiUzantisi = null;

                    if (!KontrolMetotlari.BosAlanVarmı(pnl_BesinIslemleri))
                    {
                        _besin.Adi = txt_BesinAdi.Text;
                        _besin.Miktar = Convert.ToDouble(txt_BesinMiktari.Text);
                        _besin.Porsiyon = txt_BesinPorsiyonu.Text;
                        _besin.Karbonhidrat = Convert.ToDouble(txt_BesinKarbonhidrat.Text);
                        _besin.Protein = Convert.ToDouble(txt_BesinProtein.Text);
                        _besin.Yag = Convert.ToDouble(txt_BesinYag.Text);
                        _besin.Kalori = Convert.ToDouble(txt_BesinKalori.Text);
                        _besin.KategoriID = ((Kategori)cmb_Kategoriler.SelectedItem).ID;
                        if (txt_BesinBirimi.Text == "gr" || txt_BesinBirimi.Text == "ml")
                        {
                            _besin.Birim = txt_BesinBirimi.Text;
                            besinIslemleri.Ekle(_besin);
                            MessageBox.Show("Besin Eklenmiştir");
                            Listele();
                            SeciliBesin = null;
                            KontrolMetotlari.Temizle(pnl_BesinIslemleri);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Birimi gr veya ml yazınız.");
                        }

                    }
                    else
                        MessageBox.Show("Boş Alan Bırakmayınız.");
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Eklemeden Önce Tümünü Listeleyiniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Giriniz.");
            }

        }
        Besin SeciliBesin;
        private void btn_BesinGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliBesin != null)
            {
                SeciliBesin.Adi = txt_BesinAdi.Text;
                SeciliBesin.Miktar = Convert.ToDouble(txt_BesinMiktari.Text);
                SeciliBesin.Birim = txt_BesinBirimi.Text;
                SeciliBesin.Porsiyon = txt_BesinPorsiyonu.Text;
                SeciliBesin.Karbonhidrat = Convert.ToDouble(txt_BesinKarbonhidrat.Text);
                SeciliBesin.Protein = Convert.ToDouble(txt_BesinProtein.Text);
                SeciliBesin.Yag = Convert.ToDouble(txt_BesinYag.Text);
                SeciliBesin.Kalori = Convert.ToDouble(txt_BesinKalori.Text);
                SeciliBesin.KategoriID = ((Kategori)cmb_Kategoriler.SelectedItem).ID;
                if (pb_BesinResmi.Image != null)
                {
                    using (var resizedImage = new Bitmap(pb_BesinResmi.Image, 70, 70))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            resizedImage.Save(memoryStream, pb_BesinResmi.Image.RawFormat);
                            var resizedImageData = memoryStream.ToArray();
                            SeciliBesin.BesinResim = resizedImageData;
                        }
                    }
                    SeciliBesin.BesinResmiUzantisi = Guid.NewGuid() + pb_BesinResmi.Tag.ToString();

                    pb_BesinResmi.Image.Save(Application.StartupPath + "/Images/" + SeciliBesin.BesinResmiUzantisi);
                }
                besinIslemleri.Guncelle();
                MessageBox.Show("Seçili Besin Güncellenmiştir");
                Listele();
                SeciliBesin = null;
                KontrolMetotlari.Temizle(pnl_BesinIslemleri);

            }
            else
            {
                MessageBox.Show("Lütfen Güncellenecek Besiniz Seçiniz.");
            }
        }

        private void btn_BesinSil_Click(object sender, EventArgs e)
        {
            if (SeciliBesin != null)
            {
                KaloriSayContext _db = new KaloriSayContext();
                Repository<KullaniciBesin> _repoKullaniciBesin = new Repository<KullaniciBesin>(_db);
                var SilinenBesin = _db.KullanıcıEtkilesim.Where(x => x.BesinID == SeciliBesin.ID).ToList();
                _repoKullaniciBesin.TopluSil(SilinenBesin);
                besinIslemleri.Sil(SeciliBesin);
                MessageBox.Show("Seçili Besin Silinmiştir");
                Listele();
                SeciliBesin = null;
                KontrolMetotlari.Temizle(pnl_BesinIslemleri);


            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Besini Seçiniz.");
            }
        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Besin Resmi (png,jpg,gif)|*.png;*.jpg;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pb_BesinResmi.Image = Image.FromFile(ofd.FileName);
                pb_BesinResmi.Tag = File.ReadAllBytes(ofd.FileName);
            }

        }

        private void dgv_Besinler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliBesin = null!;
            KontrolMetotlari.Temizle(pnl_BesinIslemleri);
        }

        private void txt_Ara__TextChanged(object sender, EventArgs e)
        {
            KaloriSayContext _db = new KaloriSayContext();
            dgv_Besinler.DataSource = _db.Besinler.Where(x => EF.Functions.Like(x.Adi, $"%{txt_Ara.Text}%")).Select(x => new
            {
                x.ID,
                x.Adi,
                x.Karbonhidrat,
                x.Yag,
                x.Protein,
                x.Kategori.KategoriAdi,
                x.Miktar,
                x.Birim
            }).ToList();
        }

        private void dgv_Besinler_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Besinler.RowCount > 0)
            {
                int guncellenecekBesinID = Convert.ToInt32(dgv_Besinler.CurrentRow.Cells[0].Value);
                SeciliBesin = besinIslemleri.IdyeGoreGetir(guncellenecekBesinID);
                txt_BesinAdi.Text = SeciliBesin.Adi;
                txt_BesinMiktari.Text = SeciliBesin.Miktar.ToString();
                txt_BesinBirimi.Text = SeciliBesin.Birim;
                txt_BesinPorsiyonu.Text = SeciliBesin.Porsiyon.ToString();
                txt_BesinKarbonhidrat.Text = SeciliBesin.Karbonhidrat.ToString();
                txt_BesinProtein.Text = SeciliBesin.Protein.ToString();
                txt_BesinYag.Text = SeciliBesin.Yag.ToString();
                txt_BesinKalori.Text = SeciliBesin.Kalori.ToString();
                cmb_Kategoriler.Text = SeciliBesin.Kategori.KategoriAdi.ToString();
                if (!string.IsNullOrWhiteSpace(SeciliBesin.BesinResmiUzantisi))
                {
                    pb_BesinResmi.Image = Image.FromFile("Images/" + SeciliBesin.BesinResmiUzantisi);
                    pb_BesinResmi.Tag = Path.GetExtension(SeciliBesin.BesinResmiUzantisi);
                }
                else
                {
                    pb_BesinResmi.Image = null;
                }
            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_TumunuTemizle_Click(object sender, EventArgs e)
        {
            KontrolMetotlari.Temizle(pnl_BesinIslemleri);
        }
    }
}
