using System;
using System.Data.SqlClient;

namespace The_North_Rent_System
{
    class DBOClass
    {
        static string baglantiString = "Data Source = IBRAHIM-VOENUVZ; Initial Catalog = TheNorthDBO; Integrated Security = True";
        public SqlConnection baglantiS = new SqlConnection(baglantiString);
        SqlCommand sqlKomut;
        public SqlDataAdapter sqlDataSorgu; // Kullanıcıları listelemek için sqlData adapter
        public SqlDataReader reader; // Tablodan veri okumak!


        public bool yetkiDurum; // Bazı sayfaları açabilmek için yetki gerekli
        public static string kullanicininYetki; //Buradan dönen değer mainpage de kontrol ediliyor!


        public bool FirstPageLogin(string kullaniciAdi, string sifre)
        {
            bool durum = false;
            string sorguGir = "SELECT * FROM kullaniciTablosu2 WHERE kullaniciMailAdres=@kullaniciMailData AND kullaniciSifre=@sifreData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", kullaniciAdi);
            sqlKomut.Parameters.AddWithValue("@sifreData", sifre);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                durum = true;
            else
                durum = false;

            reader.Close();
            return durum;
        }

        public bool YetkiOgrenme(string kullaniciAdi)
        {
            string sorgu = "SELECT kullaniciYetkisi FROM kullaniciTablosu2 WHERE kullaniciMailAdres=@mailAdres;";
            sqlKomut = new SqlCommand(sorgu, baglantiS);
            sqlKomut.Parameters.AddWithValue("@mailAdres", kullaniciAdi);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            sqlDataSorgu = new SqlDataAdapter(sqlKomut);
            reader = sqlKomut.ExecuteReader();
            if (reader.Read())
            {
                kullanicininYetki = reader["kullaniciYetkisi"].ToString();
                yetkiDurum = true;
            }
            baglantiS.Close();
            return yetkiDurum;
        }

        public bool KisiMailKontrol(string kullaniciAdi)
        {
            bool kisiVar = false;
            string sorguGir = "SELECT * FROM kullaniciTablosu2 WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", kullaniciAdi);
            if(baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                kisiVar = true;
            else
                kisiVar = false;
            reader.Close();
            return kisiVar;
        }
        //Aşağıdaki Listeleme fonksiyonunda gerekli verileri çekip grid data source da listelemeye yarıyor!
       
        //Buradan girilen değişkene göre farklı farklı listeleme yapabiliriz!
        public SqlDataAdapter Listele(string gelenTablo)
        {
            if (gelenTablo == "kullaniciTablosu2")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT kullaniciMailAdres," +
                    "kullaniciAdSoyad,kullaniciTelefon,kullaniciYetkisi," +
                    "ilKodu FROM kullaniciTablosu2", baglantiString);
            }
            else if (gelenTablo == "aracEkleTablosu")
                sqlDataSorgu = new SqlDataAdapter("SELECT * FROM aracEkleTablosu", baglantiString);

            else if (gelenTablo == "rezervasyonOlustur")
                sqlDataSorgu = new SqlDataAdapter("SELECT * FROM rezervasyonOlustur", baglantiString);

            baglantiS.Close();
            return sqlDataSorgu;
        }

        public bool kullaniciEkleme(string adSoyad, string eMailAdres, string telefon, string sifre, string kullaniciYetki, string ilKod)
        {
            bool durum = false;

            string sorguGir = "INSERT INTO kullaniciTablosu2 VALUES(@eMailAdres,@adSoyad,@telefon,@sifre,@kullaniciYetki,@ilKod);";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@eMailAdres", eMailAdres);
            sqlKomut.Parameters.AddWithValue("@adSoyad", adSoyad);
            sqlKomut.Parameters.AddWithValue("@telefon", telefon);
            sqlKomut.Parameters.AddWithValue("@sifre", sifre);
            sqlKomut.Parameters.AddWithValue("@kullaniciYetki", kullaniciYetki);
            sqlKomut.Parameters.AddWithValue("@ilKod", int.Parse((ilKod).ToString()));
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
                durum = false;
            }
            baglantiS.Close();
            return durum;
        }

        public bool KullaniciSilme(string eMailAdres)
        {
            bool durum = false;
            string sorguGir = "DELETE kullaniciTablosu2 FROM kullaniciTablosu2 WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", eMailAdres);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {

            }
            baglantiS.Close();
            return durum;
        }

        public bool GuncellemeBilgileriGetir(string eMailAdres)
        {
            bool guncellemeDurum = false;
            string sorgu = "SELECT * FROM kullaniciTablosu2 WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorgu, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", eMailAdres);
            sqlDataSorgu = new SqlDataAdapter(sqlKomut);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            if (reader.Read())
            {
                guncellemeDurum = true;
            }
            return guncellemeDurum;
        }

        public bool GuncellemeIslemi(string eMail, string adSoyad, string telefon, string sifre, string yetki, string ilKod)
        {
            bool basariliMi = false;
            string sorguGir = "UPDATE kullaniciTablosu2 SET " +
                "kullaniciAdSoyad=@kAd,kullaniciTelefon=@kTelefon,kullaniciSifre=@kSifre," +
                "kullaniciYetkisi=@kYetki,ilKodu=@kilKod WHERE kullaniciMailAdres=@mailAdres;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@mailAdres", eMail);
            sqlKomut.Parameters.AddWithValue("@kAd", adSoyad);
            sqlKomut.Parameters.AddWithValue("@kTelefon", telefon);
            sqlKomut.Parameters.AddWithValue("@kSifre", sifre);
            sqlKomut.Parameters.AddWithValue("@kYetki", yetki);
            sqlKomut.Parameters.AddWithValue("@kilKod", ilKod);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                basariliMi = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                basariliMi = false;
                baglantiS.Close();
            }

            return basariliMi;
        }

    }
}
