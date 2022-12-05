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
            new Menu{MenuAdi = "K�fteburger", MenuFiyat = 52.25m }
        };
        public static List<EkstraMalzeme> ektralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi = "Ket�ap", EkstraFiyat = 1.00m},
            new EkstraMalzeme{EkstraAdi = "Mayonez", EkstraFiyat = 1.00m },
            new EkstraMalzeme{EkstraAdi = "Ranch Sos", EkstraFiyat = 1.50m},
            new EkstraMalzeme{EkstraAdi = "BBQ Sos", EkstraFiyat = 1.50m }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Menu item in menuler)
                cmbMenuler.Items.Add(item); // ToString() metodu override edildi�i i�in ... Men� �ekinde g�r�lecektir.

            foreach(EkstraMalzeme item in ektralar)
                flmExtraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item, Width = (int)(flmExtraMalzeme.Width * 0.6)});

            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item); // E�er tamamlanmam�� bir sipari� varsa varsa listbox'a ekle.
            rdoKucuk.Checked = true; // A��l��ta k���k boy se�ili gelsin.
            cmbMenuler.SelectedIndex = 0; // A��l��ta ilk eleman se�ili gelsin.

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

            return toplamTutar; // Herhangibir yerde metodu �a��rd���m�zda geriye de�er d�nd�rebilmek i�in yaz�yoruz. D�n�� tipide o y�zden void de�il, decimal.
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
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag); // flp'nin kontrollerinden herbirinin tag property'sinde tutulan ekstramalzeme nesnesinin bir kopyas�n� ald�k ve sipari� nesnesinde olu�turdu�umuz ekstramalzemeleri listesine ekledik.
            }

            yeniSiparis.Adedi = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla(); // Eklenen yeni sipari�in tutar�n� ilgili classtaki metot ile hesapl�yoruz.

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);

            TutarHesapla();
            Metotlar.Temizle(this.Controls); // Bu formun b�t�n kontrollerini ilgili metoda g�nder.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipari� Tutar�: " + TutarHesapla().ToString("C2") + "\nSat�n Alma ��lemini Onayl�yor Musunuz?", "Sipari� Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler); // sipari� tamamland���nda t�m sipari�lere eklenir.
                lbxSiparisler.Items.Clear(); // Listbox'� temizle
                mevcutSiparisler.Clear(); // Ge�ici olarak tuttu�umuz bu listeyi de temizliyoruz.
                TutarHesapla(); // Labeldaki tutar de�erini yeniden hesaplay�p '0' yazd�rmak i�in tekrardan �a��r�r�z..
                MessageBox.Show("Sipari�iniz Tamamland�.");
            }
            else
                MessageBox.Show("��leminiz �ptal Edildi.");
        }
    }
}