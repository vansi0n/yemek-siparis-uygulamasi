namespace Geliyo
{
    partial class Yorumlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yorumlar));
            this.dataGridViewYorumlar = new System.Windows.Forms.DataGridView();
            this.textBoxYorum = new System.Windows.Forms.TextBox();
            this.buttonYorumYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYorumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewYorumlar
            // 
            this.dataGridViewYorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYorumlar.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewYorumlar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewYorumlar.MultiSelect = false;
            this.dataGridViewYorumlar.Name = "dataGridViewYorumlar";
            this.dataGridViewYorumlar.ReadOnly = true;
            this.dataGridViewYorumlar.RowHeadersWidth = 51;
            this.dataGridViewYorumlar.RowTemplate.Height = 24;
            this.dataGridViewYorumlar.Size = new System.Drawing.Size(381, 188);
            this.dataGridViewYorumlar.TabIndex = 0;
            // 
            // textBoxYorum
            // 
            this.textBoxYorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYorum.Location = new System.Drawing.Point(9, 203);
            this.textBoxYorum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYorum.Name = "textBoxYorum";
            this.textBoxYorum.Size = new System.Drawing.Size(276, 26);
            this.textBoxYorum.TabIndex = 1;
            // 
            // buttonYorumYap
            // 
            this.buttonYorumYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYorumYap.Location = new System.Drawing.Point(288, 203);
            this.buttonYorumYap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonYorumYap.Name = "buttonYorumYap";
            this.buttonYorumYap.Size = new System.Drawing.Size(102, 24);
            this.buttonYorumYap.TabIndex = 2;
            this.buttonYorumYap.Text = "Yorum Yap";
            this.buttonYorumYap.UseVisualStyleBackColor = true;
            this.buttonYorumYap.Click += new System.EventHandler(this.buttonYorumYap_Click);
            // 
            // Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(399, 234);
            this.Controls.Add(this.buttonYorumYap);
            this.Controls.Add(this.textBoxYorum);
            this.Controls.Add(this.dataGridViewYorumlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Yorumlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yorumlar";
            this.Load += new System.EventHandler(this.Yorumlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYorumlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewYorumlar;
        private System.Windows.Forms.TextBox textBoxYorum;
        private System.Windows.Forms.Button buttonYorumYap;
    }
}