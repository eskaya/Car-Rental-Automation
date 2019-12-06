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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
           this.rezervasyonOlusturTableAdapter3.Fill(this.theNorthDBODataSet11.rezervasyonOlustur);
                    
           this.aracEkleTablosuTableAdapter3.Fill(this.theNorthDBODataSet8.aracEkleTablosu);
                     
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtMusteri.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKiraBas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtKiraSon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
           
        }
       
        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;


            txtPlaka.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txtUcret.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(txtKiraSure.Text);
            int ucret = Convert.ToInt32(txtUcret.Text);

            int carpim = gun * ucret;

            txtTopUcret.Text = Convert.ToString(carpim);
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "1";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
           label12.Text="0";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update rezervasyonOlustur Set odeme=@g1 where rezervasyonID=@g2",baglanti);
            guncelle.Parameters.AddWithValue("@g1", label12.Text);
            guncelle.Parameters.AddWithValue("@g2", textBox1.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Ödeme Bilgileri Eklendi");
            this.rezervasyonOlusturTableAdapter2.Fill(this.theNorthDBODataSet10.rezervasyonOlustur);
            this.rezervasyonOlusturTableAdapter1.Fill(this.theNorthDBODataSet9.rezervasyonOlustur);
            baglanti.Close();
        }

        private void TxtKiraSon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtKiraSon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;  //string karakter girişi engellenir
            }
        }

        private void TxtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;  //string karakter girişi engellenir
            }
        }
    }
}
