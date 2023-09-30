using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS50_Medical_App.Utilities;

namespace CS50_Medical_App
{
    public partial class DisplayForm : Form
    {
        private string PatientID;
        
        public DisplayForm(string data)
        {
            InitializeComponent();
            this.PatientID = data;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

            var PatientInfo = Utility.GetPatientDetails(PatientID);
            if (PatientInfo != null)
            {
                NameField.Text = PatientInfo["Title"] + ". " + PatientInfo["Forename"] + " " + PatientInfo["Surname"];
                DoBField.Text = PatientInfo["DoB"];
                SexField.Text = PatientInfo["Sex"];
                PronounsField.Text = PatientInfo["Pronouns"];
                ContactField.Text = PatientInfo["Address"];
                PhoneField.Text = PatientInfo["Phone"];
            }
            else
            {
                this.Close();
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
