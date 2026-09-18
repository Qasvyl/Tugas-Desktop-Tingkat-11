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
    public partial class FNurrafiHal2 : Form
    {
        public FNurrafiHal2()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = txt1.Text.ToUpper();
            txt2.Text = s;
        }
    }
}
