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
        public static string PatientsConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Will\\source\\repos\\CS50 Medical App\\CS50 Medical App\\Patients.mdf";
    }
}