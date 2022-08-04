
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.theAmountBefore = new System.Windows.Forms.Label();
            this.theAmountAfter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.הגדרותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDocSettingsListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToTheLIstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemFromTheList = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(24, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "צור קובץ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(883, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1052, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "שם הפרויקט";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1012, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "הוסף";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workType,
            this.unit,
            this.price});
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(24, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(826, 364);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // workType
            // 
            this.workType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workType.FillWeight = 258.1118F;
            this.workType.HeaderText = "תיאור העבודה";
            this.workType.Name = "workType";
            this.workType.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 42.2928F;
            this.unit.HeaderText = "יחידה";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.FillWeight = 33.94402F;
            this.price.HeaderText = "מחיר";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // changeData
            // 
            this.changeData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.changeData.Location = new System.Drawing.Point(883, 301);
            this.changeData.Name = "changeData";
            this.changeData.Size = new System.Drawing.Size(113, 34);
            this.changeData.TabIndex = 5;
            this.changeData.Text = "שנה מידע";
            this.changeData.UseVisualStyleBackColor = true;
            this.changeData.Click += new System.EventHandler(this.changeData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1093, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "יחידה";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.unitTextBox.Location = new System.Drawing.Point(883, 156);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(154, 26);
            this.unitTextBox.TabIndex = 6;
            this.unitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitTextBox.TextChanged += new System.EventHandler(this.unitTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1097, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "מחיר";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.priceTextBox.Location = new System.Drawing.Point(883, 212);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(154, 26);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(1027, 301);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 34);
            this.delete.TabIndex = 12;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(986, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "עלות הפרויקט לפני המע\"מ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(990, 103);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "עלות הפרויקט אחרי מע\"מ:";
            // 
            // theAmountBefore
            // 
            this.theAmountBefore.AutoSize = true;
            this.theAmountBefore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.theAmountBefore.Location = new System.Drawing.Point(883, 73);
            this.theAmountBefore.Name = "theAmountBefore";
            this.theAmountBefore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.theAmountBefore.Size = new System.Drawing.Size(15, 16);
            this.theAmountBefore.TabIndex = 16;
            this.theAmountBefore.Text = "0";
            // 
            // theAmountAfter
            // 
            this.theAmountAfter.AutoSize = true;
            this.theAmountAfter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.theAmountAfter.Location = new System.Drawing.Point(883, 103);
            this.theAmountAfter.Name = "theAmountAfter";
            this.theAmountAfter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.theAmountAfter.Size = new System.Drawing.Size(15, 16);
            this.theAmountAfter.TabIndex = 17;
            this.theAmountAfter.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הגדרותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // הגדרותToolStripMenuItem
            // 
            this.הגדרותToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.הגדרותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDocSettingsListMenu,
            this.addNewItemToTheLIstMenu,
            this.deleteItemFromTheList});
            this.הגדרותToolStripMenuItem.Name = "הגדרותToolStripMenuItem";
            this.הגדרותToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.הגדרותToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.הגדרותToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.הגדרותToolStripMenuItem.Text = "הגדרות";
            // 
            // fileDocSettingsListMenu
            // 
            this.fileDocSettingsListMenu.Name = "fileDocSettingsListMenu";
            this.fileDocSettingsListMenu.Size = new System.Drawing.Size(206, 22);
            this.fileDocSettingsListMenu.Text = "הגדרות מסמך";
            this.fileDocSettingsListMenu.Click += new System.EventHandler(this.fileDocSettingsListMenu_Click);
            // 
            // addNewItemToTheLIstMenu
            // 
            this.addNewItemToTheLIstMenu.Name = "addNewItemToTheLIstMenu";
            this.addNewItemToTheLIstMenu.Size = new System.Drawing.Size(206, 22);
            this.addNewItemToTheLIstMenu.Text = "הוסף פריט חדש לרשימה";
            this.addNewItemToTheLIstMenu.Click += new System.EventHandler(this.addNewItemToTheLIstMenu_Click);
            // 
            // deleteItemFromTheList
            // 
            this.deleteItemFromTheList.Name = "deleteItemFromTheList";
            this.deleteItemFromTheList.Size = new System.Drawing.Size(206, 22);
            this.deleteItemFromTheList.Text = "מחק פריט קיים מהרשימה";
            this.deleteItemFromTheList.Click += new System.EventHandler(this.deleteItemFromTheList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 445);
            this.Controls.Add(this.theAmountAfter);
            this.Controls.Add(this.theAmountBefore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.changeData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1171, 484);
            this.MinimumSize = new System.Drawing.Size(1171, 484);
            this.Name = "Form1";
            this.Text = "כתב כמויות";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label theAmountBefore;
        private System.Windows.Forms.Label theAmountAfter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem הגדרותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToTheLIstMenu;
        private System.Windows.Forms.ToolStripMenuItem fileDocSettingsListMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn workType;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ToolStripMenuItem deleteItemFromTheList;
    }
}

