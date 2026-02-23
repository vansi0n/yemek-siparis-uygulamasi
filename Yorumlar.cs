using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geliyo
{
    public partial class Yorumlar : Form
    {
        public Yorumlar()
        {
            InitializeComponent();
        }

        private void buttonYorumYap_Click(object sender, EventArgs e)
        {
            string yorum = textBoxYorum.Text;
            if (string.IsNullOrEmpty(yorum))
                return;

            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            string kullanici = Program.AktifKullanici.KullaniciIsim;

            var cmd = new SqlCommand("insert into yorumlar values (@restoran, @kullanici, @metin)", Program.Conn);
            cmd.Parameters.AddWithValue("@restoran", Program.AktifRestoran.RestoranID);
            cmd.Parameters.AddWithValue("@kullanici", kullanici);
            cmd.Parameters.AddWithValue("@metin", yorum);
            cmd.ExecuteNonQuery();

            Program.Conn.Close();

            MessageBox.Show("Yorumunuz gönderildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxYorum.Text = "";

            YorumlarıGetir();
        }

        void YorumlarıGetir()
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            var cmd = new SqlCommand("select * from yorumlar where yorumRestoran=@id", Program.Conn);
            cmd.Parameters.AddWithValue("@id", Program.AktifRestoran.RestoranID);

            var yorumlar = new List<YorumGosterim>();

            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yorumlar.Add(new YorumGosterim
                {
                    YorumID = (int)rd[0],
                    YorumYazan = (string)rd[2],
                    Yorum = (string)rd[3],
                });
            }
            rd.Close();

            dataGridViewYorumlar.DataSource = yorumlar;

            if (dataGridViewYorumlar.Columns.Contains("YorumID"))
                dataGridViewYorumlar.Columns["YorumID"].Visible = false;
            //siparisGrid.display = "RestoranIsim";
            //siparisGrid.ValueMember = "RestoranID";

            Program.Conn.Close();
        }

        private void Yorumlar_Load(object sender, EventArgs e)
        {
            YorumlarıGetir();
        }
    }
}
