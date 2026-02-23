namespace Geliyo
{
    partial class SiparisSonucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisSonucu));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş detayları";
            // 
            // listBoxSiparisler
            // 
            this.listBoxSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.HorizontalScrollbar = true;
            this.listBoxSiparisler.ItemHeight = 26;
            this.listBoxSiparisler.Location = new System.Drawing.Point(9, 41);
            this.listBoxSiparisler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(497, 264);
            this.listBoxSiparisler.TabIndex = 1;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(212, 309);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(98, 41);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // SiparisSonucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(514, 354);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SiparisSonucu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detayı";
            this.Load += new System.EventHandler(this.SiparisSonucu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Button buttonGeri;
    }
}