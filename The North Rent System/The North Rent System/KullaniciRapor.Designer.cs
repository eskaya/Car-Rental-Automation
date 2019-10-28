namespace The_North_Rent_System
{
    partial class KullaniciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciRapor));
            this.kullanicilarTablo = new System.Windows.Forms.DataGridView();
            this.mailAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanicilarTablo
            // 
            this.kullanicilarTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilarTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAdres,
            this.adSoyad,
            this.telefon,
            this.yetkisi,
            this.ilKod});
            this.kullanicilarTablo.Location = new System.Drawing.Point(12, 27);
            this.kullanicilarTablo.Name = "kullanicilarTablo";
            this.kullanicilarTablo.Size = new System.Drawing.Size(663, 300);
            this.kullanicilarTablo.TabIndex = 13;
            // 
            // mailAdres
            // 
            this.mailAdres.DataPropertyName = "kullaniciMailAdres";
            this.mailAdres.HeaderText = "Mail Adresi";
            this.mailAdres.MinimumWidth = 50;
            this.mailAdres.Name = "mailAdres";
            this.mailAdres.Width = 150;
            // 
            // adSoyad
            // 
            this.adSoyad.DataPropertyName = "kullaniciAdSoyad";
            this.adSoyad.HeaderText = "Ad Soyad";
            this.adSoyad.MinimumWidth = 50;
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Width = 150;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "kullaniciTelefon";
            this.telefon.HeaderText = "Telefon Numarası";
            this.telefon.MinimumWidth = 50;
            this.telefon.Name = "telefon";
            // 
            // yetkisi
            // 
            this.yetkisi.DataPropertyName = "kullaniciYetkisi";
            this.yetkisi.HeaderText = "Kullanıcı Yetki";
            this.yetkisi.MinimumWidth = 50;
            this.yetkisi.Name = "yetkisi";
            this.yetkisi.Width = 120;
            // 
            // ilKod
            // 
            this.ilKod.DataPropertyName = "ilKodu";
            this.ilKod.HeaderText = "İl Kodu";
            this.ilKod.Name = "ilKod";
            // 
            // pdfExport
            // 
            this.pdfExport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pdfExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfExport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdfExport.Location = new System.Drawing.Point(564, 333);
            this.pdfExport.Name = "pdfExport";
            this.pdfExport.Size = new System.Drawing.Size(110, 32);
            this.pdfExport.TabIndex = 14;
            this.pdfExport.Text = "Export To Pdf";
            this.pdfExport.UseVisualStyleBackColor = false;
            this.pdfExport.Click += new System.EventHandler(this.pdfExport_Click);
            // 
            // KullaniciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(686, 373);
            this.Controls.Add(this.pdfExport);
            this.Controls.Add(this.kullanicilarTablo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciRapor";
            this.Text = "KullaniciRapor";
            this.Load += new System.EventHandler(this.KullaniciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kullanicilarTablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilKod;
        private System.Windows.Forms.Button pdfExport;
    }
}