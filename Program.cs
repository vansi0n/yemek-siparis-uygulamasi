using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geliyo
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KullaniciGiris());
        }

        public static SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=geliyoDB;Integrated Security=True");

        public static KullaniciGosterim AktifKullanici;

        public static IlGosterim AktifIl;
        public static IlceGosterim AktifIlce;
        public static RestoranGosterim AktifRestoran;
        public static MenuGosterim AktifMenu;
        public static SiparisGosterim SeciliSiparis;

        public static Giris Giris;
    }
}
