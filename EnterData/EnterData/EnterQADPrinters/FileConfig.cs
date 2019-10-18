//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/21/19
//Last modification made: took out the refresh files method that is not used anymore
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;
using System.IO;

namespace EnterQADPrinters
{
    public class FileConfig
    {
        //=======================================================================================================
        //This method copies the proper db file and saves it in the local drive. I also save it as a
        //  local file to make sure any number of instances can run at the same time because if I attached the
        //  other version, it would not be able to attach that file if more than one instance is using the
        //  file.
        //=======================================================================================================
        public static void CopyDBFiles()
        {
            bool DebugMode;
            string LDBDataRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EnterData");
            var LDBDataDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EnterData", "QADPrinters.mdf");
            var LDBLogDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EnterData", "QADPrinters.ldf");
            try
            {
                if (!Directory.Exists(LDBDataRoot))
                    Directory.CreateDirectory(LDBDataRoot);
#if DEBUG
                DebugMode = true;
#else
                DebugMode = false;  
#endif          
                if (!File.Exists(LDBDataDestination))
                {
                    File.Copy(EnterData.Program.LocalAppDBPath + EnterData.Program.QADLDBName + ".mdf", LDBDataDestination, true);
                }
                if (!File.Exists(LDBLogDestination))
                {
                    File.Copy(EnterData.Program.LocalAppDBPath + EnterData.Program.QADLDBName + ".ldf", LDBLogDestination, true);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}