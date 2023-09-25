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

            //SQL connection
            SqlConnection con = new SqlConnection(Utility.PatientsConnection);

            string patientID = SpatientID.Text;
            var PatientInfo = new Dictionary<string, string>();

            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Patients] WHERE ID LIKE '{patientID}'", con);
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
        }

        private void ButtonNameDoB_Click(object sender, EventArgs e)
        {
            //code here for search with name TODO:
        }


        //method for opening displayform with dictionary of information as argument
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
