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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            string kullanici = textBoxIsim.Text;
            string sifre = textBoxSifre.Text;
            var cmd = new SqlCommand("select * from kullanicilar where kullaniciIsim=@k", Program.Conn);
            cmd.Parameters.AddWithValue("@k", kullanici);
            cmd.Parameters.AddWithValue("@s", sifre);

            KullaniciGosterim kullaniciGosterim = null;

            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if ((string)rd[0] == kullanici)
                {
                    if ((string)rd[1] == sifre)
                    {
                        kullaniciGosterim = new KullaniciGosterim();
                        kullaniciGosterim.KullaniciIsim = kullanici;
                        kullaniciGosterim.KullaniciSifre = sifre;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Şifrenizi yanlış girdiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.Conn.Close();
                        return;
                    }
                }
            }

            if (kullaniciGosterim == null)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Conn.Close();
                return;
            }

            Program.AktifKullanici = kullaniciGosterim;

            Program.Conn.Close();

            var form1 = new Giris();
            Program.Giris = form1;
            form1.Show();
            form1.FormClosed += (s, o) => Application.Exit();
            Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHakkında_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliyo\n\nHazırlayanlar:\n     * Nazlıgul Baykara (821620231016)\n     * Şafak Enes Yeşilöz (821620231048)", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
