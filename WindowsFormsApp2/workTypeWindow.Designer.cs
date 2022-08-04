
namespace WindowsFormsApp2
{
    partial class workTypeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workTypeWindow));
            this.selectedWork = new System.Windows.Forms.DataGridView();
            this.notSelectedWork = new System.Windows.Forms.DataGridView();
            this.workType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notSelectedWork)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedWork
            // 
            this.selectedWork.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.selectedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedWorkType});
            this.selectedWork.Location = new System.Drawing.Point(12, 70);
            this.selectedWork.Name = "selectedWork";
            this.selectedWork.ReadOnly = true;
            this.selectedWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.selectedWork.Size = new System.Drawing.Size(484, 252);
            this.selectedWork.TabIndex = 0;
            this.selectedWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedWork_CellClick);
            // 
            // notSelectedWork
            // 
            this.notSelectedWork.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.notSelectedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notSelectedWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workType});
            this.notSelectedWork.Location = new System.Drawing.Point(586, 70);
            this.notSelectedWork.Name = "notSelectedWork";
            this.notSelectedWork.ReadOnly = true;
            this.notSelectedWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notSelectedWork.Size = new System.Drawing.Size(484, 252);
            this.notSelectedWork.TabIndex = 1;
            this.notSelectedWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notSelectedWork_CellClick);
            // 
            // workType
            // 
            this.workType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workType.HeaderText = "סוגי עבודות";
            this.workType.Name = "workType";
            this.workType.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(952, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "איפוס";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedWorkType
            // 
            this.selectedWorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selectedWorkType.HeaderText = "עבודות שנבחרו";
            this.selectedWorkType.Name = "selectedWorkType";
            this.selectedWorkType.ReadOnly = true;
            // 
            // workTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notSelectedWork);
            this.Controls.Add(this.selectedWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1098, 409);
            this.MinimumSize = new System.Drawing.Size(1098, 409);
            this.Name = "workTypeWindow";
            this.Text = "הוסף עבודות";
            this.Load += new System.EventHandler(this.workTypeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notSelectedWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView selectedWork;
        private System.Windows.Forms.DataGridView notSelectedWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn workType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedWorkType;
    }
}