using CS50_Medical_App.Utilities;
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
    public partial class DeleteConfirm : Form
    {
        public string PatientID;
        public DeleteConfirm(string ID)
        {
            InitializeComponent();
            this.PatientID = ID;
        }

        private void DeleteConfirm_Load(object sender, EventArgs e)
        {
            var PatientInfo = Utility.GetPatientDetails(PatientID);
            string name = PatientInfo["Title"] + ". " + PatientInfo["Forename"] + " " + PatientInfo["Surname"];
            DeleteWho.Text = $"Do you want to delete\n{name}\npermanently?\nThis action cannot be undone.";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string deleteverify = DeleteVerify.Text;
            if (deleteverify == "DELETE")
            {
                if (Utility.DeletePatient(PatientID))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not finish deletion process", "Deletion Error");
                }
            }
            else
            {
                MessageBox.Show("Confirmation not successful\nPatient will not be deleted", "Confirmation failure");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
