﻿namespace MS539_1_25_2021_GUI
{
    partial class frmErrorProvider
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
            this.components = new System.ComponentModel.Container();
            this.btnResetScreen = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAgeExplanation = new System.Windows.Forms.Label();
            this.lblGenderExplanation = new System.Windows.Forms.Label();
            this.lblDOBExplanation = new System.Windows.Forms.Label();
            this.lblNameExplanation = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetScreen
            // 
            this.btnResetScreen.Location = new System.Drawing.Point(154, 38);
            this.btnResetScreen.Name = "btnResetScreen";
            this.btnResetScreen.Size = new System.Drawing.Size(83, 23);
            this.btnResetScreen.TabIndex = 57;
            this.btnResetScreen.Text = "Reset Screen";
            this.btnResetScreen.UseVisualStyleBackColor = true;
            this.btnResetScreen.Click += new System.EventHandler(this.btnResetScreen_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(69, 410);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 56;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtnFemale);
            this.grpGender.Controls.Add(this.rbtnMale);
            this.grpGender.Location = new System.Drawing.Point(69, 205);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(249, 59);
            this.grpGender.TabIndex = 49;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(164, 28);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(67, 28);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(69, 380);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 54;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(216, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAgeExplanation
            // 
            this.lblAgeExplanation.AutoSize = true;
            this.lblAgeExplanation.Location = new System.Drawing.Point(104, 329);
            this.lblAgeExplanation.Name = "lblAgeExplanation";
            this.lblAgeExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblAgeExplanation.TabIndex = 53;
            // 
            // lblGenderExplanation
            // 
            this.lblGenderExplanation.AutoSize = true;
            this.lblGenderExplanation.Location = new System.Drawing.Point(104, 267);
            this.lblGenderExplanation.Name = "lblGenderExplanation";
            this.lblGenderExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblGenderExplanation.TabIndex = 50;
            // 
            // lblDOBExplanation
            // 
            this.lblDOBExplanation.AutoSize = true;
            this.lblDOBExplanation.Location = new System.Drawing.Point(104, 183);
            this.lblDOBExplanation.Name = "lblDOBExplanation";
            this.lblDOBExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblDOBExplanation.TabIndex = 48;
            // 
            // lblNameExplanation
            // 
            this.lblNameExplanation.AutoSize = true;
            this.lblNameExplanation.Location = new System.Drawing.Point(104, 132);
            this.lblNameExplanation.Name = "lblNameExplanation";
            this.lblNameExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblNameExplanation.TabIndex = 45;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(74, 309);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 51;
            this.lblAge.Text = "Age";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(107, 306);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 52;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 44;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(66, 166);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 46;
            this.lblDOB.Text = "DOB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmErrorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnResetScreen);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAgeExplanation);
            this.Controls.Add(this.lblGenderExplanation);
            this.Controls.Add(this.lblDOBExplanation);
            this.Controls.Add(this.lblNameExplanation);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmErrorProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmErrorProvider";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResetScreen;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAgeExplanation;
        private System.Windows.Forms.Label lblGenderExplanation;
        private System.Windows.Forms.Label lblDOBExplanation;
        private System.Windows.Forms.Label lblNameExplanation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}