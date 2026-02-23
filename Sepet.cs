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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            SiparisleriGetir();
        }

        void SiparisleriGetir()
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            string kullanici = Program.AktifKullanici.KullaniciIsim;
            var cmd = new SqlCommand("select * from aktifSiparisler where siparisKullanici=@k", Program.Conn);
            cmd.Parameters.AddWithValue("@k", kullanici);

            var siparisler = new List<SiparisGosterim>();

            var rd = cmd.ExecuteReader();
            var siparisVerileri = new List<SiparisVeri>();
            while (rd.Read())
            {
                siparisVerileri.Add(new SiparisVeri
                {
                    SiparisID = (int)rd[0],
                    SiparisRestoran = (int)rd[1],
                    SiparisMenu = (int)rd[2],
                    SiparisMiktar = (int)rd[3],
                    SiparisTelefon = (string)rd[4],
                    SiparisVeren = (string)rd[6],
                    SiparisAdres = (string)rd[7],
                    SiparisDurum = (string)rd[8],
                });
            }
            rd.Close();

            foreach (var siparis in siparisVerileri)
            {
                var siparisGosterim = new SiparisGosterim()
                {
                    SiparisID = siparis.SiparisID,
                    SiparisAdres = siparis.SiparisAdres,
                    SiparisMiktar = siparis.SiparisMiktar,
                    SiparisTelefon = siparis.SiparisTelefon,
                    SiparisVeren = siparis.SiparisVeren
                };

                int id = siparis.SiparisRestoran;
                var cmd2 = new SqlCommand($"select * from restoranlar where restoranId=@id", Program.Conn);
                cmd2.Parameters.AddWithValue("@id", id);

                var rd2 = cmd2.ExecuteReader();
                RestoranGosterim restoran = null;
                while (rd2.Read())
                {
                    restoran = new RestoranGosterim
                    {
                        RestoranID = (int)rd2[0],
                        RestoranIsim = (string)rd2[1],
                        RestoranIl = (int)rd2[2],
                        RestoranIlce = (int)rd2[3]
                    };

                    siparisGosterim.SiparisRestoran = restoran.RestoranIsim;
                }
                rd2.Close();

                int ilID = restoran.RestoranIl;
                int ilceID = restoran.RestoranIlce;

                var cmd3 = new SqlCommand($"select * from iller where ilID=@id", Program.Conn);
                cmd3.Parameters.AddWithValue("@id", ilID);

                var cmd4 = new SqlCommand($"select * from ilceler where ilceID=@id", Program.Conn);
                cmd4.Parameters.AddWithValue("@id", ilceID);

                var rd3 = cmd3.ExecuteReader();
                while (rd3.Read())
                {
                    var il = new IlGosterim
                    {
                        IlID = (int)rd3[0],
                        IlIsim = (string)rd3[1],
                    };

                    siparisGosterim.SiparisIl = il.IlIsim;
                }
                rd3.Close();

                var rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    var ilce = new IlceGosterim
                    {
                        IlceID = (int)rd4[0],
                        IlceIsim = (string)rd4[1],
                    };

                    siparisGosterim.SiparisIlce = ilce.IlceIsim;
                }
                rd4.Close();

                int menuID = siparis.SiparisMenu;
                var cmd5 = new SqlCommand($"select * from menuler where menuID=@id", Program.Conn);
                cmd5.Parameters.AddWithValue("@id", menuID);
                var rd5 = cmd5.ExecuteReader();
                while (rd5.Read())
                {
                    var menu = new MenuGosterim
                    {
                        MenuAd = (string)rd5[3]
                    };

                    siparisGosterim.SiparisMenu = menu.MenuAd;
                }
                rd5.Close();

                siparisler.Add(siparisGosterim);
            }
            

            siparisGrid.DataSource = siparisler;

            if (siparisGrid.Columns.Contains("SiparisID"))
                siparisGrid.Columns["SiparisID"].Visible = false;
            //siparisGrid.display = "RestoranIsim";
            //siparisGrid.ValueMember = "RestoranID";

            Program.Conn.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (siparisGrid.Rows.Count == 0)
            {
                MessageBox.Show("Şu an hiç siparişiniz bulunmamaktadır.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            var sonuc = MessageBox.Show("Sepetinizi silmek istediğinizden emin misiniz?", "Sepetinizi silmek üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.No)
                return;

            SiparisleriSil();
        }

        void SiparisleriSil()
        {
            if (Program.Conn.State == ConnectionState.Closed)
                Program.Conn.Open();

            var cmd = new SqlCommand("delete from aktifSiparisler where siparisKullanici=@k", Program.Conn);
            cmd.Parameters.AddWithValue("@k", Program.AktifKullanici.KullaniciIsim);

            cmd.ExecuteNonQuery();

            Program.Conn.Close();

            SiparisleriGetir();
        }

        private void buttonMiktarDegistir_Click(object sender, EventArgs e)
        {
            if (siparisGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sipariş seçiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var siparis = (SiparisGosterim)siparisGrid.SelectedRows[0].DataBoundItem;
            Program.SeciliSiparis = siparis;

            var guncelleme = new MiktarGuncelleme();
            guncelleme.ShowDialog();

            SiparisleriGetir();
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            if (siparisGrid.Rows.Count == 0)
            {
                MessageBox.Show("Şu an hiç siparişiniz bulunmamaktadır.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Siparişleriniz onaylandı! Sipariş detaylarını görmek ister misiniz?", "Afiyet olsun!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (result == DialogResult.Yes)
            {
                var siparisDetay = new SiparisSonucu();
                siparisDetay.Siparisler = (List<SiparisGosterim>)siparisGrid.DataSource;
                siparisDetay.ShowDialog();
            }

            SiparisleriSil();
            Close();
        }
    }
}
