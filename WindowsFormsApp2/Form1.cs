using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static WindowsFormsApp2.File;
using static WindowsFormsApp2.workTypeWindow;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public List<Tuple<string, string, string>> selectedWorkList = new List<Tuple<string, string, string>>();
        int index = 0;
        int totalProjectAmount = 0;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            MaximizeBox = false;
            updateAmount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("לא נבחר שם פרויקט, הנה הכנס את השם הפרויקט", "הודעת שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBox1.Text.Replace(" ", "_");
                File newFile = new File(name + ".docx");
                newFile.createFile(textBox1.Text, selectedWorkList.Count + 1, selectedWorkList, totalProjectAmount);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            workTypeWindow window = new workTypeWindow();
            window.ShowDialog();
            if (selectedWorkList.Count > 0)
            {
                foreach (Tuple<string, string, string> work in selectedWorkList)
                {
                    flag = true;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (this.dataGridView1.Rows[i].Cells[0].Value == work.Item1.ToString())
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        this.dataGridView1.Rows.Add(work.Item1, work.Item2, work.Item3);
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows[index].Cells[0].Value != null)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[index];
                foreach (Tuple<string, string, string> work in selectedWorkList)
                {
                    if (selectedRow.Cells[0].Value.ToString() == work.Item1)
                    {
                        totalProjectAmount -= Convert.ToInt32(work.Item3);
                        selectedWorkList.Remove(work);
                        break;
                    }
                }
                this.dataGridView1.Rows.Remove(selectedRow);
                updateAmount();
            }
        }

        private void unitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index > -1 && this.dataGridView1.Rows[index].Cells[0].Value != null)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[index];

                //this.priceTextBox.Text = (selectedRow.Cells[2].Value).ToString();
                this.priceTextBox.Text = "";
                this.unitTextBox.Text = (selectedRow.Cells[1].Value).ToString();
            }
        }

        private void changeData_Click(object sender, EventArgs e)
        {
            //Check if the row is not empty
            if (this.dataGridView1.Rows[index].Cells[0].Value != null)
            {
                //Check if the price text box value is valid
                if (this.priceTextBox.Text == "" || Int32.TryParse(this.priceTextBox.Text, out _))
                {
                    //Take the row
                    DataGridViewRow selectedRow = this.dataGridView1.Rows[index];
                    //Check if the price is empty
                    if (this.priceTextBox.Text == "")
                        this.priceTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    //Calc the total project amount 
                    totalProjectAmount -= Convert.ToInt32(selectedRow.Cells[2].Value);
                    //Take the values from the text boxs
                    (selectedRow.Cells[2].Value) = this.priceTextBox.Text;
                    (selectedRow.Cells[1].Value) = this.unitTextBox.Text;
                    
                    foreach (Tuple<string, string, string> work in selectedWorkList)
                    {
                        if (selectedRow.Cells[0].Value.ToString() == work.Item1)
                        {
                            //Check if the string of the price text box is a number

                            //Calc the the new price
                            totalProjectAmount += Convert.ToInt32(this.priceTextBox.Text);
                            //Change the item values and add it to the list
                            selectedWorkList.Add(Tuple.Create(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString()));
                            //Remove the old item from the list
                            selectedWorkList.Remove(work);
                            break;
                        }
                    }
                    updateAmount();
                }
                else
                {
                    MessageBox.Show("!יש להכניס מחיר במספרים בלבד", "הודעת שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void updateAmount()
        {
            theAmountBefore.Text = "₪" + totalProjectAmount.ToString();
            theAmountAfter.Text = "₪" + ((((totalProjectAmount * 17) / 100) + totalProjectAmount)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNewItemToTheLIstMenu_Click(object sender, EventArgs e)
        {
            addNewItemWindow window = new addNewItemWindow();
            window.ShowDialog();
        }

        private void fileDocSettingsListMenu_Click(object sender, EventArgs e)
        {
            docSettingMenu window = new docSettingMenu();
            window.ShowDialog();
        }

        private void deleteItemFromTheList_Click(object sender, EventArgs e)
        {
            deleteItemFromTheListWindow window = new deleteItemFromTheListWindow();
            window.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult ans = MessageBox.Show("במידה ולא שמרת את הקובץ, האם תרצה לשמור אותו \nכן - יוצר את הקובץ ויוצא מהתוכנה\n לא - צא ללא ליצור את הקובץ", "הודעת יציאה", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.No)
            {
                Application.Exit();
            }
            else if (ans == DialogResult.Yes)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("לא נבחר שם פרויקט לכן הוא יקרא כתב כמויות", "הודעת שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "כתב כמויות";
                }
                    string name = textBox1.Text.Replace(" ", "_");
                    File newFile = new File(name + ".docx");
                    newFile.createFile(textBox1.Text, selectedWorkList.Count + 1, selectedWorkList, totalProjectAmount);
                Application.Exit();
            }
        }
    }
}
