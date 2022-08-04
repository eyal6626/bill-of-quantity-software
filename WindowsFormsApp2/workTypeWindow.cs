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
    public partial class workTypeWindow : Form
    {
        //The list of the works
        List<string> works = new List<string>();
        public static workTypeWindow instance;
        //Selected works
        public workTypeWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            instance = this;
            //Get the works form the database to a vector
            loadWorksFromDatabase();
            //Load the works to the grid
            loadWorksToGrid(works);

        }

        private void loadWorksFromDatabase()
        {
            //connect to the database
            var connection = new SQLiteConnection("DataSource = " + AppDomain.CurrentDomain.BaseDirectory + "\\" + "worksDatabase.db" + "; Version = 3;" );
            connection.Open();
            var command = new SQLiteCommand(string.Format("SELECT WORKTYPE FROM works;"), connection);
            SQLiteDataReader ans = command.ExecuteReader();
            while (ans.Read())
            {
                works.Add(ans["WORKTYPE"].ToString());
            }
            connection.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.notSelectedWork.Rows.Clear();
            this.selectedWork.Rows.Clear();
            loadWorksToGrid(works);
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

        public void loadWorksToGrid(List<string> works)
        {
            foreach(string workType in works)
            {
                this.notSelectedWork.Rows.Add(workType);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { bool flag = true;
            if (this.selectedWork.Rows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in this.selectedWork.Rows)
                {
                    flag = true;
                    if (selectedRow.Cells[0].Value != null)
                    {
                        foreach (Tuple<string, string, string> work in Form1.instance.selectedWorkList) {
                            if (work.Item1.CompareTo(selectedRow.Cells[0].Value.ToString()) == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            addToList(selectedRow);
                        }

                    }
                }
            }
            this.Close();
        }

        private static void addToList(DataGridViewRow selectedRow)
        {
            Form1.instance.selectedWorkList.Add(Tuple.Create(selectedRow.Cells[0].Value.ToString(), "---", "0"));
        }

        private void workTypeWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
