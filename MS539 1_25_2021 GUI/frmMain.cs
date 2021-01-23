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
1/22/2021  8:00 PM      1/22/2021 9:00 PM
1/23/2021 11:00 AM      1/22/2021 1:00 PM

Program explanation
design
    three windows
    main
    basic input validations
    error provider validations
inputs
    name length > 0
    dob valid date time
    gender  male=0 female = 1
    age - integer value > 0
validations
    validation routine as a method not behind a window but in logical method
architecture
    3 windows
    start of a full stack implementation

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
            Application.Exit();
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
