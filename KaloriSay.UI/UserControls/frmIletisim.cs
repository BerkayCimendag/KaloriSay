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
    public partial class frmIletisim : UserControl
    {
        KaloriSayContext _db;

        TalepSikayetDal _talepSikayet;
        public frmIletisim()
        {
            InitializeComponent();
            _db = new KaloriSayContext();

            _talepSikayet = new TalepSikayetDal(_db);
            cmb_TalepSikayet.SelectedIndex = 0;
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {

            if (!KontrolMetotlari.BosAlanVarmı(pnl_Iletisim))
            {
                TalepSikayet talepSikayet = new TalepSikayet()
                {
                    Acıklama = txt_Talep_Sikayet.Text,
                    Talep_Sikayet = cmb_TalepSikayet.Text,
                    KullaniciID = _db.Kullanicilar.FirstOrDefault(x => x.Email == Properties.Settings.Default.HatirlanacakMail).ID

                };
                _talepSikayet.Ekle(talepSikayet);
                MessageBox.Show("Talebiniz/Şikayetiniz İletilmiştir."); 
            }
            else
                MessageBox.Show("Boş Alan Bırakmayınız.");


        }
    }
}
