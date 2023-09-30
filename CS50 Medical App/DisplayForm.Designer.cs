namespace CS50_Medical_App
{
    partial class DisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.Label();
            this.DoBField = new System.Windows.Forms.Label();
            this.ContactField = new System.Windows.Forms.Label();
            this.SexField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PronounsField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PhoneField = new System.Windows.Forms.Label();
            this.PhoneFieldlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // NameField
            // 
            this.NameField.AutoSize = true;
            this.NameField.Location = new System.Drawing.Point(12, 25);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(57, 13);
            this.NameField.TabIndex = 3;
            this.NameField.Text = "NameField";
            // 
            // DoBField
            // 
            this.DoBField.AutoSize = true;
            this.DoBField.Location = new System.Drawing.Point(13, 68);
            this.DoBField.Name = "DoBField";
            this.DoBField.Size = new System.Drawing.Size(50, 13);
            this.DoBField.TabIndex = 4;
            this.DoBField.Text = "DoBField";
            // 
            // ContactField
            // 
            this.ContactField.AutoSize = true;
            this.ContactField.Location = new System.Drawing.Point(153, 68);
            this.ContactField.Name = "ContactField";
            this.ContactField.Size = new System.Drawing.Size(66, 13);
            this.ContactField.TabIndex = 5;
            this.ContactField.Text = "ContactField";
            // 
            // SexField
            // 
            this.SexField.AutoSize = true;
            this.SexField.Location = new System.Drawing.Point(153, 25);
            this.SexField.Name = "SexField";
            this.SexField.Size = new System.Drawing.Size(47, 13);
            this.SexField.TabIndex = 7;
            this.SexField.Text = "SexField";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sex";
            // 
            // PronounsField
            // 
            this.PronounsField.AutoSize = true;
            this.PronounsField.Location = new System.Drawing.Point(282, 25);
            this.PronounsField.Name = "PronounsField";
            this.PronounsField.Size = new System.Drawing.Size(74, 13);
            this.PronounsField.TabIndex = 9;
            this.PronounsField.Text = "PronounsField";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pronouns";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(298, 114);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PhoneField
            // 
            this.PhoneField.AutoSize = true;
            this.PhoneField.Location = new System.Drawing.Point(13, 114);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(60, 13);
            this.PhoneField.TabIndex = 12;
            this.PhoneField.Text = "PhoneField";
            // 
            // PhoneFieldlabel
            // 
            this.PhoneFieldlabel.AutoSize = true;
            this.PhoneFieldlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneFieldlabel.Location = new System.Drawing.Point(13, 98);
            this.PhoneFieldlabel.Name = "PhoneFieldlabel";
            this.PhoneFieldlabel.Size = new System.Drawing.Size(51, 16);
            this.PhoneFieldlabel.TabIndex = 11;
            this.PhoneFieldlabel.Text = "Phone";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 143);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.PhoneFieldlabel);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PronounsField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SexField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactField);
            this.Controls.Add(this.DoBField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameField;
        private System.Windows.Forms.Label DoBField;
        private System.Windows.Forms.Label ContactField;
        private System.Windows.Forms.Label SexField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PronounsField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label PhoneField;
        private System.Windows.Forms.Label PhoneFieldlabel;
    }
}