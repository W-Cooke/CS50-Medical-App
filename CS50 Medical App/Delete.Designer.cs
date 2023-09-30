namespace CS50_Medical_App
{
    partial class Delete
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DButtonNameDoB = new System.Windows.Forms.Button();
            this.DButtonID = new System.Windows.Forms.Button();
            this.DDoB = new System.Windows.Forms.DateTimePicker();
            this.Dforename = new System.Windows.Forms.TextBox();
            this.Dsurname = new System.Windows.Forms.TextBox();
            this.DpatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(104, 131);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(122, 23);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DButtonNameDoB
            // 
            this.DButtonNameDoB.Location = new System.Drawing.Point(175, 102);
            this.DButtonNameDoB.Name = "DButtonNameDoB";
            this.DButtonNameDoB.Size = new System.Drawing.Size(200, 23);
            this.DButtonNameDoB.TabIndex = 20;
            this.DButtonNameDoB.Text = "Delete by Name/DoB";
            this.DButtonNameDoB.UseVisualStyleBackColor = true;
            this.DButtonNameDoB.Click += new System.EventHandler(this.DButtonNameDoB_Click);
            // 
            // DButtonID
            // 
            this.DButtonID.Location = new System.Drawing.Point(15, 102);
            this.DButtonID.Name = "DButtonID";
            this.DButtonID.Size = new System.Drawing.Size(113, 23);
            this.DButtonID.TabIndex = 19;
            this.DButtonID.Text = "Delete by Patient ID";
            this.DButtonID.UseVisualStyleBackColor = true;
            this.DButtonID.Click += new System.EventHandler(this.DButtonID_Click);
            // 
            // DDoB
            // 
            this.DDoB.Location = new System.Drawing.Point(175, 66);
            this.DDoB.Name = "DDoB";
            this.DDoB.Size = new System.Drawing.Size(200, 20);
            this.DDoB.TabIndex = 18;
            // 
            // Dforename
            // 
            this.Dforename.Location = new System.Drawing.Point(175, 25);
            this.Dforename.Name = "Dforename";
            this.Dforename.Size = new System.Drawing.Size(100, 20);
            this.Dforename.TabIndex = 17;
            // 
            // Dsurname
            // 
            this.Dsurname.Location = new System.Drawing.Point(281, 25);
            this.Dsurname.Name = "Dsurname";
            this.Dsurname.Size = new System.Drawing.Size(100, 20);
            this.Dsurname.TabIndex = 16;
            // 
            // DpatientID
            // 
            this.DpatientID.Location = new System.Drawing.Point(15, 25);
            this.DpatientID.Name = "DpatientID";
            this.DpatientID.Size = new System.Drawing.Size(100, 20);
            this.DpatientID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient ID";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 163);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DButtonNameDoB);
            this.Controls.Add(this.DButtonID);
            this.Controls.Add(this.DDoB);
            this.Controls.Add(this.Dforename);
            this.Controls.Add(this.Dsurname);
            this.Controls.Add(this.DpatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button DButtonNameDoB;
        private System.Windows.Forms.Button DButtonID;
        private System.Windows.Forms.DateTimePicker DDoB;
        private System.Windows.Forms.TextBox Dforename;
        private System.Windows.Forms.TextBox Dsurname;
        private System.Windows.Forms.TextBox DpatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}