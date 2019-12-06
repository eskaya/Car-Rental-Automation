using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace The_North_Rent_System
{
    public partial class MainPage : Form
    {
        DBOClass kullanici;

        public MainPage()
        {
            InitializeComponent();
            kullanici = new DBOClass();
        }

        private void kullaniciEkle_Click(object sender, EventArgs e)
        {
            
            if (DBOClass.kullanicininYetki == "SuperAdmin")
            {
                KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri();
                kullaniciBilgileri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş yapabilmek için yeterli yetkiniz yok!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıRaporu_Click(object sender, EventArgs e)
        {
            KullaniciRapor kullaniciRapor = new KullaniciRapor();
            kullaniciRapor.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}







