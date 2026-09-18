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
    public partial class FNurrafiHal4 : Form
    {
        public FNurrafiHal4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kata = txt1.Text;
            string hasil = kata.TrimStart();
            txt2.Text = hasil;
        }
    }
}
