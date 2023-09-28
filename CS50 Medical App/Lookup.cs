using CS50_Medical_App.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS50_Medical_App
{
    public partial class Lookup : Form
    {
        public Lookup()
        {
            InitializeComponent();
        }
        //TODO: change how lookup works so that patient ID is the only thing passed through to display form, then looked up *IN* display form
        //TODO: then displayform performs lookup function itself
        //TODO: use same strategy for Delete form
        private void ButtonID_Click(object sender, EventArgs e)
        {
            //search SQL database based on ID number
            string patientID = SpatientID.Text;
            if (!string.IsNullOrEmpty(patientID))
            {
                var PatientInfo = Utility.GetPatientDetails(patientID);
                if (PatientInfo != null)
                {
                    DataToDisplayForm(PatientInfo);
                }
                else
                {
                    MessageBox.Show("Dictionary is empty\nSQL entry not found", "Error"); //TODO: make this more specific
                }
            }
            else
            {
                MessageBox.Show("Please enter valid patient ID", "Empty Field");
            }
        }

        private void ButtonNameDoB_Click(object sender, EventArgs e)
        {
            string forename = Sforename.Text;
            string surname = Ssurname.Text;
            DateTime DoB = SDoB.Value;
            if(!string.IsNullOrEmpty(forename) & !string.IsNullOrEmpty(surname) & DoB != DateTime.Today)
            {
                //TODO: check this works
                var PatientInfo = Utility.GetPatientDetails(forename, surname, DoB);
                if (PatientInfo != null)
                {
                    DataToDisplayForm(PatientInfo);
                }
                else
                {
                    MessageBox.Show("Dictionary is empty\nSQL entry not found", "Error"); //TODO: dont leave this, dumbass
                }
                
            }
            else
            {
                MessageBox.Show("Please enter forename, surname and date of birth", "Empty field");
            }

        }


        //method for opening displayform with dictionary as argument
        private void DataToDisplayForm(Dictionary<string, string> data)
        {
            DisplayForm displayform = new DisplayForm(data);
            displayform.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
