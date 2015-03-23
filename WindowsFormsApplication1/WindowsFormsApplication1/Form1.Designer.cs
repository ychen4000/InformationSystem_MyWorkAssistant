namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchJobByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchJobByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchJobByBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warrantyAndOOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerifiedFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewJob = new System.Windows.Forms.Button();
            this.SearchJob = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJobToolStripMenuItem,
            this.leaveSystemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addJobToolStripMenuItem
            // 
            this.addJobToolStripMenuItem.Name = "addJobToolStripMenuItem";
            this.addJobToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addJobToolStripMenuItem.Text = "Add Job";
            // 
            // leaveSystemToolStripMenuItem
            // 
            this.leaveSystemToolStripMenuItem.Name = "leaveSystemToolStripMenuItem";
            this.leaveSystemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.leaveSystemToolStripMenuItem.Text = "Leave system";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchJobByIDToolStripMenuItem,
            this.searchJobByDateToolStripMenuItem,
            this.searchJobByBrandToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchJobByIDToolStripMenuItem
            // 
            this.searchJobByIDToolStripMenuItem.Name = "searchJobByIDToolStripMenuItem";
            this.searchJobByIDToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.searchJobByIDToolStripMenuItem.Text = "Search job by ID";
            // 
            // searchJobByDateToolStripMenuItem
            // 
            this.searchJobByDateToolStripMenuItem.Name = "searchJobByDateToolStripMenuItem";
            this.searchJobByDateToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.searchJobByDateToolStripMenuItem.Text = "Search job by date";
            // 
            // searchJobByBrandToolStripMenuItem
            // 
            this.searchJobByBrandToolStripMenuItem.Name = "searchJobByBrandToolStripMenuItem";
            this.searchJobByBrandToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.searchJobByBrandToolStripMenuItem.Text = "Search job by Brand";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.warrantyAndOOWToolStripMenuItem,
            this.partsUsageToolStripMenuItem,
            this.reserviceToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // warrantyAndOOWToolStripMenuItem
            // 
            this.warrantyAndOOWToolStripMenuItem.Name = "warrantyAndOOWToolStripMenuItem";
            this.warrantyAndOOWToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.warrantyAndOOWToolStripMenuItem.Text = "Warranty and OOW";
            // 
            // partsUsageToolStripMenuItem
            // 
            this.partsUsageToolStripMenuItem.Name = "partsUsageToolStripMenuItem";
            this.partsUsageToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.partsUsageToolStripMenuItem.Text = "parts usage";
            // 
            // reserviceToolStripMenuItem
            // 
            this.reserviceToolStripMenuItem.Name = "reserviceToolStripMenuItem";
            this.reserviceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.reserviceToolStripMenuItem.Text = "Re-service";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.BookInDate,
            this.Brand,
            this.Model,
            this.VerifiedFault,
            this.EstimateDate,
            this.Warranty,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 357);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // JobID
            // 
            this.JobID.HeaderText = "Job ID";
            this.JobID.Name = "JobID";
            // 
            // BookInDate
            // 
            this.BookInDate.HeaderText = "Book in date";
            this.BookInDate.Name = "BookInDate";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // VerifiedFault
            // 
            this.VerifiedFault.HeaderText = "Verified fault";
            this.VerifiedFault.Name = "VerifiedFault";
            // 
            // EstimateDate
            // 
            this.EstimateDate.HeaderText = "Estimate complete date";
            this.EstimateDate.Name = "EstimateDate";
            // 
            // Warranty
            // 
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // AddNewJob
            // 
            this.AddNewJob.Location = new System.Drawing.Point(42, 400);
            this.AddNewJob.Name = "AddNewJob";
            this.AddNewJob.Size = new System.Drawing.Size(136, 50);
            this.AddNewJob.TabIndex = 2;
            this.AddNewJob.Text = "Add New Job";
            this.AddNewJob.UseVisualStyleBackColor = true;
            // 
            // SearchJob
            // 
            this.SearchJob.Location = new System.Drawing.Point(223, 400);
            this.SearchJob.Name = "SearchJob";
            this.SearchJob.Size = new System.Drawing.Size(123, 50);
            this.SearchJob.TabIndex = 3;
            this.SearchJob.Text = "Search Job";
            this.SearchJob.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(394, 400);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(119, 50);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort Job";
            this.Sort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 462);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.SearchJob);
            this.Controls.Add(this.AddNewJob);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchJobByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchJobByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchJobByBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookInDate;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warrantyAndOOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partsUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserviceToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerifiedFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button AddNewJob;
        private System.Windows.Forms.Button SearchJob;
        private System.Windows.Forms.Button Sort;
    }
}

