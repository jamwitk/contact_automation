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
    public partial class Kayit_Ekrani : Form
    {
        public Kayit_Ekrani()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=ARGE-DEV\\SQL2014;Initial Catalog=Stajyer_Egitim;Persist Security Info=True;User ID=Lgn_Egitim;Password=Egitim123!");
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtSifre1.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtSifre1.PasswordChar = '*';
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            txtSifre2.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtSifre2.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtK_Adi_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
