using KullaniciPanel.EjderhaControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.UI.Metotlar
{
    public class KontrolMetotlari
    {
        public static bool BosAlanVarmı(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is EjderhaTextBox && ((EjderhaTextBox)item).Text == string.Empty)
                    return true;
                else if (item is NumericUpDown && ((NumericUpDown)item).Value ==0)
                    return true;
                else if (item is ComboBox && ((ComboBox)item).SelectedIndex<0)
                    return true;
            }
            return false;
        }
        public static void Temizle(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is EjderhaTextBox)
                    ((EjderhaTextBox)item).Text = string.Empty;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is PictureBox)
                    ((PictureBox)item).Image = null;
            }
        }
    }
}
