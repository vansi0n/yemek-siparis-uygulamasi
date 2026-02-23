namespace Geliyo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxRestoranlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKonum = new System.Windows.Forms.Label();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonSiparisler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRestoranlar
            // 
            this.listBoxRestoranlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxRestoranlar.FormattingEnabled = true;
            this.listBoxRestoranlar.ItemHeight = 30;
            this.listBoxRestoranlar.Location = new System.Drawing.Point(17, 52);
            this.listBoxRestoranlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxRestoranlar.Name = "listBoxRestoranlar";
            this.listBoxRestoranlar.Size = new System.Drawing.Size(588, 274);
            this.listBoxRestoranlar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Restoranlar";
            // 
            // labelKonum
            // 
            this.labelKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonum.Location = new System.Drawing.Point(144, 15);
            this.labelKonum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKonum.Name = "labelKonum";
            this.labelKonum.Size = new System.Drawing.Size(460, 34);
            this.labelKonum.TabIndex = 7;
            this.labelKonum.Text = "Konumunuz: Ankara, Keçiören";
            this.labelKonum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSec
            // 
            this.buttonSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSec.Location = new System.Drawing.Point(260, 347);
            this.buttonSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(93, 29);
            this.buttonSec.TabIndex = 8;
            this.buttonSec.Text = "Seç";
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(17, 347);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(99, 29);
            this.buttonGeri.TabIndex = 9;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonSiparisler
            // 
            this.buttonSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSiparisler.Image = ((System.Drawing.Image)(resources.GetObject("buttonSiparisler.Image")));
            this.buttonSiparisler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSiparisler.Location = new System.Drawing.Point(529, 347);
            this.buttonSiparisler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSiparisler.Name = "buttonSiparisler";
            this.buttonSiparisler.Size = new System.Drawing.Size(75, 31);
            this.buttonSiparisler.TabIndex = 11;
            this.buttonSiparisler.Text = "Sepet";
            this.buttonSiparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSiparisler.UseVisualStyleBackColor = true;
            this.buttonSiparisler.Click += new System.EventHandler(this.buttonSiparisler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(619, 386);
            this.Controls.Add(this.buttonSiparisler);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonSec);
            this.Controls.Add(this.labelKonum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRestoranlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geliyo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRestoranlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKonum;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonSiparisler;
    }
}

