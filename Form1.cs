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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geliyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.AktifIl == null && Program.AktifIlce == null)
            {
                var form2 = new Giris();
                form2.ShowDialog();
            }
        }
   
        private void Form1_Shown(object sender, EventArgs e)
        {
            while (Program.AktifIl == null || Program.AktifIlce == null)
            {
                var form2 = new Giris();
                form2.ShowDialog();
            }

            labelKonum.Text = $"Konumunuz: {Program.AktifIl.IlIsim}, {Program.AktifIlce.IlceIsim}";
            RestoranListele();
        }

        void RestoranListele()
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            int ilID = Program.AktifIl.IlID;
            int ilceID = Program.AktifIlce.IlceID;
            var cmd = new SqlCommand($"select * from restoranlar where restoranIl={ilID} and restoranIlce={ilceID}", Program.Conn);
            var rd = cmd.ExecuteReader();
            var ilceler = new List<RestoranGosterim>();
            while (rd.Read())
            {
                ilceler.Add(new RestoranGosterim 
                { 
                    RestoranID = (int)rd[0],
                    RestoranIsim = (string)rd[1],
                    RestoranIl = (int)rd[2],
                    RestoranIlce = (int)rd[3]
                });
            }

            listBoxRestoranlar.DataSource = ilceler;
            listBoxRestoranlar.DisplayMember = "RestoranIsim";
            listBoxRestoranlar.ValueMember = "RestoranID";

            Program.Conn.Close();
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            var rest = (RestoranGosterim)listBoxRestoranlar.SelectedItem;
            Program.AktifRestoran = rest;

            var restoran = new Restoran();
            restoran.ShowDialog();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Program.Giris.Show();
            Close();
        }

        private void buttonSiparisler_Click(object sender, EventArgs e)
        {
            var sepet = new Sepet();
            sepet.ShowDialog();
        }
    }
}
