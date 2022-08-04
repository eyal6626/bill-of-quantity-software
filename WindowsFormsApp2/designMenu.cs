using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;
namespace WindowsFormsApp2
{
    public partial class designMenu : Form
    {
        public designMenu()
        {
            InitializeComponent();
            if (Settings.Default["designOption"].Equals(1))
                this.radioButton2.Checked = true;
            if (Settings.Default["designOption"].Equals(2))
                this.radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked.Equals(true))
                Settings.Default["designOption"] = 1;
            Settings.Default.Save();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked.Equals(true))
                Settings.Default["designOption"] = 2;
            Settings.Default.Save();
        }
    }
}
