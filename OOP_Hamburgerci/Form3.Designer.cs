namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.grpEkstraMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzemeEkle
            // 
            this.grpEkstraMalzemeEkle.Controls.Add(this.btnMalzemeEkle);
            this.grpEkstraMalzemeEkle.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpEkstraMalzemeEkle.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.grpEkstraMalzemeEkle.Controls.Add(this.label2);
            this.grpEkstraMalzemeEkle.Controls.Add(this.label1);
            this.grpEkstraMalzemeEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEkstraMalzemeEkle.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzemeEkle.Name = "grpEkstraMalzemeEkle";
            this.grpEkstraMalzemeEkle.Size = new System.Drawing.Size(315, 192);
            this.grpEkstraMalzemeEkle.TabIndex = 1;
            this.grpEkstraMalzemeEkle.TabStop = false;
            this.grpEkstraMalzemeEkle.Text = "EKSTRA MALZEME EKLE";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(195, 124);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(114, 47);
            this.btnMalzemeEkle.TabIndex = 4;
            this.btnMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(146, 36);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(163, 23);
            this.txtEkstraMalzemeAdi.TabIndex = 3;
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(146, 86);
            this.nmrEkstraMalzemeFiyati.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(163, 23);
            this.nmrEkstraMalzemeFiyati.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 229);
            this.Controls.Add(this.grpEkstraMalzemeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpEkstraMalzemeEkle.ResumeLayout(false);
            this.grpEkstraMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpEkstraMalzemeEkle;
        private Button btnMalzemeEkle;
        private TextBox txtEkstraMalzemeAdi;
        private NumericUpDown nmrEkstraMalzemeFiyati;
        private Label label2;
        private Label label1;
    }
}