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
    public partial class Rehber_Ekrani : Form
    {
        public Rehber_Ekrani()
        {
            InitializeComponent();
        }

        private void Rehber_Ekrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyer_EgitimDataSet2.Kisiler' table. You can move, or remove it, as needed.
            //this.kisilerTableAdapter2.Fill(this.stajyer_EgitimDataSet2.Kisiler);
            // TODO: This line of code loads data into the 'stajyer_EgitimDataSet1.Kisiler' table. You can move, or remove it, as needed.
            //this.kisilerTableAdapter1.Fill(this.stajyer_EgitimDataSet1.Kisiler);
            // TODO: This line of code loads data into the 'stajyer_EgitimDataSet.Kisiler' table. You can move, or remove it, as needed.


        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARGE-DEV\\SQL2014;Initial Catalog=Stajyer_Egitim;Persist Security Info=True;User ID=Lgn_Egitim;Password=Egitim123!");

        int isdelected = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (RbErkek.Checked == true)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Kisiler values ('" + txtK_A_S.Text + "' , '" + txtT_Numara.Text.ToString() + "','0','" + rtxtNote.Text + "' ,'E', '" + txtEposta.Text.ToString() + "' , '" + txtIs_No.Text.ToString() + "' ) ", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kayıt Olundu!");
              
                txtK_A_S.Text = "";
                txtT_Numara.Text = "";
                txtEposta.Text = "";
                txtK_No.Text = "";
                txtIs_No.Text = "";
                rtxtNote.Text = "";
                txtEposta.Text = "";
                if (RbErkek.Checked == true)
                    RbErkek.Checked = false;
                else
                    RbKadin.Checked = false;
                    
                baglanti.Close();

            }
            else if (RbKadin.Checked == true)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Kisiler values ('" + txtK_A_S.Text + "' , '" + txtT_Numara.Text.ToString() + "','0','" + rtxtNote.Text + "' ,'K', '" + txtEposta.Text.ToString() + "' , '" + txtIs_No.Text.ToString() + "' ) ", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kayıt Olundu!");
              
                txtK_A_S.Text = "";
                txtT_Numara.Text = "";
                baglanti.Close();
            }
            else
                MessageBox.Show("Hata cinsiyeti seçmeden kayıt işleme devam edemıyor");

        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Rehber_Ekrani rhb = new Rehber_Ekrani();
            rhb.Size = new Size(463,575); 
            grbAra.Location = new Point(481,46);
            dataGridView1.Visible = false;
            tabControlKayit.Visible = false;
            dataGridView1.Location = new Point(481, 258);
            dataGridView1.Size = new Size(410, 205);
            btnKeG.Visible = true;
            grbAra.Visible = false;
            grbListe.Visible = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            grbAra.Visible = true;
            grbListe.Visible = true;
            tabControlKayit.Visible = false;
            dataGridView1.Visible = true;
            btnKeG.Visible = false;
            if (chERKEK.Checked == true)
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE Cinsiyet like '%E%'", baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
            }
            else if (chKadin.Checked == true)
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE Cinsiyet like '%K%'", baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
            }
            else if (chIsDeleted.Checked == true)
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE IsDelected = 1", baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();

            }
            else if (chERKEK.Checked == false && chKadin.Checked == false && chIsDeleted.Checked == false)
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE IsDelected = 0", baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
            }

        }

        private void RbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void listele()
            {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE IsDelected = 0", baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable tablo1 = new DataTable();
            tablo1.Load(dr1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
        }
        private void btnARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
              if(txtAd_Ara.Text != "" && txtID_ARA.Text=="" && txtNO_Ara.Text=="")
            {
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE Kullanici_Adi like '%" + txtAd_Ara.Text + "%' ", baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
            }
              else if(txtAd_Ara.Text == "" && txtID_ARA.Text != "" && txtNO_Ara.Text == "")
            {
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE ID = " + int.Parse(txtID_ARA.Text),baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
            }
              else if(txtAd_Ara.Text == "" && txtID_ARA.Text == "" && txtNO_Ara.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE Telefon_Numarasi = " + txtNO_Ara.Text.ToString(), baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable tablo1 = new DataTable();
                tablo1.Load(dr1);
                dataGridView1.DataSource = tablo1;
            }
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtm_ara.Text = "";
            txtK_adi.Text = "";
            txtK_No.Text = "";
            txtK_Not.Text = "";
            txtE_posta.Text = "";
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("UPDATE Kisiler set IsDelected = 1 WHERE  ID = @kullanicid", baglanti);
                kmt.Parameters.AddWithValue("@kullanicid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
             else
            {

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btnGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Kayıt Ekranı";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Kisiler WHERE ID = " + int.Parse(txtm_ara.Text)+"", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd1.ExecuteNonQuery();
            SqlDataReader dr = cmd1.ExecuteReader();
            cmd1.Parameters.AddWithValue("ID",lblM_ID.Text);
            if (dr.Read())
            {
                lblM_ID.Text = dr["ID"].ToString();
                txtK_adi.Text = dr["Kullanici_Adi"].ToString();
                txtK_No.Text = dr["Telefon_Numarasi"].ToString();
                txtE_posta.Text = dr["Eposta"].ToString();
                txtK_Not.Text = dr["K_Not"].ToString();
            }
            else
                MessageBox.Show("Kayıt bulunamadı Tekrar deneyın!");
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kisiler SET Kullanici_Adi = '"+txtK_adi.Text+"',Telefon_Numarasi = '"+txtK_No.Text+"',K_Not = '"+txtK_Not.Text+"',Eposta ='"+txtE_posta.Text+"'",baglanti);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir!");
            baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEposta.Text = "";
            txtK_A_S.Text = "";
            txtIs_No.Text = "";
            txtT_Numara.Text = "";
            rtxtNote.Text = "";
            RbErkek.Checked = false;
            RbKadin.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtT_Numara_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtT_Numara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIs_No_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNO_Ara_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNO_Ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIs_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnKeG_Click(object sender, EventArgs e)
        {
            
            tabControlKayit.Visible = true;
            groupBox1.Visible = true;
            Rehber_Ekrani rhb = new Rehber_Ekrani();
            rhb.Size = new Size(463,89);
        }

        private void btnARA_MouseMove(object sender, MouseEventArgs e)
        {

        }
        int mouseX = 0, mouse = 0;
        bool mouseDonwn;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDonwn = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDonwn)
            {
                mouseX = MousePosition.X - 200;
                mouse = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouse);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDonwn = true;
        }
    }
}
