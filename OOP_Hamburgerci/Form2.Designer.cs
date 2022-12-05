namespace OOP_Hamburgerci
{
    partial class Form2
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
            this.grpMenuEkle = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuEkle
            // 
            this.grpMenuEkle.Controls.Add(this.btnEkle);
            this.grpMenuEkle.Controls.Add(this.txtMenuAdi);
            this.grpMenuEkle.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuEkle.Controls.Add(this.label2);
            this.grpMenuEkle.Controls.Add(this.label1);
            this.grpMenuEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMenuEkle.Location = new System.Drawing.Point(12, 12);
            this.grpMenuEkle.Name = "grpMenuEkle";
            this.grpMenuEkle.Size = new System.Drawing.Size(315, 192);
            this.grpMenuEkle.TabIndex = 0;
            this.grpMenuEkle.TabStop = false;
            this.grpMenuEkle.Text = "MENÜ EKLE";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(171, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Menü Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(122, 36);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(163, 23);
            this.txtMenuAdi.TabIndex = 3;
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(122, 86);
            this.nmrMenuFiyati.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(163, 23);
            this.nmrMenuFiyati.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 221);
            this.Controls.Add(this.grpMenuEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMenuEkle.ResumeLayout(false);
            this.grpMenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMenuEkle;
        private Button btnEkle;
        private TextBox txtMenuAdi;
        private NumericUpDown nmrMenuFiyati;
        private Label label2;
        private Label label1;
    }
}