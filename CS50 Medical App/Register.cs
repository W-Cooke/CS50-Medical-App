using CS50_Medical_App.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS50_Medical_App
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //SQL connection
            SqlConnection con = new SqlConnection(Utility.PatientsConnection);

            //Information from Form
            string title = Ftitle.Text;
            string forename = Fforename.Text;
            string surname = Fsurname.Text;
            //TODO: - implement checker to make sure names begin with uppercase letters
            DateTime dateofbirth = Fdob.Value;
            string bday = dateofbirth.ToString("dd MMMM yyyy");
            string sex = Fsex.Text;
            string pronouns = Fpronouns.Text;
            string addnum = Faddnum.Text;
            string addline1 = Faddline1.Text;
            string addline2 = !String.IsNullOrEmpty(Faddline2.Text) ? Faddline2.Text : string.Empty;
            string county = Faddcounty.Text;
            string postcode = Faddpostcode.Text;
            string phonenum = Fphonenum.Text;

            string addinfo = ConsolidateAddress(addnum, addline1, addline2, county, postcode);

            int validationcheck = 0;
            int validator = 7;

            DateTime today = DateTime.Today;
            if (today.Date == dateofbirth.Date)
            {
                MessageBox.Show("Date of birth error", "Error");
            }
            else
            {
                validationcheck++;
            }
            //create list of tuples for each of the non-address related fields in the form
            List<(string field, string fieldName)> fields = new List<(string field, string fieldName)>
            {
                (forename, "Forename"),
                (surname, "Surname"),
                (title, "Title"),
                (sex, "Sex"),
                (phonenum, "Phone number"),
                (addinfo, "Address")
            };

            // iterate over each field, ensuring the form is filled.
            foreach (var (field, fieldName) in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    MessageBox.Show($"Error, missing or incomplete {fieldName}!"); //throw an error message with the corresponding empty field to the user
                    return; // exit the method if any field is empty
                }
                validationcheck++;
            }
            //if all validations have been passed, continue to generate patient ID then save information in SQL database
            if (validationcheck == validator)
            {
                string IDcheck = "";
                string patientID;
                do
                {
                    patientID = GetPatientID(dateofbirth);  //generate patient ID
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT ID FROM [dbo].[Patients] WHERE ID LIKE {patientID}", con); //check DB if ID already exists
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                IDcheck = reader.GetString(0);
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                while (patientID == IDcheck);
                //based on if the optional pronouns segment of the form has been filled, the insert statement will be slightly different
                string insertstatement;
                if (string.IsNullOrEmpty(pronouns))
                {
                    insertstatement = $"INSERT INTO [dbo].[Patients] (ID, title, forename, surname, sex, DoB, address, phone) VALUES ('{patientID}', '{title}', '{forename}', '{surname}', '{sex}', '{bday}', '{addinfo}', '{phonenum}')";
                }
                else
                {
                    insertstatement = $"INSERT INTO [dbo].[Patients] (ID, title, forename, surname, pronouns, sex, DoB, address, phone) VALUES ('{patientID}', '{title}', '{forename}', '{surname}', '{pronouns}', '{sex}', '{bday}', '{addinfo}', '{phonenum}')";
                }
                MessageBox.Show($"Patient ID: {patientID}\nPlease make a note of this", "Information");

                //SQL insert query
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertstatement, con);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected > 0)
                    {
                        MessageBox.Show("Patient registered successfully", "Success!");
                        //close registration window
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register patient", "Something went wrong!");
                    }
                    con.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else
            {
                MessageBox.Show($"Incomplete form\nValdiation check: {validationcheck}", "Information");
            }
        }
        //method to generate patient ID based on birth date and 4 random digits
        private string GetPatientID(DateTime date)
        {
            string IDpart1 = date.ToString("ddMMyy");
            Random random = new Random();
            int number = random.Next(1000, 10000);
            string IDpart2 = number.ToString();
            return IDpart1 + IDpart2;
        }
        //method to consolidate address into one, commma separated string
        private string ConsolidateAddress(string num, string addline1, string addline2, string county, string postcode)
        {
            List<(string field, string fieldName)> addresslines = new List<(string field, string fieldName)>
        {
            (num, "Address Name/Number"),
            (addline1, "Address line 1"),
            (county, "County"),
            (postcode, "Postcode"),
        };
            foreach (var (field, fieldName) in addresslines)
            {
                if (string.IsNullOrEmpty(field))
                {
                    MessageBox.Show($"Error, {fieldName} error!", "error"); //throw an error message with the corresponding empty field to the user
                    return ""; // returns empty if any necessary lines are empty
                }
            }

            if (string.IsNullOrEmpty(addline2))
            {
                return num + " " + addline1 + ", " + county + ", " + postcode;
            }
            else
            {
                return num + " " + addline1 + ", " + addline2 + ", " + county + ", " + postcode;
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
