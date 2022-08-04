using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    public partial class addNewItemWindow : Form
    {
        public addNewItemWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                if (checkIfTheWorklExist(this.textBox1.Text))
                {
                    addWorksToDatabase(this.textBox1.Text);
                }
                else
                {
                    MessageBox.Show("עבודה זאת כבר קיימת ברשימה", "הודעת שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("יש לכתוב תוכן ורק לאחר מכן ללחוץ אישור", "הודעת שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addWorksToDatabase(string work)
        {
            //connect to the database
            var connection = new SQLiteConnection("DataSource = " + AppDomain.CurrentDomain.BaseDirectory + "\\" + "worksDatabase.db" + "; Version = 3;");
            connection.Open();
            string req = "INSERT INTO works(ID, WORKTYPE) VALUES(NULL," +  "\"" + work + "\")";
            var command = new SQLiteCommand(req, connection);
            SQLiteDataReader ans = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("!העבודה נוספה לרשימה", "הודעת הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool checkIfTheWorklExist(string workName)
        {
            //connect to the database
            var connection = new SQLiteConnection("DataSource = " + AppDomain.CurrentDomain.BaseDirectory + "\\" + "worksDatabase.db" + "; Version = 3;");
            connection.Open();
            string req = "SELECT count(*) FROM works WHERE WORKTYPE = " + "\"" + workName + "\"";
            var command = new SQLiteCommand(req, connection);
            int ans = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return ans == 0;
        }
    }
}
