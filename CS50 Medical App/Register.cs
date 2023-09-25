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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
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
            string addline2 = !String.IsNullOrEmpty(Faddline2.Text) ? Faddline2.Text : "";
            string county = Faddcounty.Text;
            string postcode = Faddpostcode.Text;
            string phonenum = Fphonenum.Text;

            string addinfo = ConsolidateAddress(addnum, addline1, addline2, county, postcode);
            //TODO: add checker for patient ID to ensure no duplicates can occur
            string PatientID = GetPatientID(dateofbirth);

            int validationcheck = 0;
            int validator = 0;

            DateTime today = DateTime.Today;
            if (today.Date == dateofbirth.Date)
            {
                MessageBox.Show("Date of birth error", "Error");
            }
            else
            {
                validationcheck++;
            }

            //at the end
            if (validationcheck == validator)
            {
                //Code here to finish
            }
            else
            {
                MessageBox.Show("Something went wrong", "Oopsie Doopsie!");
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            (num, "Phone number"),
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
    }
}
