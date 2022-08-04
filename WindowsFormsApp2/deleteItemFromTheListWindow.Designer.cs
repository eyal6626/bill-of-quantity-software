
namespace WindowsFormsApp2
{
    partial class deleteItemFromTheListWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteItemFromTheListWindow));
            this.restartButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.notSelectedWork = new System.Windows.Forms.DataGridView();
            this.workType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedWork = new System.Windows.Forms.DataGridView();
            this.selectedWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.notSelectedWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWork)).BeginInit();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(952, 270);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(118, 30);
            this.restartButton.TabIndex = 9;
            this.restartButton.Text = "איפוס";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(12, 270);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 30);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "מחיקה";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // notSelectedWork
            // 
            this.notSelectedWork.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.notSelectedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notSelectedWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workType});
            this.notSelectedWork.Location = new System.Drawing.Point(586, 12);
            this.notSelectedWork.Name = "notSelectedWork";
            this.notSelectedWork.ReadOnly = true;
            this.notSelectedWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notSelectedWork.Size = new System.Drawing.Size(484, 252);
            this.notSelectedWork.TabIndex = 7;
            this.notSelectedWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notSelectedWork_CellClick);
            // 
            // workType
            // 
            this.workType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workType.HeaderText = "סוגי עבודות";
            this.workType.Name = "workType";
            this.workType.ReadOnly = true;
            // 
            // selectedWork
            // 
            this.selectedWork.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.selectedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedWorkType});
            this.selectedWork.Location = new System.Drawing.Point(12, 12);
            this.selectedWork.Name = "selectedWork";
            this.selectedWork.ReadOnly = true;
            this.selectedWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.selectedWork.Size = new System.Drawing.Size(484, 252);
            this.selectedWork.TabIndex = 6;
            this.selectedWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedWork_CellClick);
            // 
            // selectedWorkType
            // 
            this.selectedWorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selectedWorkType.HeaderText = "עבודות שנבחרו למחיקה";
            this.selectedWorkType.Name = "selectedWorkType";
            this.selectedWorkType.ReadOnly = true;
            // 
            // deleteItemFromTheListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 308);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.notSelectedWork);
            this.Controls.Add(this.selectedWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1098, 347);
            this.MinimumSize = new System.Drawing.Size(1098, 347);
            this.Name = "deleteItemFromTheListWindow";
            this.Text = "מחק פריט מרשימת העבודות";
            ((System.ComponentModel.ISupportInitialize)(this.notSelectedWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView notSelectedWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn workType;
        private System.Windows.Forms.DataGridView selectedWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedWorkType;
    }
}