using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
NAME				DATE		PROJECT
Roderick DeValcourt 1/22/2021	MS539 1_25_2021 GUI

Start                   Stop
1/22/2021 8:00 PM       1/22/2021 9:00 PM

 */

namespace MS539_1_25_2021_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasicGUI gUI = new frmBasicGUI();
            gUI.ShowDialog(this);
        }

        private void errorProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmErrorProvider gUI = new frmErrorProvider();
            gUI.ShowDialog(this);

        }
    }
}
