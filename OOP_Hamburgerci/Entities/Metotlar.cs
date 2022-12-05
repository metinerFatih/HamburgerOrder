using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace OOP_Hamburgerci.Entities
{
    public class Metotlar
    {
        public static void Temizle(ControlCollection formunKontrolleri)
        {
            foreach (Control item in formunKontrolleri)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = ""; // Böyle almak daha sağlıklı. Cast etmeseydik eventleri vs. alamayabiliriz. O yüzden de bütün hepsi için cast ederiz.
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                else if (item is RadioButton)
                {
                    if (((RadioButton)item).Name.Contains("Kucuk"))
                        ((RadioButton)item).Checked = true;
                }
                else if (item is CheckBox)
                {
                    //if (((CheckBox)item).Name.Contains("chk")) // Name Kontrolü yaparsak eğer ... ama gerek yok bu örnek için...
                        ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);
                else if (item is FlowLayoutPanel)
                    Temizle(((FlowLayoutPanel)item).Controls);
            }
        }

        // Sipariş Sayfası:
        public static void EkledenSonra()
        {
            
        }
    }
}
