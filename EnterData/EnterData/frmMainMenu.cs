//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: Implemented class
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.Windows.Forms;
using System.Reflection;

namespace EnterData
{
    public partial class frmMainMenu : Form
    {
        public EnterADAMMods.frmMain _frmADAMMain;
        public EnterQADPrinters.frmMain _frmQADMain;
        public EnterWeights.frmMain _frmWeightsMain;

        //========================================================================================================
        //Constructor for the main menu form
        //========================================================================================================
        public frmMainMenu()
        {
            InitializeComponent();
            EnterADAMMods.DatabaseFunctions._frmMainMen = this;
            EnterADAMMods.frmView._frmMainMen = this;
        }

        //========================================================================================================
        //Opens Enter ADAM  main form
        //========================================================================================================
        private void btnADAMMods_Click(object sender, EventArgs e)
        {
            _frmADAMMain = new EnterADAMMods.frmMain();
            _frmADAMMain._FrmMainMen = this;
            this.Hide();
            _frmADAMMain.Show();    
        }

        //========================================================================================================
        //Opens Enter QAD Printer main form
        //========================================================================================================
        private void btnQADPrinter_Click(object sender, EventArgs e)
        {
            _frmQADMain = new EnterQADPrinters.frmMain();
            _frmQADMain._FrmMainMen = this;
            this.Hide();
            _frmQADMain.Show();
        }

        //========================================================================================================
        //Opens enter weights main form
        //========================================================================================================
        private void btnWeights_Click(object sender, EventArgs e)
        {
            _frmWeightsMain = new EnterWeights.frmMain();
            _frmWeightsMain._FrmMainMen = this;
            this.Hide();
            _frmWeightsMain.Show();
        }

        //========================================================================================================
        //Loads the current version running label
        //========================================================================================================
        private void frmMainMenu_load(object sender, EventArgs e)
        {
            lblVersion.Text = "©R. Zinger V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
