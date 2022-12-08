using KaloriSay.DAL.Context;
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
    public partial class YoneticiPanelForm : Form
    {
        KaloriSayContext _db;
        public YoneticiPanelForm()
        {
            InitializeComponent();
            _db= new KaloriSayContext();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }  

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserControl,frmRaporlar1);
        }
        private void btn_BesinIslemleri_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserControl,frmBesinIslemleri1);
        }

        private void btn_KategoriIslemleri_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserControl, frmKategoriIslemleri1);
        }

        private void btn_KullaniciIslemleri_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserControl,frmKullaniciIslemleri1);
        }

        private void btn_TalepSikayet_Click(object sender, EventArgs e)
        {
            UserControlGoster(pnl_UserControl,frmTalepSikayet1);
        }
        private void UserControlGoster(Panel panel, UserControl userControl = null!)
        {
            foreach (var _userControl in panel.Controls)
            {
                if (_userControl is not DataGridView)
                {
                    if (_userControl == userControl)
                        ((UserControl)_userControl).Visible = true;
                    else
                        ((UserControl)_userControl).Visible = false;
                }
            }
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

       
    }
}
