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
    public partial class frmKategoriIslemleri : UserControl
    {
        
        KategoriIslemleriDal kategoriIslemleri;
        public frmKategoriIslemleri()
        {
            InitializeComponent();           
            
        }

        private void Listele()
        {
            using KaloriSayContext _db = new KaloriSayContext();
            kategoriIslemleri = new KategoriIslemleriDal(_db);
            dgv_Kategoriler.DataSource = (from kategori in _db.Kategoriler
                                          select new
                                          {
                                              kategori.ID,
                                              kategori.KategoriAdi
                                          }).ToList();
        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();

            try
            {
                if (txt_KategoriAdi.Text != string.Empty)
                {
                    kategori.KategoriAdi = txt_KategoriAdi.Text;
                    kategoriIslemleri.Ekle(kategori);
                    MessageBox.Show("Kategori Eklenmiştir.");
                    Listele();
                    secilenKategori = null;
                    KontrolMetotlari.Temizle(pnl_KategoriIslemleri);
                }
                else
                    MessageBox.Show("Lütfen Kategori Adını Giriniz.");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Kategori Eklemeden Önce Kategorileri Listeleyiniz.");
            }

        }
        Kategori secilenKategori;
        private void dgv_Kategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKategori = null!;
            KontrolMetotlari.Temizle(pnl_KategoriIslemleri);
        }

        private void btn_KategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKategori != null)
            {

                if (txt_KategoriAdi.Text != string.Empty)
                {
                    secilenKategori.KategoriAdi = txt_KategoriAdi.Text;
                    kategoriIslemleri.Guncelle();
                    MessageBox.Show("Kategori Güncellenmiştir.");
                    Listele();
                    secilenKategori = null;
                    KontrolMetotlari.Temizle(pnl_KategoriIslemleri);
                }
                else
                    MessageBox.Show("Lütfen Kategori Adını Giriniz.");
            }
            else
                MessageBox.Show("Lütfen Kategori Seçiniz.");

        }

        private void btn_KategoriSil_Click(object sender, EventArgs e)
        {
            if (secilenKategori != null)
            {
                kategoriIslemleri.Sil(secilenKategori);
                MessageBox.Show("Kategori Silinmiştir.");
                Listele();
                secilenKategori = null;
                KontrolMetotlari.Temizle(pnl_KategoriIslemleri);
            }
            else
                MessageBox.Show("Lütfen Kategori Seçiniz");
        }

        private void dgv_Kategoriler_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Kategoriler.RowCount>0)
            {
                int secilenKategoriID = Convert.ToInt32(dgv_Kategoriler.CurrentRow.Cells[0].Value);
                secilenKategori = kategoriIslemleri.IdyeGoreGetir(secilenKategoriID);
                txt_KategoriAdi.Text = secilenKategori.KategoriAdi; 
            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
