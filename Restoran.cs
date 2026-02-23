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
    public partial class Restoran : Form
    {
        public Restoran()
        {
            InitializeComponent();
        }

        private void Restoran_Load(object sender, EventArgs e)
        {
            labelRestoranAd.Text = Program.AktifRestoran.RestoranIsim;
            MenuleriListele();
        }

        void MenuleriListele()
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            var restoran = Program.AktifRestoran;
            var cmd = new SqlCommand($"select * from menuler where menuRestoran=@id", Program.Conn);
            cmd.Parameters.AddWithValue("@id", restoran.RestoranID);
            var rd = cmd.ExecuteReader();
            var ilceler = new List<MenuGosterim>();
            while (rd.Read())
            {
                ilceler.Add(new MenuGosterim
                {
                    MenuID = (int)rd[0],
                    MenuRestoran = (int)rd[1],
                    MenuFiyat = (int)rd[2],
                    MenuAd = (string)rd[3],
                    MenuIcerik = (string)rd[4],
                });
            }

            listBoxMenuler.DataSource = ilceler;
            listBoxMenuler.DisplayMember = "MenuAd";
            listBoxMenuler.ValueMember = "MenuID";

            Program.Conn.Close();
        }

        private void listBoxMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var menu = (MenuGosterim)listBoxMenuler.SelectedItem;
            Program.AktifMenu = menu;

            labelMenuAd.Text = menu.MenuAd;
            labelFiyat.Text = $"Fiyat: {menu.MenuFiyat}₺";
            labelIcerik.Text = "";
            var split = menu.MenuIcerik.Split(',');

            foreach (var icerik in split)
            {
                var ilkHarf = icerik.Trim().First().ToString();
                labelIcerik.Text += $"- {ilkHarf.ToUpper() + icerik.Trim().Substring(1)}\n";
            }
        }

        private void buttonSiparis_Click(object sender, EventArgs e)
        {
            var siparis = new SiparisEkrani();
            siparis.ShowDialog();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonYorumlar_Click(object sender, EventArgs e)
        {
            var yorumlar = new Yorumlar();
            yorumlar.ShowDialog();
        }
    }
}
