namespace Geliyo
{
    partial class Sepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sepet));
            this.siparisGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonMiktarDegistir = new System.Windows.Forms.Button();
            this.buttonOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siparisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisGrid
            // 
            this.siparisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisGrid.Location = new System.Drawing.Point(9, 36);
            this.siparisGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siparisGrid.MultiSelect = false;
            this.siparisGrid.Name = "siparisGrid";
            this.siparisGrid.ReadOnly = true;
            this.siparisGrid.RowHeadersWidth = 51;
            this.siparisGrid.RowTemplate.Height = 24;
            this.siparisGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siparisGrid.Size = new System.Drawing.Size(881, 277);
            this.siparisGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sepetiniz";
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.Location = new System.Drawing.Point(753, 325);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(137, 36);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sepeti Sil";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonMiktarDegistir
            // 
            this.buttonMiktarDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMiktarDegistir.Image = ((System.Drawing.Image)(resources.GetObject("buttonMiktarDegistir.Image")));
            this.buttonMiktarDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMiktarDegistir.Location = new System.Drawing.Point(9, 325);
            this.buttonMiktarDegistir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMiktarDegistir.Name = "buttonMiktarDegistir";
            this.buttonMiktarDegistir.Size = new System.Drawing.Size(188, 36);
            this.buttonMiktarDegistir.TabIndex = 2;
            this.buttonMiktarDegistir.Text = "Miktar Değiştir";
            this.buttonMiktarDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMiktarDegistir.UseVisualStyleBackColor = true;
            this.buttonMiktarDegistir.Click += new System.EventHandler(this.buttonMiktarDegistir_Click);
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnayla.Image = ((System.Drawing.Image)(resources.GetObject("buttonOnayla.Image")));
            this.buttonOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOnayla.Location = new System.Drawing.Point(358, 325);
            this.buttonOnayla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(186, 36);
            this.buttonOnayla.TabIndex = 3;
            this.buttonOnayla.Text = "Sepeti Onayla";
            this.buttonOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(899, 370);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.buttonMiktarDegistir);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siparisGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView siparisGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonMiktarDegistir;
        private System.Windows.Forms.Button buttonOnayla;
    }
}