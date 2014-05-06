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
    public partial class registerParticipant : Form
    {
        //On form load
        public registerParticipant()
        {
            InitializeComponent();
            //Allow multiple items to be selected in the list box
            listWorkshops.SelectionMode = SelectionMode.MultiSimple;
            //Change combo boxes to dropdown list
            comboConference.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update the form data to match text files
            updateFormData();
        }
        //Someone has pressed a key in the chapter number field
        private void textChapNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numbers and backspaces
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Please enter a numerical value");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //Checkbox has been changed
        private void checkBoxWkshpReg_CheckedChanged(object sender, EventArgs e)
        {
            //If the check box state has been changed
            if (checkBoxWkshpReg.Checked)
            {
                listWorkshops.Enabled = true;
            }
            else
            {
                listWorkshops.Enabled = false;
            }
        }
        //Internal function. Change form data to reflect array data
        public void updateFormData()
        {
            //Create a new instance of our class
            var data = new DataFileLoad();
            //Load text file data to insure accuracy
            data.loadFiles();

            //Update combo box for types
            foreach(string[] e in data.aTypeJag)
            {
                comboType.Items.Add(e[1]);
            }

            //Update combo box for conferences
            foreach (string[] e in data.aConfJag)
            {
                comboConference.Items.Add(e[1]);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            /*Make sure our form is filled completely*/
            //Check First Name Text Box
            if (String.IsNullOrWhiteSpace(textFirstName.Text))
            {
                MessageBox.Show("Please enter a first name");
            }
            //Check last name
            else if (String.IsNullOrWhiteSpace(textLastName.Text))
            {
                MessageBox.Show("Please enter a last name");
            }
            //Check participant type listbox
            else if (String.IsNullOrWhiteSpace(comboType.Text))
            {
                MessageBox.Show("Please select a participant type");
            }
            //Check conference listbox
            else if (String.IsNullOrWhiteSpace(comboConference.Text))
            {
                MessageBox.Show("Please select a conference");
            }
            //Check chapter number listbox
            else if (String.IsNullOrWhiteSpace(textChapNum.Text))
            {
                MessageBox.Show("Please add a chapter number");
            }
            //If adding workshops is enables make sure at least one is selected
            else if ((listWorkshops.SelectedItems.Count == 0) && checkBoxWkshpReg.Checked)
            {
                MessageBox.Show("Please select one or more workshop or de-select the add workshop checkbox");
            }
            /*End form checking*/

            /*Write data to file(s) - PARTICIPANTS.txt*/
            else
            {
                //Organize into readable variables
                string firstName = textFirstName.Text;
                string lastName = textLastName.Text;
                string partType = comboType.Text;
                string confAtnd = comboConference.Text;
                string chapNum = textChapNum.Text;
                //Count lines so we know how to assign our participant id
                string[] partIDLines = File.ReadAllLines(@"DATA\PARTICIPANTS.txt");
                int partID = partIDLines.Count();
                //The path of our exectuable
                string exePath = Application.StartupPath;
                //Set our working directory to our exe path for file reading
                Directory.SetCurrentDirectory(exePath);
                //Set up our string to write
                string toWritePart = partID + "," + firstName + "," + lastName + "," + partType + "," + confAtnd + "," + chapNum + "\n";
                //Append file with our data
                File.AppendAllText(@"DATA\PARTICIPANTS.txt", toWritePart);

                /*WKSHP_REGISTRATIONS.txt*/
                if (checkBoxWkshpReg.Checked)
                {
                    string sPartID = partID.ToString();
                    foreach (string listElement in listWorkshops.SelectedItems)
                    {
                        string[] wkshpIDLines = File.ReadAllLines(@"DATA\WKSHP_REGISTRATIONS.txt");
                        var data = new DataFileLoad();
                        data.loadFiles();
                        string wkshpConfCode = null;
                        string wkshpID = null;
                        //Derive workshop code from selected
                        foreach (string[] conf in data.aConfJag)
                        {
                            if (conf[1].ToString() == comboConference.Text)
                            {
                                wkshpConfCode = conf[0].ToString();
                                break;
                            }
                        }
                        //Derive the workshop ID
                        foreach (string[] select in data.aWorkJag)
                        {
                            if (select[1] == wkshpConfCode && listElement == select[2])
                            {
                                wkshpID = select[0];
                            }
                        }
                        //Write string (participant id + workshop id)
                        string toWriteWkshp = sPartID + "," + wkshpID + "\n";
                        File.AppendAllText(@"DATA\WKSHP_REGISTRATIONS.txt", toWriteWkshp);
                    }
                }
                //Lets go ahead and update our array elements
                var updateInstance = new DataFileLoad();
                updateInstance.loadFiles();
                //Hide current form
                this.Close();
            }

        }
        //On form close
        private void registerParticipant_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new mainForm();
            mainForm.Show();
        }
        //Conference combo box selection change
        private void comboConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear list
            listWorkshops.Items.Clear();
            //String to hold conference code
            string wkshpConfCode = null;
            //Array to add matching values to
            List<string> toAddList = new List<string>();
            //Create a new instance of our class
            var data = new DataFileLoad();
            //Load text file data to insure accuracy
            data.loadFiles();
            //Derive conference code from combobox selection
            foreach (string[] conf in data.aConfJag)
            {
                if (conf[1].ToString() == comboConference.Text)
                {
                    wkshpConfCode = conf[0].ToString();
                    break;
                }
            }
            //Detect if there are matching workshops in this conference
            foreach (string[] workshops in data.aWorkJag)
            {
                if (Convert.ToString(workshops[1]) == wkshpConfCode)
                {
                    toAddList.Add(workshops[2].ToString());
                }
            }
            //Convert our list to an array
            string[] toAddArray = toAddList.ToArray();
            //Update available workshops
            foreach (string element in toAddArray)
            {
                listWorkshops.Items.Add(element);
            }
            
        }

        
        
    }
}
