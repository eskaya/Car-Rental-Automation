﻿namespace The_North_Rent_System
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.kullaniciEkle = new System.Windows.Forms.Button();
            this.kullanıcıRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciEkle
            // 
            this.kullaniciEkle.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullaniciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullaniciEkle.FlatAppearance.BorderSize = 0;
            this.kullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciEkle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kullaniciEkle.Location = new System.Drawing.Point(154, 85);
            this.kullaniciEkle.Name = "kullaniciEkle";
            this.kullaniciEkle.Size = new System.Drawing.Size(137, 45);
            this.kullaniciEkle.TabIndex = 0;
            this.kullaniciEkle.Text = "Kullanıcı Bİlgileri";
            this.kullaniciEkle.UseVisualStyleBackColor = false;
            this.kullaniciEkle.Click += new System.EventHandler(this.kullaniciEkle_Click);
            // 
            // kullanıcıRaporu
            // 
            this.kullanıcıRaporu.BackColor = System.Drawing.Color.Transparent;
            this.kullanıcıRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullanıcıRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullanıcıRaporu.FlatAppearance.BorderSize = 0;
            this.kullanıcıRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanıcıRaporu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıRaporu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kullanıcıRaporu.Location = new System.Drawing.Point(154, 206);
            this.kullanıcıRaporu.Name = "kullanıcıRaporu";
            this.kullanıcıRaporu.Size = new System.Drawing.Size(137, 45);
            this.kullanıcıRaporu.TabIndex = 2;
            this.kullanıcıRaporu.Text = "Kullanıcı Raporu";
            this.kullanıcıRaporu.UseVisualStyleBackColor = false;
            this.kullanıcıRaporu.Click += new System.EventHandler(this.kullanıcıRaporu_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.kullanıcıRaporu);
            this.Controls.Add(this.kullaniciEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 726);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullaniciEkle;
        private System.Windows.Forms.Button kullanıcıRaporu;
    }
}