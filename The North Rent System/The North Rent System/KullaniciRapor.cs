﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace The_North_Rent_System
{
    public partial class KullaniciRapor : Form
    {
        DBOClass kullanici;
        DataTable sqlData;

        public KullaniciRapor()
        {
            InitializeComponent();
            kullanici = new DBOClass();
        }

        private void KullaniciRapor_Load(object sender, EventArgs e)
        {
            try
            {
                kullanici.baglantiS.Open();
                kullanici.Listele("kullaniciTablosu2");
                TabloYenileme();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                kullanici.baglantiS.Close();
            }

        }

        private void pdfExport_Click(object sender, EventArgs e)
        {
            string thisDay = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            exportGrid(kullanicilarTablo, "Kullanıcılar Listesi "+ thisDay);

            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void TabloYenileme()
        {
            sqlData = new DataTable();
            kullanici.Listele("kullaniciTablosu2").Fill(sqlData);

            kullanicilarTablo.AllowUserToAddRows = false;
            kullanicilarTablo.AllowUserToDeleteRows = false;
            kullanicilarTablo.ReadOnly = true;
            kullanicilarTablo.DataSource = sqlData;
        }

        public void exportGrid(DataGridView dataGrid, string fileName)
        {
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            //Buradan aşağıda başlık bilgisi ekleniyor rapor'a
            PdfPTable pdfTitle = new PdfPTable(1);
            pdfTitle.DefaultCell.BorderWidth = 0;
            pdfTitle.WidthPercentage = 300;
            pdfTitle.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            Chunk chnkTitle = new Chunk("Kullanici Raporu", FontFactory.GetFont("Times New Roman"));
            chnkTitle.Font.Size = 40;
            pdfTitle.AddCell(new Phrase(chnkTitle));

            //Buradan aşağısında tarihi yazdırıyoruz!
            PdfPTable pdfDateTime = new PdfPTable(1);
            pdfDateTime.DefaultCell.BorderWidth = 0;
            pdfDateTime.WidthPercentage = 100;
            pdfDateTime.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;

            string thisDay = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Chunk dateString = new Chunk(thisDay, FontFactory.GetFont("Times New Roman"));
            dateString.Font.Size = 20;
            pdfDateTime.AddCell(new Phrase(dateString));

            //Alt tarafta pdf dosyasına ilgili tabşo yu yazdırıyoruz!
            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
            
            //Başlık Ekleme
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Satırları Ekleme
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTitle);
                    pdfDoc.Add(pdfDateTime);//Burada pdf dosyasına tarih'i yazdırıyoruz!
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
