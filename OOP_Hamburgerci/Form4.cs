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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach(Siparis siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach(EkstraMalzeme ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzemeGeliri += ekstra.EkstraFiyat;
                }

                satisAdedi += siparis.Adedi;
                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblExtraMalGelir.Text = ekstraMalzemeGeliri.ToString("C2");
            lblTopSipSay.Text = lbxTumSiparisler.Items.Count.ToString();
            lblSatUrunSay.Text = satisAdedi.ToString();
        }
    }
}
