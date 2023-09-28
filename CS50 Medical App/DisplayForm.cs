using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS50_Medical_App
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(Dictionary<string, string> dict)
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> PatientInfo = (Dictionary<string, string>)sender; //TODO: throws error, cannot convert object to dictionary
            //list of keys
            string[] PatientKey = { "ID", "Title", "Surname", "Forename", "Pronouns", "Sex", "DoB", "Address", "Phone" }; //TODO: do i need this?
            
            string patientID = PatientInfo["ID"];
            string patientName = PatientInfo["Title"] + ". " + PatientInfo["Forename"] + " " + PatientInfo["Surname"];
            string dateOfBirth = PatientInfo["DoB"];
            string patientSex = PatientInfo["Sex"];
            string pronouns = PatientInfo["Pronouns"];
            string contactInfo = PatientInfo["Adress"] + "\nPhone: " + PatientInfo["Phone"];
            

            
        }
    }
}
