using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_North_Rent_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8C5JIMN; Initial Catalog = TheNorthDBO; Integrated Security = True");

        private void Button1_Click(object sender, EventArgs e)
        {
            MainPage anaSayfa = new MainPage();
            anaSayfa.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theNorthDBODataSet.aracEkleTablosu' table. You can move, or remove it, as needed.
            this.aracEkleTablosuTableAdapter.Fill(this.theNorthDBODataSet.aracEkleTablosu);
            txtPlaka.Focus();
        }
        void Temizle()
        {
            txtPlaka.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            textBox1.Text = "";
            txtAracTip.Text = "";
            txtYakit.Text = "";
            txtSanziman.Text = "";
            txtUcret.Text = "";
            cmbİlKod.Text = "";
            txtPlaka.Focus();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("insert into aracEkleTablosu (aracPlaka,marka,model,uretimYili,aracTipi,yakit,sanzimanTipi,ucret,ilKodu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", txtAracTip.Text);
            komut.Parameters.AddWithValue("@p6", txtYakit.Text);
            komut.Parameters.AddWithValue("@p7", txtSanziman.Text);
            komut.Parameters.AddWithValue("@p8", txtUcret.Text);
            komut.Parameters.AddWithValue("@p9", cmbİlKod.Text);
            if (txtPlaka.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && textBox1.Text != "" && txtAracTip.Text != "" && txtYakit.Text != "" &&txtSanziman.Text != "" && txtUcret.Text != "" && cmbİlKod.Text != "")
            {
                  
                    komut.ExecuteNonQuery();
                this.aracEkleTablosuTableAdapter.Fill(this.theNorthDBODataSet.aracEkleTablosu);

                MessageBox.Show("Yeni Araç Eklendi..");
                Temizle();
            }

            else
            {
                MessageBox.Show("İlgili Alanları Eksiksiz Doldurunuz!!!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();


        } 

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From aracEkleTablosu where aracPlaka=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", txtPlaka.Text);
            komutsil.ExecuteNonQuery();
            this.aracEkleTablosuTableAdapter.Fill(this.theNorthDBODataSet.aracEkleTablosu);
            baglanti.Close();
            MessageBox.Show("Araç Silindi..");
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update aracEkleTablosu Set aracPlaka=@g1,marka=@g2,model=@g3,uretimYili=@g4,aracTipi=@g5,yakit=@g6,sanzimanTipi=@g7,ucret=@g8,ilKodu=@g9 where aracID=@g10", baglanti);
            guncelle.Parameters.AddWithValue("@g1", txtPlaka.Text);
            guncelle.Parameters.AddWithValue("@g2", txtMarka.Text);
            guncelle.Parameters.AddWithValue("@g3", txtModel.Text);
            guncelle.Parameters.AddWithValue("@g4", textBox1.Text);
            guncelle.Parameters.AddWithValue("@g5", txtAracTip.Text);
            guncelle.Parameters.AddWithValue("@g6", txtYakit.Text);
            guncelle.Parameters.AddWithValue("@g7", txtSanziman.Text);
            guncelle.Parameters.AddWithValue("@g8", txtUcret.Text);
            guncelle.Parameters.AddWithValue("@g9", cmbİlKod.Text);
            guncelle.Parameters.AddWithValue("@g10", textBox2.Text);
            guncelle.ExecuteNonQuery();
            this.aracEkleTablosuTableAdapter.Fill(this.theNorthDBODataSet.aracEkleTablosu);
            baglanti.Close();
            MessageBox.Show("Araç Bilgileri Güncellendi!!!");
            Temizle();

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            
            txtPlaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtModel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAracTip.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtYakit.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtSanziman.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            cmbİlKod.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


        }

        private void CmbİlKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true; // string karakter girişi engellenir
            }
        }

        private void TxtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false)
            {
                e.Handled = true; // string karakter girişi engellenir
            }

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;  //string karakter girişi engellenir
            }
        }
    }
}
