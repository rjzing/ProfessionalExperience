namespace EnterADAMMods
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(148, 34);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(141, 13);
            this.lblDepart.TabIndex = 10001;
            this.lblDepart.Text = "Department (JAMES Format)";
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(165, 62);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(100, 20);
            this.txtDepart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10002;
            this.label1.Text = "Module Name";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(165, 134);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(100, 20);
            this.txtModName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10003;
            this.label2.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(165, 211);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(174, 279);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(174, 339);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersion.Location = new System.Drawing.Point(149, 387);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 9);
            this.lblVersion.TabIndex = 10004;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.lblDepart);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter ADAM Modules";
            this.Load += new System.EventHandler(this.frmMain_Load);
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmView_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmADAM_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblVersion;
    }
}

