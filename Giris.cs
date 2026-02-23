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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            labelİlce.Visible = false;
            comboBoxIlce.Visible = false;

            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();
            var cmd = new SqlCommand("select * from iller", Program.Conn);
            var rd = cmd.ExecuteReader();
            var iller = new List<IlGosterim>();
            iller.Add(new IlGosterim { IlID = -1, IlIsim = "" });
            while (rd.Read())
            {
                iller.Add(new IlGosterim { IlID = (int)rd[0], IlIsim = (string)rd[1] });
            }
            rd.Close();
            Program.Conn.Close();

            comboBoxIl.DataSource = iller;
            comboBoxIl.DisplayMember = "IlIsim";
            comboBoxIl.ValueMember = "IlID";

            comboBoxIl.SelectedIndex = 0;
        }

        private void comboBoxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            var ilID = (IlGosterim)comboBoxIl.SelectedItem;
            if (ilID.IlID == -1)
            {
                labelİlce.Visible = false;
                comboBoxIlce.Visible = false;
                return;
            }
            var cmd = new SqlCommand($"select * from ilceler where ilceIl=@id", Program.Conn);
            cmd.Parameters.AddWithValue("@id", ilID.IlID);
            var rd = cmd.ExecuteReader();
            var ilceler = new List<IlceGosterim>();
            while (rd.Read())
            {
                ilceler.Add(new IlceGosterim { IlceID = (int)rd[0], IlceIsim = (string)rd[1] });
            }

            comboBoxIlce.DataSource = ilceler;
            comboBoxIlce.DisplayMember = "IlceIsim";
            comboBoxIlce.ValueMember = "IlceID";

            labelİlce.Visible = true;
            comboBoxIlce.Visible = true;

            Program.Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((IlGosterim)comboBoxIl.SelectedItem).IlID == -1)
                return;

            var il = (IlGosterim)comboBoxIl.SelectedItem;
            var ilce = (IlceGosterim)comboBoxIlce.SelectedItem;
            Program.AktifIl = il;
            Program.AktifIlce = ilce;

            this.Hide();

            using (var f1 = new Form1())
            {
                // This will block here until Form1—and anything it ShowDialog()s—are closed
                f1.ShowDialog();
            }

            // Once form1 and all its child dialogs have closed:
            this.Show();
        }
    }
}
