using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci.Entities
{
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeleri { get; set; }
        public BoyutEnum Boyutu { get; set; }
        public int  Adedi { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.MenuFiyat;

            switch (Boyutu)
            {
                case BoyutEnum.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.20m;
                    break;
            }

            ToplamTutar *= Adedi;

            foreach (EkstraMalzeme item in EkstraMalzemeleri)
                ToplamTutar += item.EkstraFiyat;
        }

        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenusu.MenuAdi, Adedi, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach(EkstraMalzeme item in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += item.EkstraAdi + ",";
                }

                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}), Toplam: {4}", SeciliMenusu.MenuAdi, Adedi, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
