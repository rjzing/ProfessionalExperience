namespace EnterADAMMods
{
    partial class frmView
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
            this.btnViewArchive = new System.Windows.Forms.Button();
            this.lblVersionV = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.lblDepart = new System.Windows.Forms.Label();
            this.txtDepartUpdate = new System.Windows.Forms.TextBox();
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.pnlArchiveView = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelArchive = new System.Windows.Forms.Button();
            this.btnUnarchive = new System.Windows.Forms.Button();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.btnArchiveEntry = new System.Windows.Forms.Button();
            this.btnUpdateRow = new System.Windows.Forms.Button();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pnlArchiveView.SuspendLayout();
            this.pnlDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.ForeColor = System.Drawing.Color.Black;
            this.btnViewArchive.Location = new System.Drawing.Point(366, 376);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(75, 47);
            this.btnViewArchive.TabIndex = 10016;
            this.btnViewArchive.Text = "View Archived Entries";
            this.btnViewArchive.UseVisualStyleBackColor = true;
            this.btnViewArchive.Click += new System.EventHandler(this.btnViewArchive_Click);
            // 
            // lblVersionV
            // 
            this.lblVersionV.AutoSize = true;
            this.lblVersionV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersionV.Location = new System.Drawing.Point(342, 449);
            this.lblVersionV.Name = "lblVersionV";
            this.lblVersionV.Size = new System.Drawing.Size(0, 9);
            this.lblVersionV.TabIndex = 10015;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.txtIPAddress);
            this.pnlUpdate.Controls.Add(this.lblIPAddress);
            this.pnlUpdate.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdate.Controls.Add(this.btnSubmitUpdate);
            this.pnlUpdate.Controls.Add(this.lblDepart);
            this.pnlUpdate.Controls.Add(this.txtDepartUpdate);
            this.pnlUpdate.Controls.Add(this.lblModName);
            this.pnlUpdate.Controls.Add(this.txtModName);
            this.pnlUpdate.Location = new System.Drawing.Point(553, 40);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(171, 247);
            this.pnlUpdate.TabIndex = 10011;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(27, 155);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 25;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(24, 139);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddress.TabIndex = 24;
            this.lblIPAddress.Text = "IP Address";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(93, 195);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 23;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.Location = new System.Drawing.Point(3, 195);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitUpdate.TabIndex = 22;
            this.btnSubmitUpdate.Text = "Submit";
            this.btnSubmitUpdate.UseVisualStyleBackColor = true;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(24, 24);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(62, 13);
            this.lblDepart.TabIndex = 18;
            this.lblDepart.Text = "Department";
            // 
            // txtDepartUpdate
            // 
            this.txtDepartUpdate.Location = new System.Drawing.Point(27, 40);
            this.txtDepartUpdate.Name = "txtDepartUpdate";
            this.txtDepartUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtDepartUpdate.TabIndex = 14;
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(24, 86);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(73, 13);
            this.lblModName.TabIndex = 19;
            this.lblModName.Text = "Module Name";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(27, 102);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(100, 20);
            this.txtModName.TabIndex = 15;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(212, 350);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(118, 13);
            this.lblDept.TabIndex = 10010;
            this.lblDept.Text = "Narrow To Department:";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(355, 350);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 10009;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(475, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10008;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(225, 15);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(322, 296);
            this.dgvOutput.TabIndex = 10007;
            this.dgvOutput.SelectionChanged += new System.EventHandler(this.dgvOutput_SelectionChange);
            // 
            // pnlArchiveView
            // 
            this.pnlArchiveView.Controls.Add(this.btnDelete);
            this.pnlArchiveView.Controls.Add(this.btnCancelArchive);
            this.pnlArchiveView.Controls.Add(this.btnUnarchive);
            this.pnlArchiveView.Location = new System.Drawing.Point(12, 187);
            this.pnlArchiveView.Name = "pnlArchiveView";
            this.pnlArchiveView.Size = new System.Drawing.Size(207, 149);
            this.pnlArchiveView.TabIndex = 10018;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(65, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 45);
            this.btnDelete.TabIndex = 10008;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelArchive
            // 
            this.btnCancelArchive.ForeColor = System.Drawing.Color.Black;
            this.btnCancelArchive.Location = new System.Drawing.Point(111, 29);
            this.btnCancelArchive.Name = "btnCancelArchive";
            this.btnCancelArchive.Size = new System.Drawing.Size(72, 45);
            this.btnCancelArchive.TabIndex = 10007;
            this.btnCancelArchive.Text = "Back";
            this.btnCancelArchive.UseVisualStyleBackColor = true;
            this.btnCancelArchive.Click += new System.EventHandler(this.btnCancelArchive_Click);
            // 
            // btnUnarchive
            // 
            this.btnUnarchive.ForeColor = System.Drawing.Color.Black;
            this.btnUnarchive.Location = new System.Drawing.Point(18, 29);
            this.btnUnarchive.Name = "btnUnarchive";
            this.btnUnarchive.Size = new System.Drawing.Size(72, 45);
            this.btnUnarchive.TabIndex = 10006;
            this.btnUnarchive.Text = "Unarchive Entry";
            this.btnUnarchive.UseVisualStyleBackColor = true;
            this.btnUnarchive.Click += new System.EventHandler(this.btnUnarchive_Click);
            // 
            // pnlDefault
            // 
            this.pnlDefault.Controls.Add(this.btnArchiveEntry);
            this.pnlDefault.Controls.Add(this.btnUpdateRow);
            this.pnlDefault.Location = new System.Drawing.Point(12, 15);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(164, 159);
            this.pnlDefault.TabIndex = 10017;
            // 
            // btnArchiveEntry
            // 
            this.btnArchiveEntry.ForeColor = System.Drawing.Color.Black;
            this.btnArchiveEntry.Location = new System.Drawing.Point(45, 96);
            this.btnArchiveEntry.Name = "btnArchiveEntry";
            this.btnArchiveEntry.Size = new System.Drawing.Size(76, 58);
            this.btnArchiveEntry.TabIndex = 12;
            this.btnArchiveEntry.Text = "Archive Entry";
            this.btnArchiveEntry.UseVisualStyleBackColor = true;
            this.btnArchiveEntry.Click += new System.EventHandler(this.btnArchiveEntry_Click);
            // 
            // btnUpdateRow
            // 
            this.btnUpdateRow.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRow.Location = new System.Drawing.Point(45, 9);
            this.btnUpdateRow.Name = "btnUpdateRow";
            this.btnUpdateRow.Size = new System.Drawing.Size(76, 58);
            this.btnUpdateRow.TabIndex = 11;
            this.btnUpdateRow.Text = "Update Entry";
            this.btnUpdateRow.UseVisualStyleBackColor = true;
            this.btnUpdateRow.Click += new System.EventHandler(this.btnUpdateRow_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 493);
            this.Controls.Add(this.pnlArchiveView);
            this.Controls.Add(this.pnlDefault);
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.lblVersionV);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOutput);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View ADAM Modules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmView_Closing);
            this.Load += new System.EventHandler(this.frmView_Load);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.pnlArchiveView.ResumeLayout(false);
            this.pnlDefault.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnViewArchive;
        private System.Windows.Forms.Label lblVersionV;
        public System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvOutput;
        public System.Windows.Forms.TextBox txtDepartUpdate;
        public System.Windows.Forms.TextBox txtModName;
        public System.Windows.Forms.Panel pnlArchiveView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelArchive;
        private System.Windows.Forms.Button btnUnarchive;
        public System.Windows.Forms.Panel pnlDefault;
        private System.Windows.Forms.Button btnArchiveEntry;
        private System.Windows.Forms.Button btnUpdateRow;
        public System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lblIPAddress;
    }
}