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
    public partial class frmIdealKiloHesapla : UserControl
    {
        public frmIdealKiloHesapla()
        {
            InitializeComponent();
        }

        private void btn_IdealHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                double Boy = Convert.ToDouble(txt_BoyIdeal.Text);
                if (Boy > 100)
                {
                    lbl_IdealKilo.Text = (45.5 + (2.3 * ((Boy / 2.54) - 60))).ToString("00.00");
                    lbl_IdealKilo.Visible = true;
                }
                else if (Boy < 3 && Boy > 0)
                {
                    lbl_IdealKilo.Text = (45.5 + (2.3 * ((Boy * 100 / 2.54) - 60))).ToString("00.00");
                    lbl_IdealKilo.Visible = true;
                }

            }
            catch (Exception)
            {
                UserControlMetotları.LblUyari("Bilgileri Kontrol Ediniz.", lbl_IdealKilo);
            }

        }

        private void txt_BoyIdeal__TextChanged(object sender, EventArgs e)
        {
            lbl_IdealKilo.Visible=false;
        }
    }
}
