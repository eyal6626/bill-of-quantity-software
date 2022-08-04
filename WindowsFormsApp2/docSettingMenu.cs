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
    public partial class docSettingMenu : Form
    {
        public docSettingMenu()
        {
            InitializeComponent();
            MaximizeBox = false;

            //Load the settings
            this.textBox1.Text = Settings.Default["companyName"].ToString();

            //Add total amount to the file - setting
            if (Settings.Default["showTotalAmount"].Equals(true))
                this.checkBox1.CheckState = CheckState.Checked;
            else
                this.checkBox1.CheckState = CheckState.Unchecked;
            
            //Add the bottom paragraph to the file setting
            if (Settings.Default["ShowLastPar"].Equals(true))
                this.checkBox2.CheckState = CheckState.Checked;
            else
                this.checkBox2.CheckState = CheckState.Unchecked;

            //Add the total amount after tax setting
            if (Settings.Default["showTotalAmountAfterTax"].Equals(true))
                this.checkBox3.CheckState = CheckState.Checked;
            else
                this.checkBox3.CheckState = CheckState.Unchecked;

            //Add the company name in the file setting
            if (Settings.Default["showCompanyName"].Equals(true))
            {
                this.checkBox4.CheckState = CheckState.Checked;
                this.textBox1.Enabled = true;
            }

            else
            {
                this.checkBox4.CheckState = CheckState.Unchecked;
                this.textBox1.Enabled = false;
            }

            //Open the file after creating it setting
            if (Settings.Default["openTheFileAtTheEnd"].Equals(true))
                this.checkBox5.CheckState = CheckState.Checked;

            else
                this.checkBox5.CheckState = CheckState.Unchecked;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["companyName"] = this.textBox1.Text;
            Settings.Default.Save();
            MessageBox.Show("!הגדרות המסמך נשמרו בהצלחה", "הודעת הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.CheckState == CheckState.Checked)
                Settings.Default["showTotalAmount"] = true;
            else
                Settings.Default["showTotalAmount"] = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { 
            if (this.checkBox2.CheckState == CheckState.Checked)
                Settings.Default ["ShowLastPar"] = true;
            else
                Settings.Default ["ShowLastPar"] = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.CheckState == CheckState.Checked)
                Settings.Default["showTotalAmountAfterTax"] = true;
            else
                Settings.Default["showTotalAmountAfterTax"] = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.CheckState == CheckState.Checked)
            {
                Settings.Default["showCompanyName"] = true;
                this.textBox1.Enabled = true;
            }
            else
            {
                Settings.Default["showCompanyName"] = false;
                this.textBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            designMenu window = new designMenu();
            window.ShowDialog();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.CheckState == CheckState.Checked)
                Settings.Default["openTheFileAtTheEnd"] = true;
            else
                Settings.Default["openTheFileAtTheEnd"] = false;
        }
    }
}
