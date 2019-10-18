namespace EnterWeights
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtStdPack = new System.Windows.Forms.TextBox();
            this.lblSTDPack = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.txtDepartUpdate = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.btnArchiveEntry = new System.Windows.Forms.Button();
            this.btnUpdateRow = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersionV = new System.Windows.Forms.Label();
            this.btnViewArchive = new System.Windows.Forms.Button();
            this.pnlArchiveView = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelArchive = new System.Windows.Forms.Button();
            this.btnUnarchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            this.pnlDefault.SuspendLayout();
            this.pnlArchiveView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(220, 31);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(541, 296);
            this.dgvOutput.TabIndex = 0;    
            this.dgvOutput.SelectionChanged += new System.EventHandler(this.dgvOutput_SelectionChange);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(597, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(410, 370);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 11;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(257, 367);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(118, 13);
            this.lblDept.TabIndex = 12;
            this.lblDept.Text = "Narrow To Department:";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.txtStdPack);
            this.pnlUpdate.Controls.Add(this.lblSTDPack);
            this.pnlUpdate.Controls.Add(this.txtPartName);
            this.pnlUpdate.Controls.Add(this.lblName);
            this.pnlUpdate.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdate.Controls.Add(this.btnSubmitUpdate);
            this.pnlUpdate.Controls.Add(this.txtPN);
            this.pnlUpdate.Controls.Add(this.lblPN);
            this.pnlUpdate.Controls.Add(this.lblWeight);
            this.pnlUpdate.Controls.Add(this.lblDepart);
            this.pnlUpdate.Controls.Add(this.txtDepartUpdate);
            this.pnlUpdate.Controls.Add(this.txtWeight);
            this.pnlUpdate.Controls.Add(this.lblOp);
            this.pnlUpdate.Controls.Add(this.txtOp);
            this.pnlUpdate.Location = new System.Drawing.Point(767, 31);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(164, 435);
            this.pnlUpdate.TabIndex = 13;
            // 
            // txtStdPack
            // 
            this.txtStdPack.Location = new System.Drawing.Point(21, 357);
            this.txtStdPack.Name = "txtStdPack";
            this.txtStdPack.Size = new System.Drawing.Size(100, 20);
            this.txtStdPack.TabIndex = 28;
            // 
            // lblSTDPack
            // 
            this.lblSTDPack.AutoSize = true;
            this.lblSTDPack.Location = new System.Drawing.Point(18, 341);
            this.lblSTDPack.Name = "lblSTDPack";
            this.lblSTDPack.Size = new System.Drawing.Size(78, 13);
            this.lblSTDPack.TabIndex = 27;
            this.lblSTDPack.Text = "Standard Pack";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(21, 299);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(100, 20);
            this.txtPartName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 283);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Part Name";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(86, 402);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 23;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.Location = new System.Drawing.Point(3, 402);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitUpdate.TabIndex = 22;
            this.btnSubmitUpdate.Text = "Submit";
            this.btnSubmitUpdate.UseVisualStyleBackColor = true;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(21, 172);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(100, 20);
            this.txtPN.TabIndex = 16;
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Location = new System.Drawing.Point(18, 156);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(66, 13);
            this.lblPN.TabIndex = 20;
            this.lblPN.Text = "Part Number";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(18, 225);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 21;
            this.lblWeight.Text = "Weight";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(18, 24);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(62, 13);
            this.lblDepart.TabIndex = 18;
            this.lblDepart.Text = "Department";         
            // 
            // txtDepartUpdate
            // 
            this.txtDepartUpdate.Location = new System.Drawing.Point(21, 40);
            this.txtDepartUpdate.Name = "txtDepartUpdate";
            this.txtDepartUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtDepartUpdate.TabIndex = 14;    
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(21, 241);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 17;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(18, 86);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(53, 13);
            this.lblOp.TabIndex = 19;
            this.lblOp.Text = "Operation";
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(21, 102);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(100, 20);
            this.txtOp.TabIndex = 15;
            // 
            // pnlDefault
            // 
            this.pnlDefault.Controls.Add(this.btnArchiveEntry);
            this.pnlDefault.Controls.Add(this.btnUpdateRow);
            this.pnlDefault.Location = new System.Drawing.Point(9, 31);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(164, 159);
            this.pnlDefault.TabIndex = 23;
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
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersion.Location = new System.Drawing.Point(400, 221);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 9);
            this.lblVersion.TabIndex = 10002;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label1.Location = new System.Drawing.Point(408, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 9);
            this.label1.TabIndex = 10003;
            // 
            // lblVersionV
            // 
            this.lblVersionV.AutoSize = true;
            this.lblVersionV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersionV.Location = new System.Drawing.Point(400, 488);
            this.lblVersionV.Name = "lblVersionV";
            this.lblVersionV.Size = new System.Drawing.Size(0, 9);
            this.lblVersionV.TabIndex = 10004;
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.ForeColor = System.Drawing.Color.Black;
            this.btnViewArchive.Location = new System.Drawing.Point(424, 409);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(75, 47);
            this.btnViewArchive.TabIndex = 10005;
            this.btnViewArchive.Text = "View Archived Entries";
            this.btnViewArchive.UseVisualStyleBackColor = true;
            this.btnViewArchive.Click += new System.EventHandler(this.btnViewArchive_Click);
            // 
            // pnlArchiveView
            // 
            this.pnlArchiveView.Controls.Add(this.btnDelete);
            this.pnlArchiveView.Controls.Add(this.btnCancelArchive);
            this.pnlArchiveView.Controls.Add(this.btnUnarchive);
            this.pnlArchiveView.Location = new System.Drawing.Point(9, 203);
            this.pnlArchiveView.Name = "pnlArchiveView";
            this.pnlArchiveView.Size = new System.Drawing.Size(207, 149);
            this.pnlArchiveView.TabIndex = 10006;
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
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 529);
            this.Controls.Add(this.pnlArchiveView);
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.lblVersionV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlDefault);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOutput);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Weights";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmView_Closing);
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlDefault.ResumeLayout(false);
            this.pnlArchiveView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtOp;
        private System.Windows.Forms.TextBox txtDepartUpdate;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Button btnUpdateRow;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnArchiveEntry;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersionV;
        private System.Windows.Forms.Button btnUnarchive;
        private System.Windows.Forms.Button btnCancelArchive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStdPack;
        private System.Windows.Forms.Label lblSTDPack;
        public System.Windows.Forms.Panel pnlUpdate;
        public System.Windows.Forms.Panel pnlDefault;
        public System.Windows.Forms.Panel pnlArchiveView;
        public System.Windows.Forms.Button btnViewArchive;
    }
}