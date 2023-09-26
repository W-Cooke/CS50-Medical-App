//Script for functions for use in other parts of the application
using CS50_Medical_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Globalization;

namespace CS50_Medical_App.Utilities
{
    public class Utility
    {
        public static string PatientsConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Will\\source\\repos\\CS50 Medical App\\CS50 Medical App\\Patients.mdf\";Integrated Security=True";


        SqlConnection con = new SqlConnection(PatientsConnection);

        public Dictionary<string, string> GetPatientDetails(string patientID)
        {
            var PatientInfo = new Dictionary<string, string>();
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Patients] WHERE ID LIKE '{patientID}'", con);
                SqlDataReader reader = cmd.ExecuteReader(); //FIXME: needs checking

                // if sql command successful
                if (reader.RecordsAffected == -1)
                {
                    MessageBox.Show($"SQL command executed successfully\nRecords Affected: {reader.RecordsAffected}", "Information");
                }
                else
                {
                    MessageBox.Show($"Something went wrong with the SQL query\nRecords Affected: {reader.RecordsAffected}", "Information");
                    return null;
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
                    return null;
                }
                con.Close();
            }
            return PatientInfo;

        }

        public Dictionary<string, string> GetPatientDetails(string forename, string surname, DateTime DoB)
        {
            string dateofbirth = DoB.ToString("dd MMMM yyyy");
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Patients] WHERE Forename = '{forename}' AND Surname = '{surname}' AND DoB = '{DoB}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                // if sql command successful
                if (reader.RecordsAffected == -1)
                {
                    MessageBox.Show($"SQL command executed successfully\nRecords Affected: {reader.RecordsAffected}", "Information");
                }
                else
                {
                    MessageBox.Show($"Something went wrong with the SQL query\nRecords Affected: {reader.RecordsAffected}", "Information");
                    return null;
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
                    return null;
                }
                con.Close();
            }
            return PatientInfo;
        }
    }

    //TODO:
    //lookup method with overload to handle patient ID lookup or name/dob lookup
    //return dictionary? boolean?
    /* PSEUDOCODE:
    public dictionary<string, string> GetPatientInfo(string patientID)
        code here for lookup (taken from lookup form)
        return dictionary<string, string>
    public dictionary<string, string> GetPatientInfo(string forename, string surname, DateTime DoB)
        code here similar to lookup
        convert datetime to string with same format as in SQL
        return dictionary<string, string>
    */

    /* CODE FOR LATER

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
            */
}