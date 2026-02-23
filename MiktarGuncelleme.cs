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
    public partial class MiktarGuncelleme : Form
    {
        public MiktarGuncelleme()
        {
            InitializeComponent();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            var cmd = new SqlCommand("update aktifSiparisler set siparisMiktar=@miktar where siparisID=@id", Program.Conn);
            cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(comboBoxAdet.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("@id", Program.SeciliSiparis.SiparisID);
            cmd.ExecuteNonQuery();

            Program.Conn.Close();

            MessageBox.Show("Siparişiniz güncellendi!", "Afiyet olsun!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void MiktarGuncelleme_Load(object sender, EventArgs e)
        {
            comboBoxAdet.SelectedIndex = Program.SeciliSiparis.SiparisMiktar-1;
        }
    }
}
