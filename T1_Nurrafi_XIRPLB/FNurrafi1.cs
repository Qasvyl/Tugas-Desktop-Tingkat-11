using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_Nurrafi_XIRPLB
{
    public partial class FNurrafi1 : Form
    {
        public FNurrafi1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuserNurrafi.Text == "Nurrafi" && txtpassNurrafi.Text == "25")
            {
                FNurrafi2 Nurrafi = new FNurrafi2();
                Nurrafi.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void FNurrafi1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah Mau Keluar?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (txtpassNurrafi.UseSystemPasswordChar == false)
            {
                txtpassNurrafi.UseSystemPasswordChar = true;
                btnHideShow.Text = "Hide";
            }
            else
            {
                txtpassNurrafi.UseSystemPasswordChar = false;
                btnHideShow.Text = "Show";
            }
        }

        private void txtpassNurrafi_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNurrafi1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
