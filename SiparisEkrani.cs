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
    public partial class SiparisEkrani : Form
    {
        public SiparisEkrani()
        {
            InitializeComponent();
        }

        private void buttonGelsin_Click(object sender, EventArgs e)
        {
            if (textBoxAdres.Text == ""
                || textBoxIsim.Text == ""
                || textBoxTelefon.Text == "")
            {
                MessageBox.Show("Alanları uygun bir şekilde doldurunuz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            string kullanici = Program.AktifKullanici.KullaniciIsim;
            var cmd2 = new SqlCommand("select * from aktifSiparisler where siparisKullanici=@k", Program.Conn);
            cmd2.Parameters.AddWithValue("@k", kullanici);

            var rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                var restoranID = (int)rd2[1];
                if (restoranID != Program.AktifRestoran.RestoranID)
                {
                    MessageBox.Show("Sepetinizde başka bir restorandan ürün bulunmaktadır, aynı anda sadece tek bir restorandan sipariş verebilirsiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.Conn.Close();
                    return;
                }
            }
            rd2.Close();

            var cmd = new SqlCommand("insert into aktifSiparisler values (@restoran, @menu, @miktar, @telefon, @kullanici, @veren, @adres, @durum)", Program.Conn);
            cmd.Parameters.AddWithValue("@restoran", Program.AktifRestoran.RestoranID);
            cmd.Parameters.AddWithValue("@menu", Program.AktifMenu.MenuID);
            cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(comboBoxAdet.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
            cmd.Parameters.AddWithValue("@kullanici", Program.AktifKullanici.KullaniciIsim);
            cmd.Parameters.AddWithValue("@veren", textBoxIsim.Text);
            cmd.Parameters.AddWithValue("@adres", textBoxAdres.Text);

            int rnd = new Random().Next(4);

            string rastgeleDurum = "";
            if (rnd == 0)
                rastgeleDurum = "Sipariş alındı.";
            else if (rnd == 1)
                rastgeleDurum = "Hazırlanıyo.";
            else if (rnd == 2)
                rastgeleDurum = "Geliyo!";
            else if (rnd == 3)
                rastgeleDurum = "Teslim edildi.";

            cmd.Parameters.AddWithValue("@durum", rastgeleDurum);

            cmd.ExecuteNonQuery();
            
            Program.Conn.Close();

            MessageBox.Show("Ürün sepete eklendi.", "Ürün eklendi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {
            comboBoxAdet.SelectedIndex = 0;
        }
    }
}
