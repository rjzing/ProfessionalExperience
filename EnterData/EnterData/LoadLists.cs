//=======================================================================================================
//Written by: Robert Zinger
//Last modified: 4/15/19
//Last modification made: Implemented class
//Modified by: Robert Zinger
//Comments last updated: 4/22/19
//=======================================================================================================
using System;              
using System.Data;

namespace EnterData
{
    public class LoadLists
    {
        //========================================================================================================
        //This method takes the rows returned from the stored procs, when it is a "get" function and loads it into
        //  the PartWeights list. I put this method here because I originally had it in three different spots in
        //  the DatabaseFunction.cs file. Since the database allows nulls in the standard pack field, the program
        //  would break if there was a null value since null cannot be converted into an integer. So I had to add
        //  extra logic for that.
        //========================================================================================================
        public static void LoadWeightsList(DataRowCollection CurrentRows)
        {
            string tempSTDPack;
            foreach (DataRow row in CurrentRows)
            {
                tempSTDPack = row.ItemArray[6].ToString();
                if (tempSTDPack != "")
                {
                    var tempSTDWeight = new SmallClasses.PartWeights()
                    {
                        Dept = row.ItemArray[0].ToString(),
                        Operation = Convert.ToInt16(row.ItemArray[1]),
                        PN = row.ItemArray[2].ToString(),
                        Weight = Convert.ToDouble(row.ItemArray[3]),
                        TUID = Convert.ToInt32(row.ItemArray[4]),
                        PartName = row.ItemArray[5].ToString(),
                        StdPack = Convert.ToInt16(tempSTDPack)
                    };
                    Program.PartWeights.Add(tempSTDWeight);
                }
                else
                {
                    var tempWeight = new SmallClasses.PartWeights()
                    {
                        Dept = row.ItemArray[0].ToString(),
                        Operation = Convert.ToInt16(row.ItemArray[1]),
                        PN = row.ItemArray[2].ToString(),
                        Weight = Convert.ToDouble(row.ItemArray[3]),
                        TUID = Convert.ToInt32(row.ItemArray[4]),
                        PartName = row.ItemArray[5].ToString(),
                        StdPack = 0
                    };
                    Program.PartWeights.Add(tempWeight);
                }
            }
        }

        //========================================================================================================
        //This method takes the rows returned from the stored procs, when it is a "get" function and loads it into
        //  the modules list. I put this method here because I originally had it in three different spots in
        //  the DatabaseFunction.cs file. 
        //========================================================================================================
        public static void LoadADAMList(DataRowCollection CurrentRows)
        {
            foreach (DataRow row in CurrentRows)
            {
                var tempMod = new SmallClasses.ADAMMods()
                {
                    TUID = Convert.ToInt32(row.ItemArray[0]),
                    Dept = row.ItemArray[1].ToString(),
                    ModName = row.ItemArray[2].ToString(),
                    IPAddress = row.ItemArray[3].ToString()
                };
                Program.ADAMMods.Add(tempMod);
            }
        }
        //========================================================================================================
        //This method takes the rows returned from the stored procs, when it is a "get" function and loads it into
        //  the Printers list. I put this method here because I originally had it in three different spots in
        //  the DatabaseFunction.cs file. 
        //========================================================================================================
        public static void LoadQADList(DataRowCollection CurrentRows)
        {
            foreach (DataRow row in CurrentRows)
            {
                var tempPrinter = new SmallClasses.QADPrinter()
                {
                    TUID = Convert.ToInt32(row.ItemArray[0]),
                    Dept = row.ItemArray[1].ToString(),
                    PrinterName = row.ItemArray[2].ToString()
                };
                Program.QADPrinters.Add(tempPrinter);
            }
        }
    }
}
