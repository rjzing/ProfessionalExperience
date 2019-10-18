//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: migrated class into a single app for all database management systems
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================

namespace EnterData
{
    public class SmallClasses
    {
        //=======================================================================================================
        //Class for ADAM Modules
        //=======================================================================================================
        public class ADAMMods
        {
            public int TUID { get; set; }
            public string Dept { get; set; }
            public string ModName { get; set; }
            public string IPAddress { get; set; }
        }

        //=======================================================================================================
        //Class for QAD Printers
        //=======================================================================================================
        public class QADPrinter
        {
            public int TUID { get; set; }
            public string Dept { get; set; }
            public string PrinterName { get; set; }
        }

        //=======================================================================================================
        //Class for part weights
        //=======================================================================================================
        public class PartWeights
        {
            public int TUID { get; set; }
            public string Dept { get; set; }
            public int Operation { get; set; }
            public string PN { get; set; }
            public double Weight { get; set; }
            public string PartName { get; set; }
            public int StdPack { get; set; }
        }
    }
}