//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: Implemented class
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.Collections.Generic;
using System.Windows;

namespace EnterData
{
    static class Program
    {
        public static List<SmallClasses.PartWeights> PartWeights = new List<SmallClasses.PartWeights>();
        public static List<SmallClasses.ADAMMods> ADAMMods = new List<SmallClasses.ADAMMods>();
        public static List<SmallClasses.QADPrinter> QADPrinters = new List<SmallClasses.QADPrinter>();
        public static int SplashScreenHeight;
        public static int SplashScreenWidth;
        public static string QADLDBName = "QADPrinters";
        public static string ADAMLDBName = "ADAMModules";
        public static string WeightsLDBName = "PartWeights";
        public static string LServer = "(localdb)\\MSSQLLocalDB";
        public static string AppDirectory = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public static string SharedDBPath = AppDirectory + "\\DBFiles\\";
        public static string LocalAppDBPath = SharedDBPath;

        //========================================================================================================
        //Constructor for entire app. It also gets the screen size to scale the splash screen
        //========================================================================================================
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            GetScreenSize();
            System.Windows.Forms.Application.Run(new frmMainMenu());
        }

        //========================================================================================================
        //This method gets the screen size and sets the splash screen size to scale it on different screens
        //========================================================================================================
        public static void GetScreenSize()
        {
            int ScreenHeight;
            int ScreenWidth;
            int ScreenMargin;
            ScreenHeight = Convert.ToInt32(SystemParameters.PrimaryScreenHeight);
            ScreenWidth = Convert.ToInt32(SystemParameters.PrimaryScreenWidth);
            ScreenMargin = (ScreenWidth / ScreenHeight) * 5;
            SplashScreenHeight = (ScreenHeight / 2) + (ScreenHeight / 4);
            SplashScreenWidth = (ScreenWidth - (ScreenMargin * 8));
        }
    }
}
