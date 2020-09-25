using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rahberi
{
    public partial class MENY : Form
    {
        public MENY()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
                    }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            btnk_g.BackColor = Color.Gray;
            btnk_g.Size = new Size(128,121);
        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Transparent;
            btnList.Size = new Size(110, 89);
        }

        private void btnList_MouseMove(object sender, MouseEventArgs e)
        {
            btnList.BackColor = Color.Gray;
            btnList.Size = new Size(128, 121);
        }

        private void btnk_g_Click(object sender, EventArgs e)
        {

        }

        private void btnk_g_MouseLeave(object sender, EventArgs e)
        {
            btnk_g.BackColor = Color.Transparent;
            btnk_g.Size = new Size(110, 89);

        }
    }
}
