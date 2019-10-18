namespace EnterWeights
{
    partial class frmMain
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
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSTDPack = new System.Windows.Forms.Label();
            this.txtSTDPack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(46, 57);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(100, 20);
            this.txtDepart.TabIndex = 0;
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(193, 57);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(100, 20);
            this.txtOp.TabIndex = 1;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(326, 57);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(100, 20);
            this.txtPN.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(46, 130);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(27, 20);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(141, 13);
            this.lblDepart.TabIndex = 10000;
            this.lblDepart.Text = "Department (JAMES Format)";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(208, 20);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(53, 13);
            this.lblOp.TabIndex = 10000;
            this.lblOp.Text = "Operation";
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Location = new System.Drawing.Point(348, 20);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(66, 13);
            this.lblPN.TabIndex = 10000;
            this.lblPN.Text = "Part Number";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(73, 101);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 10000;
            this.lblWeight.Text = "Weight";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(211, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(211, 232);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(193, 130);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(100, 20);
            this.txtPartName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(208, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 10000;
            this.lblName.Text = "Part Name ";                     
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersion.Location = new System.Drawing.Point(191, 271);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 9);
            this.lblVersion.TabIndex = 10001;
            // 
            // lblSTDPack
            // 
            this.lblSTDPack.AutoSize = true;
            this.lblSTDPack.Location = new System.Drawing.Point(336, 101);
            this.lblSTDPack.Name = "lblSTDPack";
            this.lblSTDPack.Size = new System.Drawing.Size(78, 13);
            this.lblSTDPack.TabIndex = 10002;
            this.lblSTDPack.Text = "Standard Pack";
            // 
            // txtSTDPack
            // 
            this.txtSTDPack.Location = new System.Drawing.Point(326, 130);
            this.txtSTDPack.Name = "txtSTDPack";
            this.txtSTDPack.Size = new System.Drawing.Size(100, 20);
            this.txtSTDPack.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 304);
            this.Controls.Add(this.txtSTDPack);
            this.Controls.Add(this.lblSTDPack);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.txtDepart);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Part Weights";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOp;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSTDPack;
        private System.Windows.Forms.TextBox txtDepart;
        public System.Windows.Forms.TextBox txtPN;
        public System.Windows.Forms.TextBox txtWeight;
        public System.Windows.Forms.TextBox txtPartName;
        public System.Windows.Forms.TextBox txtSTDPack;
    }
}

