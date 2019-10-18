//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: migrated class into a single app for all database management systems
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;  
using System.Windows.Forms;

namespace EnterData
{
    public partial class SplashScreen : Form
    {
        //=======================================================================================================
        //Constructor.
        //=======================================================================================================
        public SplashScreen()
        {      
            InitializeComponent();  
        }

        //=======================================================================================================
        //This method is called when the splash screen needs to re-size. It puts the loading label in the middle
        //  of the splash screen
        //=======================================================================================================
        private void Splash_ReSize(object sender, EventArgs e)
        {
            lblLoading.Left = (ClientSize.Width - lblLoading.Width) / 2;  
            lblLoading.Top = lblLoading.Height / 2;
        }
    }
}
