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
    public partial class frmBMIHesaplama : UserControl
    {
        public frmBMIHesaplama()
        {
            InitializeComponent();
        }

        private void btn_BMIHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double Boy = Convert.ToDouble(txt_BoyBMI.Text);
                double Kilo = Convert.ToDouble(txt_KiloBMI.Text);
                if (Boy > 100)
                {
                    lbl_VucutKitleIndeksi.Text = BMIHesapla(Boy / 100, Kilo).ToString("00.00");
                    lbl_VucutKitleIndeksi.Visible = true;

                }
                else if (Boy < 3 && Boy>0)
                {
                    lbl_VucutKitleIndeksi.Text = BMIHesapla(Boy, Kilo).ToString("00.00");
                    lbl_VucutKitleIndeksi.Visible = true;
                }
            }
            catch (Exception)
            {
                UserControlMetotları.LblUyari("Lütfen Verileri Kontrol Edin.",lbl_VucutKitleIndeksi);
            }
            
            
        }

        private double BMIHesapla(double Boy, double Kilo)
        {
            return Kilo / (Math.Pow(Boy, 2));
        }


    }
}
