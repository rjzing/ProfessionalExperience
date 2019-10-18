//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: migrated class into a single app for all database management systems
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Threading.Tasks;
using System.Drawing;
using EnterData;

namespace EnterQADPrinters
{
    public partial class frmMain : Form
    {   
        public frmView _FrmView;
        public frmMainMenu _FrmMainMen;
        //=======================================================================================================
        //Constructor. It also sets the DatabaseFunctions frmMain instance to the proper frmMain instance so I
        //  could properly reference this form in DatabaseFunctions' methods. It also calls the method to copy 
        //  the db files to the local machine
        //=======================================================================================================
        public frmMain()
        {   
            InitializeComponent();
            FileConfig.CopyDBFiles();
            DatabaseFunctions._frmMain = this;
            frmView._frmMain = this;
        }

        //=======================================================================================================
        //This method is called when the user clicks on the "Submit" button on frmMain. It then checks if all 
        //  text boxes arent empty, if they are they will prompt the user to enter info for all text boxes, if 
        //  all text boxes are filled out, it will call the proper DatabaseFunctions method to insert new entry
        //  in the printer table
        //=======================================================================================================
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string tempDept = txtDepart.Text;
            string tempPrinterName = txtPrinterName.Text;
            if (tempDept != "" && tempPrinterName != "")
            {
                SplashScreen _splash = new SplashScreen
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.None,
                    WindowState = FormWindowState.Normal,
                    MaximumSize = new Size(Program.SplashScreenWidth, Program.SplashScreenHeight),
                    MinimumSize = new Size(Program.SplashScreenWidth, Program.SplashScreenHeight)
                };
                await Task.Delay(200);
                _splash.Show();

                _splash.BringToFront();   
                _splash.Focus();
                await Task.Delay(200);
                DatabaseFunctions.InsertNew(tempDept, tempPrinterName);
                txtPrinterName.Text = "";
                _splash.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Please Enter Info For Each Field");
            }
        }

        //=======================================================================================================
        //This method is called when the user hits the "View" button on frmMain. It then calls the proper 
        //  DatabaseFunctions method that will load the list with all current modules entered in the table
        //  and also opens a new instance of frmView. Since this is the first time ViewCurrent is called, it 
        //  needs to create the new instance of frmView
        //=======================================================================================================
        private async void btnView_Click(object sender, EventArgs e)
        {    
            this.Hide();
            _FrmMainMen.Hide();
            SplashScreen _splash = new SplashScreen
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Normal,
                MaximumSize = new Size(Program.SplashScreenWidth, Program.SplashScreenHeight),   
                MinimumSize = new Size(Program.SplashScreenWidth, Program.SplashScreenHeight)    
            };   
            await Task.Delay(200);
            _splash.Show();   
            _splash.BringToFront();   
            _splash.Focus();   
            await Task.Delay(200);
            DatabaseFunctions.ViewCurrent();
            _FrmView = new frmView();
            await Task.Delay(200);
            _FrmView.Show();
            _splash.Close(); 
        }

        //=======================================================================================================
        //This method is called when frmMain loads, it then sets the version label to the current running 
        //  version of EnterQADPrinters. Allows to easily see if the user needs to update their version since I
        //  dont know how to automatically check for updates when the app is loaded
        //=======================================================================================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "©R. Zinger V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        //=======================================================================================================
        //This method is called when frmMain closes, it then shows the frmMainMenu and disposes current frmMain
        //  and frmView. I do this to keep as little resources in use throughout the entire runtime.
        //=======================================================================================================
        private void frmMain_Closing(object sender, EventArgs e)
        {    
            _FrmMainMen.Visible = true;
            this.Dispose();
            if (_FrmView != null)
            {
                _FrmView.Dispose();
            }
        }
    }
}
