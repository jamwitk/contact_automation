using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telefon_Rahberi
{
    public partial class GuncellemePenceresi : Form
    {
        public GuncellemePenceresi()
        {
            InitializeComponent();
        }

        private void GuncellemePenceresi_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARGE-DEV\\SQL2014;Initial Catalog=Stajyer_Egitim;Persist Security Info=True;User ID=Lgn_Egitim;Password=Egitim123!");
        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE ID = " + int.Parse(txtm_ara.Text), baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                lblM_ID.Text = dr1["ID"].ToString();
                txtK_adi.Text = dr1["[Kullanici_Adi]"].ToString();
                txtK_no.Text = dr1["[Telefon_Numarasi]"].ToString();
                txtEposta.Text = dr1["[Eposta]"].ToString();
                txtK_Not.Text = dr1["[K_Not]"].ToString();
                MessageBox.Show("Kayıt Başarıyla güncellenmiştir");
            }
            else
                MessageBox.Show("Kayıt bulunamadı Tekrar deneyın!");
            baglanti.Close();
        }
    }
}
