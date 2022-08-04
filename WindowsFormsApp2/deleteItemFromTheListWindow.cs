using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class deleteItemFromTheListWindow : Form
    {
        List<string> works = new List<string>();
        public deleteItemFromTheListWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            //Get the works form the database to a vector
            loadWorksFromDatabase();
            //Load the works to the grid
            loadWorksToGrid(works);
        }

        private void loadWorksFromDatabase()
        {
            works.Clear();
            //connect to the database
            var connection = new SQLiteConnection("DataSource = " + AppDomain.CurrentDomain.BaseDirectory + "\\" + "worksDatabase.db" + "; Version = 3;");
            connection.Open();
            var command = new SQLiteCommand(string.Format("SELECT WORKTYPE FROM works;"), connection);
            SQLiteDataReader ans = command.ExecuteReader();
            while (ans.Read())
            {
                works.Add(ans["WORKTYPE"].ToString());
            }
            connection.Close();
        }
        public void loadWorksToGrid(List<string> works)
        {
            foreach (string workType in works)
            {
                this.notSelectedWork.Rows.Add(workType);
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.notSelectedWork.Rows.Clear();
            this.selectedWork.Rows.Clear();
            loadWorksToGrid(works);
        }

        private void notSelectedWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1 && this.notSelectedWork.Rows[index].Cells[0].Value != null)
            {
                DataGridViewRow selectedRow = this.notSelectedWork.Rows[index];
                this.selectedWork.Rows.Add(selectedRow.Cells[0].Value.ToString());
                this.notSelectedWork.Rows.Remove(selectedRow);
            }
        }

        private void selectedWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1 && this.selectedWork.Rows[index].Cells[0].Value != null)
            {
                DataGridViewRow selectedRow = this.selectedWork.Rows[index];
                this.notSelectedWork.Rows.Add(selectedRow.Cells[0].Value.ToString());
                this.selectedWork.Rows.Remove(selectedRow);
            }
        }

        private void deleteWorks(List<string> works)
        {
            //connect to the database
            var connection = new SQLiteConnection("DataSource = " + AppDomain.CurrentDomain.BaseDirectory + "\\" + "worksDatabase.db" + "; Version = 3;");
            connection.Open();
            foreach (string work in works)
            {
                string req = "DELETE FROM works WHERE WORKTYPE = " + "\"" + work + "\"";
                var command = new SQLiteCommand(req, connection);
                SQLiteDataReader ans = command.ExecuteReader();
            }
            connection.Close();
            MessageBox.Show("!העבודה נמחקו מהרשימה", "הודעת הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את העבודות האלו","מחיקת העבודות",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ans == DialogResult.Yes)
            {
                List<string> selectedWorks = new List<string>();
                //Delete the works
                foreach (DataGridViewRow row in this.selectedWork.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        selectedWorks.Add(row.Cells[0].Value.ToString());
                    }
                }

                deleteWorks(selectedWorks);
                loadWorksFromDatabase();
                this.notSelectedWork.Rows.Clear();
                this.selectedWork.Rows.Clear();
                loadWorksToGrid(works);

            }
            
        }
    }
}
