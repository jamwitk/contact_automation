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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARGE-DEV\\SQL2014;Initial Catalog=Stajyer_Egitim;Persist Security Info=True;User ID=Lgn_Egitim;Password=Egitim123!");
        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            if(txtkullanici.Text=="admin" & txtsifresi.Text=="123")
            {
                Rehber_Ekrani rhb = new Rehber_Ekrani();
                rhb.Show();
                this.Hide();
            }

            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from K_Adi  where Kullanici_Adi = '"+txtkullanici.Text.ToString()+"' and Şifre = '"+txtsifresi.Text.ToString()+"'",baglanti);
            //SqlDataReader dr = komut.ExecuteReader();
            //if(dr.Read())
            //{
            //    Rehber_Ekrani rhb = new Rehber_Ekrani();
            //    rhb.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanici adi veya Şifre yanlış ! ");
            //    txtkullanici.Text = "";
            //    txtsifresi.Text = "";
            //}
        }

        private void lnkSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifrenizi bende bilmiyorum bir daha unutmayın!");
            this.Hide();
            Rehber_Ekrani rhbreknran = new Rehber_Ekrani();
            rhbreknran.Show();
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit_Ekrani kytekran = new Kayit_Ekrani();
            kytekran.Show();
            this.Hide();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtK_Adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtsifresi.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtsifresi.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Gray;
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.Gray;
          
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
         
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            label2.BackColor = Color.Gray;
            label1.BackColor = Color.Transparent;
            grb1.Visible = false;
            grb2.Visible = true;
            grb2.Location = new Point(7,88);
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            grb2.Visible = false;
            grb1.Visible = true;
            grb2.Location = new Point(343,87);

        }

        private void grb1_Enter(object sender, EventArgs e)
        {

        }

        private void grb2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        int mouseX = 0, mouse = 0;
        bool mouseDonwn;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDonwn = true;
        }

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
                this.SetDesktopLocation(mouseX,mouse);
            }
              
        }
    }
}
