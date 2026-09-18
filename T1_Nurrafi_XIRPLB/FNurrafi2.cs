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
    public partial class FNurrafi2 : Form
    {
        public FNurrafi2()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnltugas1.Visible == false)
            {
                pnltugas1.Visible = true;
            }
            else
            {
                pnltugas1.Visible = false;
            }
        }

        private void ikon2_Click(object sender, EventArgs e)
        {
            if (pnlsideNurrafi1.Visible == false)
            {
                pnlsideNurrafi1.Visible = true;
                ikon2.Visible = false;
            }
            else
            {
                pnlsideNurrafi1.Visible = false;
            }
        }

        private void ikon1_Click(object sender, EventArgs e)
        {
            if (pnlsideNurrafi1.Visible == true)
            {
                pnlsideNurrafi1.Visible = false;
                ikon2.Visible = true;
            }
            else
            {
                pnlsideNurrafi1.Visible = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah Mau Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                FNurrafi1 Nurrafi = new FNurrafi1();
                Nurrafi.Visible = true;
                this.Hide();
            }
        }

        private void pnlntnNurrafi1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FNurrafi2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            FNurrafiHal1 hal1 = new FNurrafiHal1() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal1, kontenNurrafi);
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            FNurrafiHal2 hal2 = new FNurrafiHal2() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal2, kontenNurrafi);
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            FNurrafiHal3 hal3 = new FNurrafiHal3() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal3, kontenNurrafi);
        }

        private void btnTrimStart_Click(object sender, EventArgs e)
        {
            FNurrafiHal4 hal4 = new FNurrafiHal4() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal4, kontenNurrafi);
        }

        private void btnTimeEnd_Click(object sender, EventArgs e)
        {
            FNurrafiHal5 hal5 = new FNurrafiHal5() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal5, kontenNurrafi);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            FNurrafiHal6 hal6 = new FNurrafiHal6() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal6, kontenNurrafi);
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            FNurrafiHal7 hal7 = new FNurrafiHal7() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal7, kontenNurrafi);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            FNurrafiHal8 hal8 = new FNurrafiHal8() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal8, kontenNurrafi);
        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            FNurrafiHal9 hal9 = new FNurrafiHal9() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal9, kontenNurrafi);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtsearchbar.Text == "To Lower")
            {
                FNurrafiHal1 hal1 = new FNurrafiHal1() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal1, kontenNurrafi);
            }
          

            else if (txtsearchbar.Text == "To Upper")
            {
                FNurrafiHal2 hal2 = new FNurrafiHal2() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal2, kontenNurrafi);
            }
           

            else if (txtsearchbar.Text == "SubString")
            {
                FNurrafiHal3 hal3 = new FNurrafiHal3() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal3, kontenNurrafi);
            }
            

            else if (txtsearchbar.Text == "Trim Start")
            {
                FNurrafiHal4 hal4 = new FNurrafiHal4() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal4, kontenNurrafi);
            }
            

            else  if (txtsearchbar.Text == "Trim End")
            {
                FNurrafiHal5 hal5 = new FNurrafiHal5() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal5, kontenNurrafi);
            }
           

            else if (txtsearchbar.Text == "Trim")
            {
                FNurrafiHal6 hal6 = new FNurrafiHal6() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal6, kontenNurrafi);
            }
            

            else if (txtsearchbar.Text == "Length")
            {
                FNurrafiHal7 hal7 = new FNurrafiHal7() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal7, kontenNurrafi);
            }
            

            else if (txtsearchbar.Text == "Replace")
            {
                FNurrafiHal8 hal8 = new FNurrafiHal8() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal8, kontenNurrafi);
            }
            

            else if (txtsearchbar.Text == "Compare To")
            {
                FNurrafiHal9 hal9 = new FNurrafiHal9() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal9, kontenNurrafi);
            }

            else if (txtsearchbar.Text == "About Me")
            {
                FNurrafiHal10 hal10 = new FNurrafiHal10() { TopLevel = false, TopMost = true };
                KFNurrafi.untukformNurrafi(hal10, kontenNurrafi);
            }

            else
            {
                MessageBox.Show("Apa yang anda cari tidak ditemukan");
            }

        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAboutme_Click(object sender, EventArgs e)
        {
            FNurrafiHal10 hal10 = new FNurrafiHal10() { TopLevel = false, TopMost = true };
            KFNurrafi.untukformNurrafi(hal10, kontenNurrafi);
        }
    }
}
