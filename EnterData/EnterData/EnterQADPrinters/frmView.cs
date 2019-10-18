//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: migrated class into a single app for all database management systems
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using EnterData;

namespace EnterQADPrinters
{
    public partial class frmView : Form
    {
        public int intTUID;
        public bool bolArchiveView;
        public static frmMain _frmMain;
        //=======================================================================================================
        //Constructor. This sets up the form when it is opened from frmMain. It also sets DatabaseFunctions'
        //  frmView to the current instance of frmView to properly reference it from DatabaseFunctions
        //=======================================================================================================
        public frmView()
        {
            InitializeComponent();    
            pnlDefault.Visible = true;
            pnlUpdate.Visible = false;
            pnlArchiveView.Visible = false;
            DatabaseFunctions._frmView = this;
            RefreshDGV();
        }

        //=======================================================================================================
        //This method is called when the dgv needs to be refreshed when the list QADPrinters changes. It properly
        //  formats the dgv with the proper headings and auto resizes the columns to make viewing easier for the
        //  user.
        //=======================================================================================================
        public void RefreshDGV()
        {
            dgvOutput.DataSource = null;
            dgvOutput.AutoResizeColumns();
            dgvOutput.DataSource = Program.QADPrinters;
            dgvOutput.RowHeadersVisible = false;
            dgvOutput.Columns[0].Visible = false;
            dgvOutput.Columns[0].HeaderText = "TUID";
            dgvOutput.Columns[1].HeaderText = "Department";
            dgvOutput.Columns[2].HeaderText = "Printer Name";
            dgvOutput.AutoResizeColumns();
            dgvOutput.Refresh();
        }

        //=======================================================================================================
        //This method is called when the frmView is loaded, it sets the version label to the current running 
        //  version of EnterQADPrinters to easily be able to identify which version the user is using
        //=======================================================================================================
        private void frmView_Load(object sender, EventArgs e)
        {
            lblVersionV.Text = "©R. Zinger V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        //=======================================================================================================
        //This method is called when the user hits the "Update" button. Which then calls the method to narrow the
        //  current list to one department. If there is nothing entered in the text box, it will assume the user
        //  wants to view the entire list of the printer table. If the count of the printers list is 0, it will
        //  then prompt the user an invalid department was entered and clears out the text box; if it is greater
        //  than 0 it refreshes the dgv to show the current printers entered in the specified department
        //=======================================================================================================
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
            Program.QADPrinters.Clear();
            if (txtDept.Text != "")
            {
                DatabaseFunctions.NarrowToDept(txtDept.Text);
                if (Program.QADPrinters.Count > 0)
                {
                    RefreshDGV();
                }
                else
                {
                    txtDept.Text = "";
                    DatabaseFunctions.ViewCurrent();
                    RefreshDGV();
                    MessageBox.Show("Invalid Department Entered");
                }
            }
            else
            {
                DatabaseFunctions.ViewCurrent();
                RefreshDGV();
            }
            _splash.Close();
            this.Visible = true;
        }

        //=======================================================================================================
        //This method is called when the user clicks any button that needs to get the selected row in the dgv.
        //  It takes the index on and uses that TUID to properly distinguish which entry is selected. This will
        //  break the app if there are no entries in the current list, so I added an if statement to stop this
        //=======================================================================================================
        public void GetSelectedRow()
        {
            int intIndex = 0;
            intTUID = 0;
            if (Program.QADPrinters.Count > 0)
            {
                var indexOn = Convert.ToInt32(dgvOutput.SelectedRows[intIndex].Index);
                intTUID = Program.QADPrinters[indexOn].TUID;
                txtDepartUpdate.Text = Program.QADPrinters[indexOn].Dept;
                txtPrinterName.Text = Program.QADPrinters[indexOn].PrinterName;
            }   
        }

        //=======================================================================================================
        //This method is called when the user hit the "Update Entry" button. When they click this button, it 
        //  calls the GetSelectedRow method to make sure the text boxes are currently showing the proper entry
        //  entry's data
        //=======================================================================================================
        private void btnUpdateRow_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
            pnlDefault.Visible = false;
            pnlArchiveView.Visible = false;
            btnViewArchive.Visible = false;
            GetSelectedRow();
        }

