namespace OOP_Hamburgerci
{
    partial class MyMDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsmHamburger = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHamburger.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmHamburger
            // 
            this.tsmHamburger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYonetimi,
            this.tsmUrunYonetimi});
            this.tsmHamburger.Location = new System.Drawing.Point(0, 0);
            this.tsmHamburger.Name = "tsmHamburger";
            this.tsmHamburger.Size = new System.Drawing.Size(1003, 24);
            this.tsmHamburger.TabIndex = 0;
            this.tsmHamburger.Text = "menuStrip1";
            // 
            // tsmSiparisYonetimi
            // 
            this.tsmSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgileri});
            this.tsmSiparisYonetimi.Name = "tsmSiparisYonetimi";
            this.tsmSiparisYonetimi.Size = new System.Drawing.Size(103, 20);
            this.tsmSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(150, 22);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(150, 22);
            this.tsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraMalEkle});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.tsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMenuEkle.Text = "Menü Ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraMalEkle
            // 
            this.tsmEkstraMalEkle.Name = "tsmEkstraMalEkle";
            this.tsmEkstraMalEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEkstraMalEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalEkle.Click += new System.EventHandler(this.tsmEkstraMalEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 660);
            this.Controls.Add(this.tsmHamburger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tsmHamburger;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.tsmHamburger.ResumeLayout(false);
            this.tsmHamburger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip tsmHamburger;
        private ToolStripMenuItem tsmSiparisYonetimi;
        private ToolStripMenuItem tsmSiparisOlustur;
        private ToolStripMenuItem tsmSiparisBilgileri;
        private ToolStripMenuItem tsmUrunYonetimi;
        private ToolStripMenuItem tsmMenuEkle;
        private ToolStripMenuItem tsmEkstraMalEkle;
    }
}