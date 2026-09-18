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
    public partial class FNurrafiHal8 : Form
    {
        public FNurrafiHal8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kata = txtkata.Text;
            string hasil = kata.Replace(txtLama.Text, txtBaru.Text);
            txthasil.Text = hasil;
        }
    }
}
