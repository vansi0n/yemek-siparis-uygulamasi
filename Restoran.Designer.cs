namespace Geliyo
{
    partial class Restoran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restoran));
            this.labelRestoranAd = new System.Windows.Forms.Label();
            this.listBoxMenuler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSiparis = new System.Windows.Forms.Button();
            this.labelMenuAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelIcerik = new System.Windows.Forms.Label();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonYorumlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRestoranAd
            // 
            this.labelRestoranAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRestoranAd.Location = new System.Drawing.Point(194, 6);
            this.labelRestoranAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRestoranAd.Name = "labelRestoranAd";
            this.labelRestoranAd.Size = new System.Drawing.Size(257, 39);
            this.labelRestoranAd.TabIndex = 0;
            this.labelRestoranAd.Text = "RestoranIsmi";
            this.labelRestoranAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxMenuler
            // 
            this.listBoxMenuler.FormattingEnabled = true;
            this.listBoxMenuler.Location = new System.Drawing.Point(16, 38);
            this.listBoxMenuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMenuler.Name = "listBoxMenuler";
            this.listBoxMenuler.Size = new System.Drawing.Size(147, 264);
            this.listBoxMenuler.TabIndex = 1;
            this.listBoxMenuler.SelectedIndexChanged += new System.EventHandler(this.listBoxMenuler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menüler";
            // 
            // buttonSiparis
            // 
            this.buttonSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSiparis.Image = ((System.Drawing.Image)(resources.GetObject("buttonSiparis.Image")));
            this.buttonSiparis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSiparis.Location = new System.Drawing.Point(167, 280);
            this.buttonSiparis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSiparis.Name = "buttonSiparis";
            this.buttonSiparis.Size = new System.Drawing.Size(284, 61);
            this.buttonSiparis.TabIndex = 3;
            this.buttonSiparis.Text = "Sepete Ekle";
            this.buttonSiparis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSiparis.UseVisualStyleBackColor = true;
            this.buttonSiparis.Click += new System.EventHandler(this.buttonSiparis_Click);
            // 
            // labelMenuAd
            // 
            this.labelMenuAd.AutoSize = true;
            this.labelMenuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMenuAd.Location = new System.Drawing.Point(167, 46);
            this.labelMenuAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuAd.Name = "labelMenuAd";
            this.labelMenuAd.Size = new System.Drawing.Size(123, 24);
            this.labelMenuAd.TabIndex = 4;
            this.labelMenuAd.Text = "labelMenuAd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "İçerik:";
            // 
            // labelFiyat
            // 
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.Location = new System.Drawing.Point(176, 259);
            this.labelFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(274, 18);
            this.labelFiyat.TabIndex = 6;
            this.labelFiyat.Text = "Fiyat:";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIcerik
            // 
            this.labelIcerik.AutoSize = true;
            this.labelIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIcerik.Location = new System.Drawing.Point(169, 109);
            this.labelIcerik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIcerik.Name = "labelIcerik";
            this.labelIcerik.Size = new System.Drawing.Size(46, 18);
            this.labelIcerik.TabIndex = 7;
            this.labelIcerik.Text = "label3";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(16, 307);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(72, 33);
            this.buttonGeri.TabIndex = 8;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonYorumlar
            // 
            this.buttonYorumlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYorumlar.Image = ((System.Drawing.Image)(resources.GetObject("buttonYorumlar.Image")));
            this.buttonYorumlar.Location = new System.Drawing.Point(93, 306);
            this.buttonYorumlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYorumlar.Name = "buttonYorumlar";
            this.buttonYorumlar.Size = new System.Drawing.Size(70, 34);
            this.buttonYorumlar.TabIndex = 9;
            this.buttonYorumlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYorumlar.UseVisualStyleBackColor = true;
            this.buttonYorumlar.Click += new System.EventHandler(this.buttonYorumlar_Click);
            // 
            // Restoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(460, 351);
            this.Controls.Add(this.buttonYorumlar);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.labelIcerik);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMenuAd);
            this.Controls.Add(this.buttonSiparis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMenuler);
            this.Controls.Add(this.labelRestoranAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Restoran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoran";
            this.Load += new System.EventHandler(this.Restoran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRestoranAd;
        private System.Windows.Forms.ListBox listBoxMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSiparis;
        private System.Windows.Forms.Label labelMenuAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelIcerik;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonYorumlar;
    }
}