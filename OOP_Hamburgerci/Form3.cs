using OOP_Hamburgerci.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Form1.ektralar.Add(new EkstraMalzeme { EkstraAdi = txtEkstraMalzemeAdi.Text, EkstraFiyat = nmrEkstraMalzemeFiyati.Value });
            Metotlar.Temizle(this.Controls);
            MessageBox.Show("Ekstra Malzeme Eklendi.");
        }
    }
}
