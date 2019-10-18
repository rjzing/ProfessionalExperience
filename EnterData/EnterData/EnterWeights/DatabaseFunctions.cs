//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/21/19
//Last modification made: took out method calls that are no longer needed
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using EnterData;

namespace EnterWeights
{
    public class DatabaseFunctions
    {
        public static string LDBDataDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EnterData", "PartWeights.mdf");
        public static string LDBConn = "SERVER=" + Program.LServer + ";DATABASE=" + Program.WeightsLDBName + ";Integrated Security=SSPI;AttachDbFileName=" + LDBDataDestination;
        public static frmMain _frmMain;
        public static frmView _frmView;

        //=======================================================================================================
        //This method takes the detach stored proc and executes it. I decided to use stored procs everywhere
        //  to keep everything as private as possible. Which is another reason why I detach the db file anytime
        //  it is used
        //=======================================================================================================
        public static void DetachFile()
        {
            try
            {
                SqlCommand _LDBComm = new SqlCommand();
                SqlConnection _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBConn.Open();
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Detach_LDB_SP]";
                _LDBComm.ExecuteNonQuery();
                _LDBConn.Close();

            }
            catch (Exception ex)
            {
                string text = ex.Message;
            }
        }

        //=========================================================================================================
        //This method inserts a new record into the weight table. The parameters come from the text boxes that were
        //  filled out on frmMain at the time the "Submit" button is clicked. After the stored proc is executed
        //  it detaches the file and refreshes the files. It clears out the text boxes automatically that will
        //  need to be changed for the next entry. This also will remind the user everything should be different
        //  for the next entry. It also takes exceptions and prompts the user what was wrong with their entry.
        //  I noticed it was easy for the user to enter the same part number more than once, which made me 
        //  create a constriant in the db to disallow the user to add the same part number more than once.
        //=========================================================================================================
        public static void InsertNew(string strDept, string strOp, string strPN, string strWeight, string strPartName, string strSTDPack)
        {
            try
            {
                SqlCommand _LDBComm = new SqlCommand();
                SqlConnection _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBConn.Open();
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Insert_Into_Weights_SP]";
                _LDBComm.Parameters.AddWithValue("@strDept", strDept);
                _LDBComm.Parameters.AddWithValue("@intOp", strOp);
                _LDBComm.Parameters.AddWithValue("@strPN", strPN);
                _LDBComm.Parameters.AddWithValue("@decWeight", strWeight);
                _LDBComm.Parameters.AddWithValue("@strPartName", strPartName);
                _LDBComm.Parameters.AddWithValue("@intSTDPack", strSTDPack);
                _LDBComm.ExecuteNonQuery();
                _LDBConn.Close();
                DetachFile();
                _frmMain.txtPN.Text = "";
                _frmMain.txtWeight.Text = "";
                _frmMain.txtPartName.Text = "";
                _frmMain.txtSTDPack.Text = "";
            }
            catch (Exception ex)
            {
                string text = ex.Message;
                if (text.Length > 35)
                {
                    if (text.Substring(0, 34) == "Violation of UNIQUE KEY constraint")
                    {
                        MessageBox.Show("Part Number Has Already Been Added");
                    }
                    else
                    {
                        MessageBox.Show("Could Not Add Entry, Check Data Types");
                    }
                }
                else
                {
                    MessageBox.Show("Could Not Add Entry , Check Data Types");
                }
            }
        }

        //=======================================================================================================
        //This method is called when the list needs to be refreshed. It is also the same method I call when the
        //  user clicks the "View" button on frmMain
        //=======================================================================================================
        public static void ViewCurrent()
        {
            SqlCommand _LDBComm = new SqlCommand();
            Program.PartWeights.Clear();
            try
            {
                SqlConnection _LDBConn = new SqlConnection();
                DataSet _DS = new DataSet();
                SqlDataAdapter _Adap = new SqlDataAdapter();
                _DS.Clear();
                _Adap.Dispose();
                _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Get_All_Weights_SP]";
                _Adap = new SqlDataAdapter(_LDBComm);
                _Adap.Fill(_DS);
                var allRows = _DS.Tables[0].Rows;
                LoadLists.LoadWeightsList(allRows);
                _LDBConn.Close();
            }
            catch (Exception ex)
            {
                string extext = ex.Message;
            }
            DetachFile();
        }

        //=======================================================================================================
        //This method called when the user changes the current entry from frmView. Since I automatically load
        //  the text boxes with the current selected entry, I update every field in the entry each time an 
        //  update occurs. This also has to check constraints, incase the user tries to update the entry with
        //  either a duplicated part number or the wrong data type is entered
        //=======================================================================================================
        public static void UpdateWeight(string strDept, string strOp, string strPN, string strWeight, string strPartName, string strSTDPack, int intTUID)
        {
            try
            {
                SqlCommand _LDBComm = new SqlCommand();
                SqlConnection _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBConn.Open();
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Update_Weights_SP]";
                _LDBComm.Parameters.AddWithValue("@strDept", strDept);
                _LDBComm.Parameters.AddWithValue("@intOp", strOp);
                _LDBComm.Parameters.AddWithValue("@strPN", strPN);
                _LDBComm.Parameters.AddWithValue("@decWeight", strWeight);
                _LDBComm.Parameters.AddWithValue("@strPartName", strPartName);
                _LDBComm.Parameters.AddWithValue("@intSTDPack", strSTDPack);
                _LDBComm.Parameters.AddWithValue("@intTUID", intTUID);
                _LDBComm.ExecuteNonQuery();
                _LDBConn.Close();
                DetachFile();
                ViewCurrent();
                _frmView.RefreshDGV();
            }
            catch (Exception ex)
            {
                string text = ex.Message;
                if (text.Length > 35)
                {
                    if (text.Substring(0, 34) == "Violation of UNIQUE KEY constraint")
                    {
                        MessageBox.Show("Part Number Has Already Been Added");
                    }
                    else
                    {
                        MessageBox.Show("Could Not Add Entry, Check Data Types");
                    }
                }
                else
                {
                    MessageBox.Show("Could Not Add Entry, Check Data Types");
                }
            }
        }

        //=======================================================================================================
        //This method called when the user decides they want to delete an entry from the archived parts. It 
        //  executes the delete stored proc, with the currently selected row's TUID and deletes that entry.
        //=======================================================================================================
        public static void DeleteEntry(int intTUID)
        {
            _frmView.GetSelectedRow();
            try
            {
                SqlCommand _LDBComm = new SqlCommand();
                SqlConnection _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBConn.Open();
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Delete_Entry_Weights_SP]";
                _LDBComm.Parameters.AddWithValue("@intTUID", intTUID);
                _LDBComm.Connection = _LDBConn;
                _LDBComm.ExecuteNonQuery();
                _LDBConn.Close();
                DetachFile();
                ViewCurrent();
                _frmView.RefreshDGV();
                DetachFile();

            }
            catch (Exception ex)
            {
                string text = ex.Message;
            }

        }

        //=======================================================================================================
        //This method called when the user wants to narrow the current part list down to a specific department.
        //  Its parameter is what is currently entered into the text box on frmView. If the user does not 
        //  enter any kind of string in the text box it assumes the user wants to view all records in the weight
        //  table. If a department is not found in the table, a prompt will appear and tell the user that was 
        //  was an invaild department entered.
        //=======================================================================================================
        public static void NarrowToDept(string strDept)
        {
            SqlCommand _LDBComm = new SqlCommand();
            try
            {
                SqlConnection _LDBConn = new SqlConnection();
                DataSet _DS = new DataSet();
                SqlDataAdapter _Adap = new SqlDataAdapter();
                _DS.Clear();
                _Adap.Dispose();
                _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Get_All_Dept_Weights_SP]";
                _LDBComm.Parameters.AddWithValue("@strDept", strDept);
                _Adap = new SqlDataAdapter(_LDBComm);
                _Adap.Fill(_DS);
                var allRows = _DS.Tables[0].Rows;
                LoadLists.LoadWeightsList(allRows);
                _LDBConn.Close();
                DetachFile();
            }
            catch (Exception ex)
            {
                string extext = ex.Message;
            }
        }

        //=======================================================================================================
        //This method is called when the user wants to view the currently archived list in the weight table. I
        //  decided to implement the archvie incase the user accidently selected the wrong entry when they went
        //  to delete the entry. You can only permanently delete a record from the archive view 
        //=======================================================================================================
        public static void ViewArchive()
        {
            SqlCommand _LDBComm = new SqlCommand();
            Program.PartWeights.Clear();
            try
            {
                SqlConnection _LDBConn = new SqlConnection();
                DataSet _DS = new DataSet();
                SqlDataAdapter _Adap = new SqlDataAdapter();
                _DS.Clear();
                _Adap.Dispose();
                _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBComm.Connection = _LDBConn;
                _LDBComm.CommandType = CommandType.StoredProcedure;
                _LDBComm.CommandText = "[dbo].[Get_Archive_Weights_SP]";
                _Adap = new SqlDataAdapter(_LDBComm);
                _Adap.Fill(_DS);
                var allRows = _DS.Tables[0].Rows;
                LoadLists.LoadWeightsList(allRows);
                _LDBConn.Close();
                DetachFile();
                _frmView.RefreshDGV();
                _frmView.pnlDefault.Visible = false;
                _frmView.pnlUpdate.Visible = false;
                _frmView.pnlArchiveView.Visible = true;
                _frmView.btnViewArchive.Visible = false;
            }
            catch (Exception ex)
            {
                string errorText = ex.Message;
            }
        }

        //=======================================================================================================
        //This method is called when the user wants to either unarchive or archive the entry. The 
        //  parameter is a boolean to see if the user is currently archving or unarchiving the current entry that
        //  is selected on frmView. It then executes the correct stored proc 
        //=======================================================================================================
        public static void Archiving(bool Archive)
        {
            _frmView.GetSelectedRow();
            try
            {
                SqlCommand _LDBComm = new SqlCommand();
                SqlConnection _LDBConn = new SqlConnection
                {
                    ConnectionString = LDBConn
                };
                _LDBConn.Open();
                if (Archive)
                {
                    _LDBComm.CommandType = CommandType.StoredProcedure;
                    _LDBComm.CommandText = "[dbo].[Archive_Weight_Entry_SP]";
                }
                else
                {
                    _LDBComm.CommandType = CommandType.StoredProcedure;
                    _LDBComm.CommandText = "[dbo].[Unarchive_Weight_Entry_SP]";
                }
                _LDBComm.Parameters.AddWithValue("@intTUID", _frmView.intTUID);
                _LDBComm.Connection = _LDBConn;
                _LDBComm.ExecuteNonQuery();
                _LDBConn.Close();
                DetachFile();
                ViewCurrent();
                _frmView.RefreshDGV();
                DetachFile();
            }
            catch (Exception ex)
            {
                string text = ex.Message;
            }
        }
    }
}