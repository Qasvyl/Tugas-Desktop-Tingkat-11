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
    public partial class FNurrafiHal7 : Form
    {
        public FNurrafiHal7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kata = txt1.Text;
            int jumlah = kata.Length;
            txt2.Text = "jumlah karakternya adalah" + " " + jumlah;
        }
    }
}
