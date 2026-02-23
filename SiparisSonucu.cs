using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geliyo
{
    public partial class SiparisSonucu : Form
    {
        public List<SiparisGosterim> Siparisler;

        public SiparisSonucu()
        {
            InitializeComponent();
        }

        private void SiparisSonucu_Load(object sender, EventArgs e)
        {
            foreach (var siparis in Siparisler)
            {
                string metin = $"{siparis.SiparisMenu}, Miktar: {siparis.SiparisMiktar}, Veren: {siparis.SiparisVeren}, Adres: {siparis.SiparisAdres}";
                listBoxSiparisler.Items.Add(metin);
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
