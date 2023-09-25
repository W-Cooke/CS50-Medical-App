using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CS50_Medical_App
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Fforename = new System.Windows.Forms.TextBox();
            this.Fsurname = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Ftitle = new System.Windows.Forms.ComboBox();
            this.Fdob = new System.Windows.Forms.DateTimePicker();
            this.Fsex = new System.Windows.Forms.ComboBox();
            this.Fpronouns = new System.Windows.Forms.TextBox();
            this.Faddline1 = new System.Windows.Forms.TextBox();
            this.Faddline2 = new System.Windows.Forms.TextBox();
            this.Faddcounty = new System.Windows.Forms.TextBox();
            this.Faddpostcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Fphonenum = new System.Windows.Forms.TextBox();
            this.Faddnum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pronouns (Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Postcode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number";
            // 
            // Fforename
            // 
            this.Fforename.Location = new System.Drawing.Point(71, 23);
            this.Fforename.Name = "Fforename";
            this.Fforename.Size = new System.Drawing.Size(86, 20);
            this.Fforename.TabIndex = 9;
            // 
            // Fsurname
            // 
            this.Fsurname.Location = new System.Drawing.Point(162, 23);
            this.Fsurname.Name = "Fsurname";
            this.Fsurname.Size = new System.Drawing.Size(86, 20);
            this.Fsurname.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(201, 246);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 20);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(270, 246);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(64, 20);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // Ftitle
            // 
            this.Ftitle.FormattingEnabled = true;
            this.Ftitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Dr.",
            "Professor",
            "Rev.",
            "Hon.",
            "Capt.",
            "Sgt."});
            this.Ftitle.Location = new System.Drawing.Point(10, 23);
            this.Ftitle.Name = "Ftitle";
            this.Ftitle.Size = new System.Drawing.Size(56, 21);
            this.Ftitle.TabIndex = 13;
            // 
            // Fdob
            // 
            this.Fdob.Location = new System.Drawing.Point(10, 62);
            this.Fdob.Name = "Fdob";
            this.Fdob.Size = new System.Drawing.Size(163, 20);
            this.Fdob.TabIndex = 14;
            // 
            // Fsex
            // 
            this.Fsex.FormattingEnabled = true;
            this.Fsex.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Intersex",
            "Meat Popsicle"});
            this.Fsex.Location = new System.Drawing.Point(178, 62);
            this.Fsex.Name = "Fsex";
            this.Fsex.Size = new System.Drawing.Size(56, 21);
            this.Fsex.TabIndex = 15;
            // 
            // Fpronouns
            // 
            this.Fpronouns.Location = new System.Drawing.Point(239, 62);
            this.Fpronouns.Name = "Fpronouns";
            this.Fpronouns.Size = new System.Drawing.Size(99, 20);
            this.Fpronouns.TabIndex = 16;
            // 
            // Faddline1
            // 
            this.Faddline1.Location = new System.Drawing.Point(9, 152);
            this.Faddline1.Name = "Faddline1";
            this.Faddline1.Size = new System.Drawing.Size(167, 20);
            this.Faddline1.TabIndex = 17;
            // 
            // Faddline2
            // 
            this.Faddline2.Location = new System.Drawing.Point(9, 177);
            this.Faddline2.Name = "Faddline2";
            this.Faddline2.Size = new System.Drawing.Size(167, 20);
            this.Faddline2.TabIndex = 18;
            // 
            // Faddcounty
            // 
            this.Faddcounty.Location = new System.Drawing.Point(7, 221);
            this.Faddcounty.Name = "Faddcounty";
            this.Faddcounty.Size = new System.Drawing.Size(99, 20);
            this.Faddcounty.TabIndex = 19;
            // 
            // Faddpostcode
            // 
            this.Faddpostcode.Location = new System.Drawing.Point(111, 221);
            this.Faddpostcode.Name = "Faddpostcode";
            this.Faddpostcode.Size = new System.Drawing.Size(63, 20);
            this.Faddpostcode.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "County";
            // 
            // Fphonenum
            // 
            this.Fphonenum.Location = new System.Drawing.Point(178, 221);
            this.Fphonenum.Name = "Fphonenum";
            this.Fphonenum.Size = new System.Drawing.Size(108, 20);
            this.Fphonenum.TabIndex = 22;
            // 
            // Faddnum
            // 
            this.Faddnum.Location = new System.Drawing.Point(9, 114);
            this.Faddnum.Name = "Faddnum";
            this.Faddnum.Size = new System.Drawing.Size(86, 20);
            this.Faddnum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name / Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Street Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 276);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Faddnum);
            this.Controls.Add(this.Fphonenum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Faddpostcode);
            this.Controls.Add(this.Faddcounty);
            this.Controls.Add(this.Faddline2);
            this.Controls.Add(this.Faddline1);
            this.Controls.Add(this.Fpronouns);
            this.Controls.Add(this.Fsex);
            this.Controls.Add(this.Fdob);
            this.Controls.Add(this.Ftitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Fsurname);
            this.Controls.Add(this.Fforename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Fforename;
        private TextBox Fsurname;
        private Button BtnSave;
        private Button BtnCancel;
        private ComboBox Ftitle;
        private DateTimePicker Fdob;
        private ComboBox Fsex;
        private TextBox Fpronouns;
        private TextBox Faddline1;
        private TextBox Faddline2;
        private TextBox Faddcounty;
        private TextBox Faddpostcode;
        private Label label10;
        private TextBox Fphonenum;
        private TextBox Faddnum;
        private Label label11;
        private Label label12;
    }
}