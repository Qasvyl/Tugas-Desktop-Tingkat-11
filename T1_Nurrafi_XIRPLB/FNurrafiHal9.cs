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
    public partial class FNurrafiHal9 : Form
    {
        public FNurrafiHal9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kata1 = txt1.Text;
            string kata2 = txt2.Text;
            int hasil = kata1.CompareTo(kata2);
            txthasil.Text = " " + hasil;
        }
    }
}
