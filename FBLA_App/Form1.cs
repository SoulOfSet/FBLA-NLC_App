using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FBLA_App
{
    public partial class mainForm : Form
    {
        //On main form load
        public mainForm()
        {
            InitializeComponent();
            Form formRegPart = new registerParticipant();
            var updateFiles = new DataFileLoad();
            updateFiles.loadFiles();
            updateDataGrid();
            updateTreeView();
        }
        //REgister button click
        private void regPartButton_Click(object sender, EventArgs e)
        {
            //Open the Register Participant form
            Form formRegPart = new registerParticipant();
            formRegPart.Show();
            //Hide the main form so it's not usable
            this.Hide();
        }
        //View help file on_click()
        private void buttonViewHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("help.chm");
            }
            catch (Exception)
            {
                MessageBox.Show("Windows could not open the file");
            }
        }
        //Open add workshop tab
        private void buttonAddWkshp_Click(object sender, EventArgs e)
        {
            //Open the add workshop form
            Form formRegPart = new addWorkshop();
            formRegPart.Show();
            //Hide the main form so it's not usable
            this.Hide();
        }
        //On main form close kill the application
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Update the data grid
        public void updateDataGrid()
        {
            //Remove existing rows
            for (int i = 0; i < dataGridPart.Rows.Count - 1; i++)
            {
                dataGridPart.Rows.RemoveAt(i);
                i--;
                while (dataGridPart.Rows.Count == 0)
                    continue;
            }
            //For the columns
            int baseInt = 0;
            var dataVariables = new DataFileLoad();
            dataVariables.loadFiles();
            //Get number of lines
            string[] partIDLines = File.ReadAllLines(@"DATA\PARTICIPANTS.txt");
            int partID = partIDLines.Count();
            //Add the correct number of rows if participants exist
            if (partID >= 1)
            {
                dataGridPart.Rows.Add(partID);
            }
            //Time to update
            foreach (string[] e in dataVariables.aPartJag)
            {
                //Set data
                dataGridPart.Rows[baseInt].Cells[0].Value = e[0];
                dataGridPart.Rows[baseInt].Cells[1].Value = e[1];
                dataGridPart.Rows[baseInt].Cells[2].Value = e[2];
                dataGridPart.Rows[baseInt].Cells[3].Value = e[3];
                dataGridPart.Rows[baseInt].Cells[4].Value = e[4];
                dataGridPart.Rows[baseInt].Cells[5].Value = e[5];
                //Increase row int by 1
                baseInt = baseInt + 1;
            }
         
        }
        //update the tree view
        public void updateTreeView()
        {
            treeViewWkshp.BeginUpdate();
            //Create instance of DataFileLoad
            var instance = new DataFileLoad();
            instance.loadFiles();
            //Add parent nodes - Conference names
            foreach (string[] e in instance.aConfJag)
            {
                treeViewWkshp.BeginUpdate();
                //Add the conference
                treeViewWkshp.Nodes.Add(e[1], e[1]);
                treeViewWkshp.EndUpdate();
            }
            //Add child nodes - Workshops  
            string wkshpConf = "placeholder";
            foreach (string[] e in instance.aWorkJag)
            {
                foreach (string[] ex in instance.aConfJag)
                {
                    if (e[1].ToString() == ex[0])
                    {
                        wkshpConf = ex[1].ToString();
                        break;
                    }
                }
                treeViewWkshp.BeginUpdate();
                treeViewWkshp.Nodes[wkshpConf].Nodes.Add(e[2], e[2]);
                treeViewWkshp.EndUpdate();
            }
            //Add child nodes - Participants
            string partName = "";
            string confName = "";
            string workName = "";
            foreach (string[] e in instance.aWkshpJag)
            {
                foreach (string[] ex in instance.aPartJag)
                {
                    if (e[0] == ex[0])
                    {
                        partName = ex[1] + " " + ex[2];
                        confName = ex[4];
                        break;
                    }
                }
                foreach (string[] exr in instance.aWorkJag)
                {
                    if (e[1] == exr[0])
                    {
                        workName = exr[2];
                        
                    }
                }
                //Attempt to update Wkshp Nodes if data exists
                treeViewWkshp.BeginUpdate();
                try
                {
                    this.treeViewWkshp.Nodes[confName].Nodes[workName].Nodes.Add(partName);
                }
                catch (Exception)
                {
                   
                }
                treeViewWkshp.EndUpdate();
            }
        }

        private void dataGridPart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will generate a schedule for the selected participant. Proceed?", "Generate Schedule", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int iRowIndex = e.RowIndex;
                int iCellIndex = 0;
                //List to hold our row info
                List<string> rowInfo = new List<string>();
                //Six fields
                for (int i = 0; i < 6; i++)
                {
                    rowInfo.Add(dataGridPart.Rows[iRowIndex].Cells[iCellIndex].Value.ToString());
                    iCellIndex += 1;
                }
                string partID = rowInfo[0];
                string firstName = rowInfo[1];
                string lastName = rowInfo[2];
                string fullName = firstName + " " + lastName;
                string type = rowInfo[3];
                string conference = rowInfo[4];
                string chapNumber = rowInfo[5];
                //Generate a pdf from our information
                var pdfGen = new pdfGeneration();
                pdfGen.generatePDF(fullName, chapNumber, conference, type, partID);
                //Prompt to open schedule
                DialogResult dialogResult2 = MessageBox.Show("Generation complete. Schedule saved to the SCHEDULES folder. Would you like to open the schedule?", "Open PDF", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Attempt to open the pdf
                    try
                    {
                        Process.Start(@"SCHEDULES\" + fullName + "_" + chapNumber + ".pdf");
                    }
                    //If it fails
                    catch (Exception)
                    {
                        MessageBox.Show("We could not find a program to open the pdf. Try opening manually from the SCHEDULES folder");
                    }
                }
            } 
        }
        //On cell click highlight the whole row
        private void dataGridPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridPart.Rows[e.RowIndex].Selected = true;
        }
    }
}
