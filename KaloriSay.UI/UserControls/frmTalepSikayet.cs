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
    public partial class frmTalepSikayet : UserControl
    {
        TalepSikayetDal _talepSikayet;
        public frmTalepSikayet()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            KaloriSayContext _db = new KaloriSayContext();
            _talepSikayet = new TalepSikayetDal(_db);
            dgv_TalepSikayet.DataSource = (from kullanicilar in _db.Kullanicilar
                                           join talepSikayet in _db.TalepSikayetler on kullanicilar.ID equals talepSikayet.KullaniciID
                                           where talepSikayet.OkunduMu == false
                                           select new
                                           {
                                               talepSikayet.ID,
                                               kullanicilar.Email,
                                               talepSikayet.Talep_Sikayet,
                                               talepSikayet.Acıklama,
                                               talepSikayet.OkunduMu
                                           }).ToList();
        }

        private void dgv_TalepSikayet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliTalepSikayet = null!;
        }
        TalepSikayet seciliTalepSikayet;
        private void dgv_TalepSikayet_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_TalepSikayet.RowCount>0)
            {
                int seciliID = Convert.ToInt32(dgv_TalepSikayet.CurrentRow.Cells[0].Value);
                seciliTalepSikayet = _talepSikayet.IdyeGoreGetir(seciliID);
                if (seciliTalepSikayet.OkunduMu)
                    rb_Okundu.Checked = true;
                else
                    rb_Okunmadı.Checked = true;
                lbl_Acıklama.Text = seciliTalepSikayet.Acıklama; 
            }

        }

        private void btn_OkunduBilgisiGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliTalepSikayet != null)
            {
                seciliTalepSikayet.OkunduMu = rb_Okundu.Checked;
                _talepSikayet.Guncelle();
                MessageBox.Show("Talep Güncellendi.");
                Listele();
                seciliTalepSikayet = null;                
            }
            else
                MessageBox.Show("Lütfen Bir Talep Seçiniz.");
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_TumunuGetir_Click(object sender, EventArgs e)
        {
            KaloriSayContext _db = new KaloriSayContext();
            _talepSikayet = new TalepSikayetDal(_db);
            dgv_TalepSikayet.DataSource = (from kullanicilar in _db.Kullanicilar
                                           join talepSikayet in _db.TalepSikayetler on kullanicilar.ID equals talepSikayet.KullaniciID
                                           select new
                                           {
                                               talepSikayet.ID,
                                               kullanicilar.Email,
                                               talepSikayet.Talep_Sikayet,
                                               talepSikayet.Acıklama,
                                               talepSikayet.OkunduMu
                                           }).ToList();
        }
    }
}
