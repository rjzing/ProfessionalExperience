namespace EnterData
{
    partial class frmMainMenu
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
            this.btnADAMMods = new System.Windows.Forms.Button();
            this.btnQADPrinter = new System.Windows.Forms.Button();
            this.btnWeights = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnADAMMods
            // 
            this.btnADAMMods.Location = new System.Drawing.Point(128, 109);
            this.btnADAMMods.Name = "btnADAMMods";
            this.btnADAMMods.Size = new System.Drawing.Size(104, 23);
            this.btnADAMMods.TabIndex = 0;
            this.btnADAMMods.Text = "ADAM Modules";
            this.btnADAMMods.UseVisualStyleBackColor = true;
            this.btnADAMMods.Click += new System.EventHandler(this.btnADAMMods_Click);
            // 
            // btnQADPrinter
            // 
            this.btnQADPrinter.Location = new System.Drawing.Point(128, 169);
            this.btnQADPrinter.Name = "btnQADPrinter";
            this.btnQADPrinter.Size = new System.Drawing.Size(104, 23);
            this.btnQADPrinter.TabIndex = 1;
            this.btnQADPrinter.Text = "QAD Printers";
            this.btnQADPrinter.UseVisualStyleBackColor = true;
            this.btnQADPrinter.Click += new System.EventHandler(this.btnQADPrinter_Click);
            // 
            // btnWeights
            // 
            this.btnWeights.Location = new System.Drawing.Point(128, 230);
            this.btnWeights.Name = "btnWeights";
            this.btnWeights.Size = new System.Drawing.Size(104, 23);
            this.btnWeights.TabIndex = 2;
            this.btnWeights.Text = "Part Weights";
            this.btnWeights.UseVisualStyleBackColor = true;
            this.btnWeights.Click += new System.EventHandler(this.btnWeights_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblVersion.Location = new System.Drawing.Point(126, 300);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 9);
            this.lblVersion.TabIndex = 10005;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 392);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnWeights);
            this.Controls.Add(this.btnQADPrinter);
            this.Controls.Add(this.btnADAMMods);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Data";
            this.Load += new System.EventHandler(this.frmMainMenu_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADAMMods;
        private System.Windows.Forms.Button btnQADPrinter;
        private System.Windows.Forms.Button btnWeights;
        private System.Windows.Forms.Label lblVersion;
    }
}

