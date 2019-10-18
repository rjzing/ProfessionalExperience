namespace EnterQADPrinters
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
            this.lblDepart = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.lblPrinterName = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(22, 23);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(141, 13);
            this.lblDepart.TabIndex = 10001;
            this.lblDepart.Text = "Department (JAMES Format)";
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(38, 49);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(100, 20);
            this.txtDepart.TabIndex = 0;
            // 
            // lblPrinterName
            // 
            this.lblPrinterName.AutoSize = true;
            this.lblPrinterName.Location = new System.Drawing.Point(228, 23);
            this.lblPrinterName.Name = "lblPrinterName";
            this.lblPrinterName.Size = new System.Drawing.Size(71, 13);
            this.lblPrinterName.TabIndex = 10002;
            this.lblPrinterName.Text = "Printer Name ";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(212, 49);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(100, 20);
            this.txtPrinterName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(130, 130);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(130, 176);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersion.Location = new System.Drawing.Point(109, 230);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 9);
            this.lblVersion.TabIndex = 10003;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 274);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.lblPrinterName);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.lblDepart);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter QAD Printers";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblPrinterName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnView;
        public System.Windows.Forms.TextBox txtDepart;
        public System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label lblVersion;
    }
}

