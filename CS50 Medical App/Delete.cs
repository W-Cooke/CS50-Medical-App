using CS50_Medical_App.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS50_Medical_App
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void DButtonID_Click(object sender, EventArgs e)
        {
            string PatientInfo = Utility.VerifyPatientID(DpatientID.Text);
            if (PatientInfo != null)
            {
                DataToDelete(PatientInfo);
            }
            else
            {
                MessageBox.Show("Please enter a valid patient ID\nOr search via Name and Date of Birth", "Error!");
            }
        }

        private void DButtonNameDoB_Click(object sender, EventArgs e)
        {
            string forename = Dforename.Text;
            string surname = Dsurname.Text;
            DateTime DoB = DDoB.Value;
            if (!string.IsNullOrEmpty(forename) & !string.IsNullOrEmpty(surname) & DoB.Date != DateTime.Today)
            {
                string PatientInfo = Utility.VerifyPatientID(forename, surname, DoB);
                if (PatientInfo != null)
                {
                    DataToDelete(PatientInfo);
                }
                else
                {
                    MessageBox.Show("Please enter forename, surname and date of birth", "Empty field");
                }
            }
        }

        //method for passing data to delete confirmation form
        public void DataToDelete(string ID)
        {
            DeleteConfirm deleteconfirm = new DeleteConfirm(ID);
            deleteconfirm.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
