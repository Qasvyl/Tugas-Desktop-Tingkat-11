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
    public partial class FNurrafiHal3 : Form
    {
        public FNurrafiHal3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kata = txtkata.Text;
            int awal = Convert.ToInt32(txtAwal.Text);
            int akhir = Convert.ToInt32(txtAkhir.Text);
            string s = kata.Substring(awal, akhir);
            txthasil.Text = s;
        }
    }
}
