namespace The_North_Rent_System
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAracTip = new System.Windows.Forms.TextBox();
            this.txtYakit = new System.Windows.Forms.TextBox();
            this.cmbİlKod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracPlakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanzimanTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracEkleTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theNorthDBODataSet = new The_North_Rent_System.TheNorthDBODataSet();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.aracEkleTablosuTableAdapter = new The_North_Rent_System.TheNorthDBODataSetTableAdapters.aracEkleTablosuTableAdapter();
            this.txtSanziman = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracEkleTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theNorthDBODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üretim Yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ücret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şanzıman Tipi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(52, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yakıt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(34, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Araç Tipi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(46, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "İl Kodu:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(136, 78);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 10;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(136, 122);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(136, 160);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 12;
            // 
            // txtAracTip
            // 
            this.txtAracTip.Location = new System.Drawing.Point(136, 241);
            this.txtAracTip.Name = "txtAracTip";
            this.txtAracTip.Size = new System.Drawing.Size(100, 20);
            this.txtAracTip.TabIndex = 14;
            // 
            // txtYakit
            // 
            this.txtYakit.Location = new System.Drawing.Point(136, 286);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(100, 20);
            this.txtYakit.TabIndex = 15;
            // 
            // cmbİlKod
            // 
            this.cmbİlKod.FormattingEnabled = true;
            this.cmbİlKod.Items.AddRange(new object[] {
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
            this.cmbİlKod.Location = new System.Drawing.Point(136, 409);
            this.cmbİlKod.Name = "cmbİlKod";
            this.cmbİlKod.Size = new System.Drawing.Size(121, 21);
            this.cmbİlKod.TabIndex = 17;
            this.cmbİlKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbİlKod_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(361, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 442);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracIDDataGridViewTextBoxColumn,
            this.aracPlakaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.uretimYiliDataGridViewTextBoxColumn,
            this.aracTipiDataGridViewTextBoxColumn,
            this.yakitDataGridViewTextBoxColumn,
            this.sanzimanTipiDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.ilKoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracEkleTablosuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // aracIDDataGridViewTextBoxColumn
            // 
            this.aracIDDataGridViewTextBoxColumn.DataPropertyName = "aracID";
            this.aracIDDataGridViewTextBoxColumn.HeaderText = "aracID";
            this.aracIDDataGridViewTextBoxColumn.Name = "aracIDDataGridViewTextBoxColumn";
            this.aracIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aracPlakaDataGridViewTextBoxColumn
            // 
            this.aracPlakaDataGridViewTextBoxColumn.DataPropertyName = "aracPlaka";
            this.aracPlakaDataGridViewTextBoxColumn.HeaderText = "aracPlaka";
            this.aracPlakaDataGridViewTextBoxColumn.Name = "aracPlakaDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // uretimYiliDataGridViewTextBoxColumn
            // 
            this.uretimYiliDataGridViewTextBoxColumn.DataPropertyName = "uretimYili";
            this.uretimYiliDataGridViewTextBoxColumn.HeaderText = "uretimYili";
            this.uretimYiliDataGridViewTextBoxColumn.Name = "uretimYiliDataGridViewTextBoxColumn";
            // 
            // aracTipiDataGridViewTextBoxColumn
            // 
            this.aracTipiDataGridViewTextBoxColumn.DataPropertyName = "aracTipi";
            this.aracTipiDataGridViewTextBoxColumn.HeaderText = "aracTipi";
            this.aracTipiDataGridViewTextBoxColumn.Name = "aracTipiDataGridViewTextBoxColumn";
            // 
            // yakitDataGridViewTextBoxColumn
            // 
            this.yakitDataGridViewTextBoxColumn.DataPropertyName = "yakit";
            this.yakitDataGridViewTextBoxColumn.HeaderText = "yakit";
            this.yakitDataGridViewTextBoxColumn.Name = "yakitDataGridViewTextBoxColumn";
            // 
            // sanzimanTipiDataGridViewTextBoxColumn
            // 
            this.sanzimanTipiDataGridViewTextBoxColumn.DataPropertyName = "sanzimanTipi";
            this.sanzimanTipiDataGridViewTextBoxColumn.HeaderText = "sanzimanTipi";
            this.sanzimanTipiDataGridViewTextBoxColumn.Name = "sanzimanTipiDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // ilKoduDataGridViewTextBoxColumn
            // 
            this.ilKoduDataGridViewTextBoxColumn.DataPropertyName = "ilKodu";
            this.ilKoduDataGridViewTextBoxColumn.HeaderText = "ilKodu";
            this.ilKoduDataGridViewTextBoxColumn.Name = "ilKoduDataGridViewTextBoxColumn";
            // 
            // aracEkleTablosuBindingSource
            // 
            this.aracEkleTablosuBindingSource.DataMember = "aracEkleTablosu";
            this.aracEkleTablosuBindingSource.DataSource = this.theNorthDBODataSet;
            // 
            // theNorthDBODataSet
            // 
            this.theNorthDBODataSet.DataSetName = "TheNorthDBODataSet";
            this.theNorthDBODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(271, 473);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(147, 473);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(27, 473);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // aracEkleTablosuTableAdapter
            // 
            this.aracEkleTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // txtSanziman
            // 
            this.txtSanziman.Location = new System.Drawing.Point(136, 327);
            this.txtSanziman.Name = "txtSanziman";
            this.txtSanziman.Size = new System.Drawing.Size(100, 20);
            this.txtSanziman.TabIndex = 26;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(136, 366);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 28;
            this.txtUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUcret_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(24, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Silme işlemi için yalnızca PLAKA giriniz";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(24, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(322, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Güncellemek isteddiğiniz aracı araç bilgileri bölümünden seçiniz!!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1152, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtSanziman);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbİlKod);
            this.Controls.Add(this.txtYakit);
            this.Controls.Add(this.txtAracTip);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracEkleTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theNorthDBODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAracTip;
        private System.Windows.Forms.TextBox txtYakit;
        private System.Windows.Forms.ComboBox cmbİlKod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private TheNorthDBODataSet theNorthDBODataSet;
        private System.Windows.Forms.BindingSource aracEkleTablosuBindingSource;
        private TheNorthDBODataSetTableAdapters.aracEkleTablosuTableAdapter aracEkleTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanzimanTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSanziman;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}