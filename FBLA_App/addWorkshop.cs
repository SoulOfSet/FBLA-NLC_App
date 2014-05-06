using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FBLA_App
{
    public partial class addWorkshop : Form
    {
        //On form load run update form data method
        public addWorkshop()
        {
            InitializeComponent();
            updateFormData();
        }
        //Form data reflect jagged arrays
        public void updateFormData()
        {
            //Create a new instance of our class
            var data = new DataFileLoad();
            //Load text file data to insure accuracy
            data.loadFiles();

            //Update combo box for types
            foreach (string[] e in data.aConfJag)
            {
                comboWkshpConf.Items.Add(e[1]);
            }
        }
        //Text enter in day field
        private void textDateD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numbers and backspaces
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //Text enter in Month field
        private void textM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numbers and backspaces
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //Close form and open main form
        private void addWorkshop_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formLoad = new mainForm();
            formLoad.Show();
        }
        //On button add click fill forms
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*Make sure the form is filled completely*/
            if (String.IsNullOrWhiteSpace(textWkshpName.Text))
            {
                MessageBox.Show("Please enter a workshop name");
            }
            else if (String.IsNullOrWhiteSpace(textWkshpDesc.Text))
            {
                MessageBox.Show("Please enter a workshop description");
            }
            else if (String.IsNullOrWhiteSpace(comboWkshpConf.Text))
            {
                MessageBox.Show("Please select a workshop");
            }
            else if (String.IsNullOrWhiteSpace(textDateD.Text))
            {
                MessageBox.Show("Please enter a day");
            }
            else if (String.IsNullOrWhiteSpace(textDateM.Text))
            {
                MessageBox.Show("Please enter a month");
            }
            else if (String.IsNullOrWhiteSpace(textStartTime1.Text))
            {
                MessageBox.Show("Please fill time fields");
            }
            else if (String.IsNullOrWhiteSpace(textStartTime2.Text))
            {
                MessageBox.Show("Please fill time fields");
            }
            else if (String.IsNullOrWhiteSpace(comboAMPM.Text))
            {
                MessageBox.Show("Please choose AM or PM");
            }
            /*End Form Checking*/

            /*Write data to file(s) - WORKSHOPS.txt*/
            else
            {
                //Organize data into readable variables
                string wkshpName = textWkshpName.Text;
                string wkshpDesc = textWkshpDesc.Text;
                string wkshpDate = textDateD.Text + "/" + textDateM.Text;
                string wkshpTime = textStartTime1.Text + ":" + textStartTime2.Text + comboAMPM.Text;
                string wkshpConf = null;
                //Workshop code derived from number of lines
                string[] wkshpIDLines = File.ReadAllLines(@"DATA\WORKSHOPS.txt");
                int wkshpID = wkshpIDLines.Count();
                //Derive conference code from the string
                var data = new DataFileLoad();
                data.loadFiles();
                foreach (string[] conf in data.aConfJag)
                {
                    if (conf[1].ToString() == comboWkshpConf.Text)
                    {
                        wkshpConf = conf[0].ToString();
                        break;
                    }
                }
                //The path of our exectuable
                string exePath = Application.StartupPath;
                //Set our working directory to our exe path for file reading
                Directory.SetCurrentDirectory(exePath);
                //Compose string to write from variables
                string toWriteWkshp = wkshpID + "," + wkshpConf + "," + wkshpName + "," + wkshpDesc + "," + wkshpDate + "," + wkshpTime + "\n";
                //Append file with our data
                File.AppendAllText(@"DATA\WORKSHOPS.txt", toWriteWkshp);
                //Lets go ahead and update our array elements
                var updateInstance = new DataFileLoad();
                updateInstance.loadFiles();
                //Hide current form
                this.Close();
            }    
        }
    }
}
