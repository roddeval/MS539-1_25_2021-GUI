using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS539_1_25_2021_GUI.Entities;
using MS539_1_25_2021_GUI.Logic;
namespace MS539_1_25_2021_GUI
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private FormInputs ProcessFormInputs(FormInputs formInputs)
        {
            string message = "";
            StringBuilder stringBuilder = null;
            Exception oops = null;
            ValidationLogic validationLogic = null;
            FormInputsValidator formInputsValidator = null;

            try
            {
                ResetErrorLabels();
                if (formInputs != null)
                {


                    validationLogic = new ValidationLogic();
                    formInputsValidator = validationLogic.ValidateFormInputs(formInputs);
                    if (formInputsValidator != null)
                    {
                        if (formInputsValidator.isError == true)
                        {
                            if (formInputsValidator.isNameOK == false)
                            {
                                errorProvider1.SetError(txtName, formInputsValidator.NameExplanation);
                                lblNameExplanation.Text = formInputsValidator.NameExplanation;
                            }
                            if (formInputsValidator.isDOBOK == false)
                            {
                                errorProvider1.SetError(dateTimePicker1, formInputsValidator.DOBExplanation);
                                lblDOBExplanation.Text = formInputsValidator.DOBExplanation;
                            }
                            if (formInputsValidator.isGenderOK == false)
                            {
                                errorProvider1.SetError(grpGender, formInputsValidator.GenderExplanation);
                                lblGenderExplanation.Text = formInputsValidator.GenderExplanation;
                            }
                            if (formInputsValidator.isAgeOK == false)
                            {
                                errorProvider1.SetError(txtAge, formInputsValidator.AgeExplanation);
                                lblAgeExplanation.Text = formInputsValidator.AgeExplanation;
                            }
                            lblError.Text = formInputsValidator.ErrorMessage;
                        }
                        else
                        {
                            lblError.Text = "No Errors found! Great work!";
                        }
                    }
                    else
                    {
                        lblError.Text = "No Errors found! Great work!";
                    }
                }
            }
            catch (Exception exception)
            {
                stringBuilder = new StringBuilder();
                // walking the stack trace for all error information presented
                oops = exception;
                while (oops != null)
                {
                    message = oops.Message;
                    stringBuilder.Append("Message: " + message + ".\r\n");

                    message = oops.Source;
                    stringBuilder.Append("\tSource: " + message + ".\r\n");

                    message = oops.StackTrace;
                    stringBuilder.Append("\tStackTrace: " + message + ".\r\n");
                    stringBuilder.Append("**********\r\n");
                    oops = oops.InnerException;
                }
            }
            return formInputs;
        }

        private void ResetErrorLabels()
        {
            errorProvider1.SetError(txtName, string.Empty);
            errorProvider1.SetError(dateTimePicker1, string.Empty);
            errorProvider1.SetError(grpGender, string.Empty);
            errorProvider1.SetError(txtAge, string.Empty);

            this.lblError.Text = string.Empty;
            this.lblNameExplanation.Text = string.Empty;
            this.lblDOBExplanation.Text = string.Empty;
            this.lblGenderExplanation.Text = string.Empty;
            this.lblAgeExplanation.Text = string.Empty;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormInputs formInputs = null;

            formInputs = new FormInputs();
            formInputs.Name = txtName.Text.Trim();
            formInputs.DOB = dateTimePicker1.Value.ToString();

            if (rbtnFemale.Checked == true)
            {
                formInputs.Gender = "1";
            }

            if (rbtnMale.Checked == true)
            {
                formInputs.Gender = "0";
            }

            formInputs.Age = txtAge.Text.Trim();
            ProcessFormInputs(formInputs);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetScreen_Click(object sender, EventArgs e)
        {
            ResetErrorLabels();
            this.txtName.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            this.rbtnFemale.Checked = false;
            this.rbtnMale.Checked = false;
            this.txtAge.Text = "";
        }

    }
}