        //=======================================================================================================
        //This method is called when the user clicks the "Cancel" button when they are currently in "UpdateRow" 
        //  mode, it then shows/hides the proper panels.
        //=======================================================================================================
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
            pnlDefault.Visible = true;
            pnlArchiveView.Visible = false;
            btnViewArchive.Visible = true;
        }

        //=======================================================================================================
        //This method is called when the user clicks the "Submit" button when they are currently in "UpdateRow" 
        //  mode. It makes sure there is data entered in each text box, when this is true, it calls the 
        //  "UpdateWeight" method from DatabaseFunction.cs. If the user has not entered info for each text box,
        //  it will prompt them to fill out all fields and try again
        //=======================================================================================================
        private async void btnSubmitUpdate_Click(object sender, EventArgs e)
        {        
            if (txtDepartUpdate.Text != "" && txtPrinterName.Text != "")
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
                DatabaseFunctions.UpdatePrinter(txtDepartUpdate.Text, txtPrinterName.Text, intTUID);
                pnlUpdate.Visible = false;
                pnlDefault.Visible = true;
                pnlArchiveView.Visible = false;
                btnViewArchive.Visible = true;
                _splash.Close();   
            }
            else
            {
                MessageBox.Show("Please Enter Info For Each Field");
            }
            
        }

        //=======================================================================================================
        //This method is called when the user clicks the "Archive Entry" button, it then shows a message box to
        //  make sure the user wants to archive the order, if they click yes, it calls the "Archiving" method in
        //  the DatabaseFunctions.cs file.
        //=======================================================================================================
        private async void btnArchiveEntry_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are You Sure You Want To Archive This Entry?", "Archive Entry", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
                DatabaseFunctions.Archiving(true);
                bolArchiveView = false;
                pnlDefault.Visible = true;
                pnlUpdate.Visible = false;
                pnlArchiveView.Visible = false;
                btnViewArchive.Visible = true;
                _splash.Close();
            }
            
        }

        //========================================================================================================
        //This method is called when the user clicks on the "View Archived Entries" button. It calls the 
        //  DatabaseFunctions view current archive entries method
        //========================================================================================================
        private async void btnViewArchive_Click(object sender, EventArgs e)
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
            DatabaseFunctions.ViewArchive();
            bolArchiveView = true;
            RefreshDGV();
            pnlDefault.Visible = false;
            pnlUpdate.Visible = false;
            pnlArchiveView.Visible = true;
            btnViewArchive.Visible = false;
            _splash.Close();
        }

        //========================================================================================================
        //This method is called when the user in view archived mode, which makes the entry not archived anymore. 
        //  If the list count is 0, it tells the user there are no entries to unarchive, if there is count greater
        //  than 0 it calls DatabaseFunctions archive method 
        //========================================================================================================
        private async void btnUnarchive_Click(object sender, EventArgs e)
        {
            if (Program.QADPrinters.Count > 0)
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
                DatabaseFunctions.Archiving(false);
                bolArchiveView = false;
                pnlDefault.Visible = true;
                pnlUpdate.Visible = false;
                pnlArchiveView.Visible = false;
                btnViewArchive.Visible = true;
                _splash.Close();
            }
            else
            {
                MessageBox.Show("No Entries To Unarchive");
            }
        }

        //========================================================================================================
        //This method is called when the user clicks on the "Back" button when currently viewing archived entries.
        //  It properly updates the dgv to show all entries in the printere table again
        //========================================================================================================
        private async void btnCancelArchive_Click(object sender, EventArgs e)
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
            DatabaseFunctions.ViewCurrent();
            RefreshDGV();
            DatabaseFunctions.DetachFile();
            bolArchiveView = false;
            pnlDefault.Visible = true;
            pnlUpdate.Visible = false;
            pnlArchiveView.Visible = false;
            btnViewArchive.Visible = true;
            _splash.Close();  
        }

        //========================================================================================================
        //This method is called when the user clicks on the "Delete Entry" button when currently viewing archived
        //  entires. This allows the user to permanently delete the entry. It first checks if there are more than
        //  0 entries currently in the printer list, if there isnt any, it will tell the user there are no 
        //  entries to delete. If there is, it shows a yes/no message box, if the user clicks "Yes" the entry is
        //  wiped from the database, if not, it just shows them the current archived entries
        //========================================================================================================
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (Program.QADPrinters.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Entry?", "Delete Entry", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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
                    bolArchiveView = false;
                    pnlDefault.Visible = true;
                    pnlUpdate.Visible = false;
                    pnlArchiveView.Visible = false;
                    btnViewArchive.Visible = true;
                    GetSelectedRow();
                    DatabaseFunctions.DeleteEntry(intTUID);
                    _splash.Close();
                }
            }
            else
            {
                MessageBox.Show("No Entries To Delete");
            }
        }

        //========================================================================================================
        //This method is called when the user changes the selection in dgvOutput. I use this method to close the
        //  proper panels when the selection is changed since I always want to assume the user is currently in the
        //  "update entry" mode which needs to change the text boxes with the currently selected entry
        //========================================================================================================
        private void dgvOutput_SelectionChange(object sender, EventArgs e)
        {
            if (!bolArchiveView)
            {
                pnlDefault.Visible = true;
                pnlUpdate.Visible = false;
                pnlArchiveView.Visible = false;
                btnViewArchive.Visible = true;
            }
            else
            {
                pnlDefault.Visible = false;
                pnlUpdate.Visible = false;
                pnlArchiveView.Visible = true;
                btnViewArchive.Visible = false;
            }
        }

        //=======================================================================================================
        //This method is called when the frmView is closing, it shows frmMain again, it was easier to allow only
        //  one form to show at a time
        //=======================================================================================================
        private void frmView_Closing(object sender, EventArgs e)
        {
            _frmMain.Visible = true;
            this.Dispose();
        }
    } 
} 