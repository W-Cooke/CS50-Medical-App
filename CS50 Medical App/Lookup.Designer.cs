namespace CS50_Medical_App
{
    partial class Lookup
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
            this.SpatientID = new System.Windows.Forms.TextBox();
            this.Ssurname = new System.Windows.Forms.TextBox();
            this.Sforename = new System.Windows.Forms.TextBox();
            this.SDoB = new System.Windows.Forms.DateTimePicker();
            this.ButtonID = new System.Windows.Forms.Button();
            this.ButtonNameDoB = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // SpatientID
            // 
            this.SpatientID.Location = new System.Drawing.Point(15, 25);
            this.SpatientID.Name = "SpatientID";
            this.SpatientID.Size = new System.Drawing.Size(100, 20);
            this.SpatientID.TabIndex = 4;
            // 
            // Ssurname
            // 
            this.Ssurname.Location = new System.Drawing.Point(281, 25);
            this.Ssurname.Name = "Ssurname";
            this.Ssurname.Size = new System.Drawing.Size(100, 20);
            this.Ssurname.TabIndex = 5;
            // 
            // Sforename
            // 
            this.Sforename.Location = new System.Drawing.Point(175, 25);
            this.Sforename.Name = "Sforename";
            this.Sforename.Size = new System.Drawing.Size(100, 20);
            this.Sforename.TabIndex = 6;
            // 
            // SDoB
            // 
            this.SDoB.Location = new System.Drawing.Point(175, 66);
            this.SDoB.Name = "SDoB";
            this.SDoB.Size = new System.Drawing.Size(200, 20);
            this.SDoB.TabIndex = 7;
            // 
            // ButtonID
            // 
            this.ButtonID.Location = new System.Drawing.Point(15, 102);
            this.ButtonID.Name = "ButtonID";
            this.ButtonID.Size = new System.Drawing.Size(113, 23);
            this.ButtonID.TabIndex = 8;
            this.ButtonID.Text = "Search by Patient ID";
            this.ButtonID.UseVisualStyleBackColor = true;
            this.ButtonID.Click += new System.EventHandler(this.ButtonID_Click);
            // 
            // ButtonNameDoB
            // 
            this.ButtonNameDoB.Location = new System.Drawing.Point(175, 102);
            this.ButtonNameDoB.Name = "ButtonNameDoB";
            this.ButtonNameDoB.Size = new System.Drawing.Size(200, 23);
            this.ButtonNameDoB.TabIndex = 9;
            this.ButtonNameDoB.Text = "Search by Name/DoB";
            this.ButtonNameDoB.UseVisualStyleBackColor = true;
            this.ButtonNameDoB.Click += new System.EventHandler(this.ButtonNameDoB_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(104, 131);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(122, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 166);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.ButtonNameDoB);
            this.Controls.Add(this.ButtonID);
            this.Controls.Add(this.SDoB);
            this.Controls.Add(this.Sforename);
            this.Controls.Add(this.Ssurname);
            this.Controls.Add(this.SpatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lookup";
            this.Text = "Lookup A Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SpatientID;
        private System.Windows.Forms.TextBox Ssurname;
        private System.Windows.Forms.TextBox Sforename;
        private System.Windows.Forms.DateTimePicker SDoB;
        private System.Windows.Forms.Button ButtonID;
        private System.Windows.Forms.Button ButtonNameDoB;
        private System.Windows.Forms.Button BtnCancel;
    }
}