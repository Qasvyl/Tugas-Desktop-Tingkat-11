using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_Nurrafi_XIRPLB
{
    class KFNurrafi
    {
        public static void untukformNurrafi(Form formapa, Panel panelapa)
        {
            panelapa.Controls.Clear();
            panelapa.Controls.Add(formapa);
            formapa.FormBorderStyle = FormBorderStyle.None;
            formapa.Dock = DockStyle.Fill;
            formapa.Show();
        }
    }
}
