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
            var PatientInfo = dict;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
