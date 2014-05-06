using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FBLA_App
{
    public class DataFileLoad
    {
        //Public File.ReadAllLine Variables
        public string[] aConferences = null;
        public string[] aParticipants = null;
        public string[] aType = null;
        public string[] aWkshpReg = null;
        public string[] aWorkshops = null;
        //Public jagged array variables
        public string[][] aConfJag = null;
        public string[][] aPartJag = null;
        public string[][] aTypeJag = null;
        public string[][] aWkshpJag = null;
        public string[][] aWorkJag = null;

        public void loadFiles()
        {
            //The path of our exectuable
            string exePath = Application.StartupPath;

            //Set our working directory to our exe path for file reading
            Directory.SetCurrentDirectory(exePath);

            //Load data into arrays
            try
            {
                aConferences = File.ReadAllLines(@"DATA\CONFERENCES.txt");
                aParticipants = File.ReadAllLines(@"DATA\PARTICIPANTS.txt");
                aType = File.ReadAllLines(@"DATA\TYPE.txt");
                aWkshpReg = File.ReadAllLines(@"DATA\WKSHP_REGISTRATIONS.txt");
                aWorkshops = File.ReadAllLines(@"DATA\WORKSHOPS.txt");
            }
            catch (Exception)
            {

            }

            //Make our arrays jagged for easier processing
            aConfJag  = aConferences.Select(line => line.Split(',').ToArray()).ToArray();
            aPartJag  = aParticipants.Select(line => line.Split(',').ToArray()).ToArray();
            aTypeJag  = aType.Select(line => line.Split(',').ToArray()).ToArray();
            aWkshpJag = aWkshpReg.Select(line => line.Split(',').ToArray()).ToArray();
            aWorkJag  = aWorkshops.Select(line => line.Split(',').ToArray()).ToArray();
               
        }

    }
}