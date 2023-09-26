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
        //TODO: currently ID uses old method, nameDoB uses new overload method. test which works
        private void ButtonID_Click(object sender, EventArgs e)
        {
            //search SQL database based on ID number

            //SQL connection
            SqlConnection con = new SqlConnection(Utility.PatientsConnection);

            string patientID = SpatientID.Text;
            var PatientInfo = new Dictionary<string, string>();

            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Patients] WHERE ID = '{patientID}'", con);
                SqlDataReader reader = cmd.ExecuteReader(); //TODO: error coming from here rn

                // if sql command successful
                if (reader.RecordsAffected == -1)
                {
                    MessageBox.Show($"SQL command executed successfully\nRecords Affected: {reader.RecordsAffected}", "Information");
                }
                else
                {
                    MessageBox.Show($"Something went wrong with the SQL query\nRecords Affected: {reader.RecordsAffected}", "Information");
                }

                //making array of keys so, when populating PatientInfo dictionary, a loop can be used (indexing the list with the reader)
                string[] PatientKey = { "ID", "Title", "Surname", "Forename", "Pronouns", "Sex", "DoB", "Address", "Phone" };
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < PatientKey.Length - 1; i++)
                        {
                            if (reader.IsDBNull(i))
                            {
                                PatientInfo.Add(PatientKey[i], "n/a");
                            }
                            else
                            {
                                PatientInfo.Add(PatientKey[i], reader.GetString(i));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong with SQL data collection", "Error");
                }
                con.Close();
            }
            DataToDisplayForm(PatientInfo);
        }

        private void ButtonNameDoB_Click(object sender, EventArgs e)
        {
            //code here for search with name 
            //check all fields are valid
            //populate dictionary from utility method
            //pass dict to displayform
            string forename = Forenamefield.Text;
            string surname = surnamefield.Text; //TODO: update to correct names for these fields
            DateTime DoB = dobfield.Value;
            if(!string.IsNullOrEmpty(forename) & !string.IsNullOrEmpty(surname) & DoB != DateTime.Today)
            {
                //TODO: check this works
                var PatientInfo = new Dictionary<string, string>;
                PatientInfo = Utility.GetPatientInfo(forename, surname, DoB)
                if (PatientInfo is not null)
                {
                    DataToDisplayForm(PatientInfo);
                }
                else
                {
                    MessageBox.Show("dictionary null exception", "whatever that means ig"); //TODO: dont leave this, dumbass
                }
                
            }
            else
            {
                MessageBox.Show("Something went wrong\n", "error");
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
