using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_1_25_2021_GUI.Entities
{
    public class FormInputsValidator : FormInputs
    {

        public const string ErrorNameExplanation = "You must enter a Name!";
        public const string ErrorDOBExplanation = "You must enter a valid DOB!";
        public const string ErrorGenderExplanation = "You must choose a gender!";
        public const string ErrorAgeExplanation = "You must input a valid (integer) age!";

        public bool isError { set; get; }
        public string ErrorMessage { set; get; }
        public FormInputsValidator()
        {

            Initialize();

        }

        public FormInputsValidator(FormInputsValidator formInputsValidator)
        {

            Initialize();

            Copy(formInputsValidator);

        }

        public void Copy(FormInputsValidator formInputsValidator)
        {

            if (formInputsValidator != null)
            {
                this.isError = formInputsValidator.isError;
                this.ErrorMessage = formInputsValidator.ErrorMessage;

                this.Name = formInputsValidator.Name;
                this.isNameOK = formInputsValidator.isNameOK;
                this.NameExplanation = formInputsValidator.NameExplanation;
                
                this.DOB = formInputsValidator.DOB;
                this.isDOBOK = formInputsValidator.isDOBOK;
                this.DOBExplanation = formInputsValidator.DOBExplanation;
                
                this.Gender = formInputsValidator.Gender;
                this.isGenderOK = formInputsValidator.isGenderOK;
                this.GenderExplanation = formInputsValidator.GenderExplanation;
                
                this.Age = formInputsValidator.Age;
                this.isAgeOK = formInputsValidator.isAgeOK;
                this.AgeExplanation = formInputsValidator.AgeExplanation;

            }
        }

        public override void Initialize()
        {

            base.Initialize();
            
            this.isError = false;
            this.ErrorMessage = "";

            this.isNameOK = true;
            this.NameExplanation = string.Empty;
            
            this.isDOBOK = true;
            this.DOBExplanation = string.Empty;
            
            this.isGenderOK = true;
            this.GenderExplanation = string.Empty;
            
            this.isAgeOK = true;
            this.AgeExplanation = string.Empty;

        }

        public bool isNameOK { set; get; }
        public string NameExplanation { set; get; }
        public bool isDOBOK { set; get; }
        public string DOBExplanation { set; get; }
        public bool isGenderOK { set; get; }
        public string GenderExplanation { set; get; }
        public bool isAgeOK { set; get; }
        public string AgeExplanation { set; get; }

    }
}
