namespace Geliyo
{
    partial class MiktarGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiktarGuncelleme));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.comboBoxAdet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuncelle.Location = new System.Drawing.Point(50, 50);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(164, 45);
            this.buttonGuncelle.TabIndex = 6;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // comboBoxAdet
            // 
            this.comboBoxAdet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdet.FormattingEnabled = true;
            this.comboBoxAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxAdet.Location = new System.Drawing.Point(124, 20);
            this.comboBoxAdet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAdet.Name = "comboBoxAdet";
            this.comboBoxAdet.Size = new System.Drawing.Size(66, 21);
            this.comboBoxAdet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet";
            // 
            // MiktarGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(254, 106);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.comboBoxAdet);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MiktarGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Güncelleme";
            this.Load += new System.EventHandler(this.MiktarGuncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.ComboBox comboBoxAdet;
        private System.Windows.Forms.Label label4;
    }
}