using OOP_Hamburgerci.Entities;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King", MenuFiyat = 50.75M },
            new Menu{MenuAdi = "Whooper Jr.", MenuFiyat = 45.50m },
            new Menu{MenuAdi = "King Chicken", MenuFiyat = 37.75m },
            new Menu{MenuAdi = "Chicken Royal", MenuFiyat = 42.00m },
            new Menu{MenuAdi = "Köfteburger", MenuFiyat = 52.25m }
        };
        public static List<EkstraMalzeme> ektralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi = "Ketçap", EkstraFiyat = 1.00m},
            new EkstraMalzeme{EkstraAdi = "Mayonez", EkstraFiyat = 1.00m },
            new EkstraMalzeme{EkstraAdi = "Ranch Sos", EkstraFiyat = 1.50m},
            new EkstraMalzeme{EkstraAdi = "BBQ Sos", EkstraFiyat = 1.50m }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Menu item in menuler)
                cmbMenuler.Items.Add(item); // ToString() metodu override edildiði için ... Menü þekinde görülecektir.

            foreach(EkstraMalzeme item in ektralar)
                flmExtraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item, Width = (int)(flmExtraMalzeme.Width * 0.6)});

            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item); // Eðer tamamlanmamýþ bir sipariþ varsa varsa listbox'a ekle.
            rdoKucuk.Checked = true; // Açýlýþta küçük boy seçili gelsin.
            cmbMenuler.SelectedIndex = 0; // Açýlýþta ilk eleman seçili gelsin.

            TutarHesapla();
        }
        
        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar; // Herhangibir yerde metodu çaðýrdýðýmýzda geriye deðer döndürebilmek için yazýyoruz. Dönüþ tipide o yüzden void deðil, decimal.
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenuler.SelectedItem;

            if (rdoKucuk.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Orta;
            else
                yeniSiparis.Boyutu = BoyutEnum.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();

            foreach (CheckBox kontrol in flmExtraMalzeme.Controls)
            {
                if (kontrol.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag); // flp'nin kontrollerinden herbirinin tag property'sinde tutulan ekstramalzeme nesnesinin bir kopyasýný aldýk ve sipariþ nesnesinde oluþturduðumuz ekstramalzemeleri listesine ekledik.
            }

            yeniSiparis.Adedi = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla(); // Eklenen yeni sipariþin tutarýný ilgili classtaki metot ile hesaplýyoruz.

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);

            TutarHesapla();
            Metotlar.Temizle(this.Controls); // Bu formun bütün kontrollerini ilgili metoda gönder.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariþ Tutarý: " + TutarHesapla().ToString("C2") + "\nSatýn Alma Ýþlemini Onaylýyor Musunuz?", "Sipariþ Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler); // sipariþ tamamlandýðýnda tüm sipariþlere eklenir.
                lbxSiparisler.Items.Clear(); // Listbox'ý temizle
                mevcutSiparisler.Clear(); // Geçici olarak tuttuðumuz bu listeyi de temizliyoruz.
                TutarHesapla(); // Labeldaki tutar deðerini yeniden hesaplayýp '0' yazdýrmak için tekrardan çaðýrýrýz..
                MessageBox.Show("Sipariþiniz Tamamlandý.");
            }
            else
                MessageBox.Show("Ýþleminiz Ýptal Edildi.");
        }
    }
}