using KaloriSay.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace KaloriSay.UI
{
    public partial class AnaForm : Form
    {
               
        public AnaForm()
        {
            InitializeComponent();
            tgb_Secim.Checked = false;           

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tgb_Secim_CheckedChanged(object sender, EventArgs e)
        {
            if (tgb_Secim.Checked)
            {
                frmKayitDevamForm1.Visible = true;
                lbl_GirisYap.Visible = true;
                lbl_UyeOl.Visible = false;
            }
            else
            {
                frmKayitDevamForm1.Visible = false;
                lbl_UyeOl.Visible = true;
                lbl_GirisYap.Visible = false;
            }
        }
       
    }
}