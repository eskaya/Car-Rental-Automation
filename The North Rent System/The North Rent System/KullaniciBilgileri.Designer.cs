namespace The_North_Rent_System
{
    partial class KullaniciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yetkiComboBox = new System.Windows.Forms.ComboBox();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.ilComboBox = new System.Windows.Forms.ComboBox();
            this.kullanicilar = new System.Windows.Forms.DataGridView();
            this.eklemeButton = new System.Windows.Forms.Button();
            this.silmeButton = new System.Windows.Forms.Button();
            this.güncellemeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bilgileriGetir = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mailAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Yetkisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "İl Kodu:";
            // 
            // yetkiComboBox
            // 
            this.yetkiComboBox.FormattingEnabled = true;
            this.yetkiComboBox.Items.AddRange(new object[] {
            "SuperAdmin",
            "Admin",
            "Personel"});
            this.yetkiComboBox.Location = new System.Drawing.Point(171, 266);
            this.yetkiComboBox.Name = "yetkiComboBox";
            this.yetkiComboBox.Size = new System.Drawing.Size(121, 21);
            this.yetkiComboBox.TabIndex = 6;
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(125, 84);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(123, 20);
            this.adSoyadTextBox.TabIndex = 7;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(148, 129);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(144, 20);
            this.eMailTextBox.TabIndex = 8;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(190, 175);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(102, 20);
            this.telefonTextBox.TabIndex = 9;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(76, 222);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.sifreTextBox.TabIndex = 10;
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81"});
            this.ilComboBox.Location = new System.Drawing.Point(97, 311);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(121, 21);
            this.ilComboBox.TabIndex = 11;
            // 
            // kullanicilar
            // 
            this.kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAdres,
            this.adSoyad,
            this.telefon,
            this.yetkisi,
            this.ilKod});
            this.kullanicilar.Location = new System.Drawing.Point(645, 79);
            this.kullanicilar.Name = "kullanicilar";
            this.kullanicilar.Size = new System.Drawing.Size(663, 456);
            this.kullanicilar.TabIndex = 12;
            // 
            // eklemeButton
            // 
            this.eklemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklemeButton.Location = new System.Drawing.Point(15, 459);
            this.eklemeButton.Name = "eklemeButton";
            this.eklemeButton.Size = new System.Drawing.Size(127, 47);
            this.eklemeButton.TabIndex = 13;
            this.eklemeButton.Text = "Ekle";
            this.eklemeButton.UseVisualStyleBackColor = true;
            this.eklemeButton.Click += new System.EventHandler(this.eklemeButton_Click);
            // 
            // silmeButton
            // 
            this.silmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmeButton.Location = new System.Drawing.Point(181, 459);
            this.silmeButton.Name = "silmeButton";
            this.silmeButton.Size = new System.Drawing.Size(127, 47);
            this.silmeButton.TabIndex = 14;
            this.silmeButton.Text = "Sil";
            this.silmeButton.UseVisualStyleBackColor = true;
            this.silmeButton.Click += new System.EventHandler(this.silmeButton_Click);
            // 
            // güncellemeButton
            // 
            this.güncellemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellemeButton.Location = new System.Drawing.Point(348, 459);
            this.güncellemeButton.Name = "güncellemeButton";
            this.güncellemeButton.Size = new System.Drawing.Size(127, 47);
            this.güncellemeButton.TabIndex = 15;
            this.güncellemeButton.Text = "Güncelle";
            this.güncellemeButton.UseVisualStyleBackColor = true;
            this.güncellemeButton.Click += new System.EventHandler(this.güncellemeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Silme: Bu işlem için sadece mail adresini girmeniz yeterlidir!";
            // 
            // bilgileriGetir
            // 
            this.bilgileriGetir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bilgileriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgileriGetir.Location = new System.Drawing.Point(334, 129);
            this.bilgileriGetir.Name = "bilgileriGetir";
            this.bilgileriGetir.Size = new System.Drawing.Size(127, 20);
            this.bilgileriGetir.TabIndex = 17;
            this.bilgileriGetir.Text = "Bilgileri Getir";
            this.bilgileriGetir.UseVisualStyleBackColor = true;
            this.bilgileriGetir.Click += new System.EventHandler(this.bilgileriGetir_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(15, 12);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(75, 23);
            this.geriButton.TabIndex = 18;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
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
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.bilgileriGetir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.güncellemeButton);
            this.Controls.Add(this.silmeButton);
            this.Controls.Add(this.eklemeButton);
            this.Controls.Add(this.kullanicilar);
            this.Controls.Add(this.ilComboBox);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.yetkiComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "KullaniciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciBilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yetkiComboBox;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.ComboBox ilComboBox;
        private System.Windows.Forms.DataGridView kullanicilar;
        private System.Windows.Forms.Button eklemeButton;
        private System.Windows.Forms.Button silmeButton;
        private System.Windows.Forms.Button güncellemeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bilgileriGetir;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilKod;
    }
}