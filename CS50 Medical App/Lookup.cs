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

        private void ButtonID_Click(object sender, EventArgs e)
        {
            //search SQL database based on ID number
            string patientID = SpatientID.Text;
            if (!string.IsNullOrEmpty(patientID))
            {
                var PatientInfo = Utility.VerifyPatientID(patientID);
                if (PatientInfo != null)
                {
                    DataToDisplayForm(PatientInfo);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid patient ID", "Empty Field");
            }
        }

        private void ButtonNameDoB_Click(object sender, EventArgs e)
        {
            //use name and date of birth for lookup
            string forename = Sforename.Text;
            string surname = Ssurname.Text;
            DateTime DoB = SDoB.Value;
            if(!string.IsNullOrEmpty(forename) & !string.IsNullOrEmpty(surname) & DoB.Date != DateTime.Today)
            {
                string PatientInfo = Utility.VerifyPatientID(forename, surname, DoB);
                if (PatientInfo != null)
                {
                    DataToDisplayForm(PatientInfo);
                }
            }
            else
            {
                MessageBox.Show("Please enter forename, surname and date of birth", "Empty field");
            }

        }

        //method for opening displayform with patient ID as argument
        private void DataToDisplayForm(string data)
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
