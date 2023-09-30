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

        public static Dictionary<string, string> GetPatientDetails(string patientID)
        {
            var PatientInfo = new Dictionary<string, string>();
            SqlConnection con = new SqlConnection(PatientsConnection);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Patients] WHERE ID LIKE '{patientID}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                // if sql command successful
                // TODO: remove before finishing
                if (reader.RecordsAffected != -1)
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
                        for (int i = 0; i < PatientKey.Length; i++)
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

        public static string VerifyPatientID(string PatientID)
        {
            //lookup ID number, return ID number if valid, return null if not
            SqlConnection con = new SqlConnection(PatientsConnection);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID FROM [dbo].[Patients] WHERE ID = '{PatientID}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.RecordsAffected == -1)
                {
                    con.Close();
                    return PatientID;
                }
                else
                {
                    MessageBox.Show("SQL Command went wrong. couldn't look up from Patient ID.\nAre you sure this is correct?", "Error!");
                    con.Close();
                    return null;
                }
            }
        }
        public static string VerifyPatientID(string forename, string surname, DateTime DoB)
        {
            string dateofbirth = DoB.ToString("dd MMMM yyyy");
            string PatientID;
            SqlConnection con = new SqlConnection(PatientsConnection);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID FROM [dbo].[Patients] WHERE Forename = '{forename}' AND Surname = '{surname}' AND DoB = '{dateofbirth}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                // if sql command successful
                if (reader.RecordsAffected == -1)
                {
                    reader.Read();
                    string vsCount = reader.VisibleFieldCount.ToString();
                    PatientID = reader.GetString(0);
                    con.Close();
                    return PatientID;

                }
                else
                {
                    MessageBox.Show($"Something went wrong with the SQL query", "Information");
                    con.Close();
                    return null;
                }
            }
        }

        public static bool DeletePatient(string PatientID)
        {
            SqlConnection con = new SqlConnection(PatientsConnection);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM [dbo].[Patients] WHERE ID = '{PatientID}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.RecordsAffected == 1)
                {
                    MessageBox.Show("Patient Records Deleted", "Delete Confirmed");
                    con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("SQL Command went wrong. couldn't look up from Patient ID. Are you sure this is correct?", "Error!");
                    con.Close();
                    return false;
                }
            }
        }
    }
}