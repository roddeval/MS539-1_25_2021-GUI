using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS539_1_25_2021_GUI.Entities;

namespace MS539_1_25_2021_GUI.Logic
{


    public class ValidationLogic
    {

        public FormInputsValidator ValidateFormInputs(FormInputs formInputs)
        {
            FormInputsValidator formInputsValidator = null;
            DateTime dob = DateTime.MinValue;
            Int32 age = 0;
            Int32 gender = 0;

            if (formInputs != null)
            {

                if (string.IsNullOrEmpty(formInputs.Name) == true)
                {
                    if (formInputsValidator == null)
                    {
                        formInputsValidator = new FormInputsValidator();
                    }
                    formInputsValidator.isError = true;
                    formInputsValidator.ErrorMessage += "Name has an error.";
                    formInputsValidator.isNameOK = false;
                    formInputsValidator.NameExplanation = FormInputsValidator.ErrorNameExplanation;

                }

                if (string.IsNullOrEmpty(formInputs.DOB) == false)
                {
                    if (DateTime.TryParse(formInputs.DOB.ToString(), out dob) == true)
                    {
                        if (dob == DateTime.MinValue)
                        {
                            if (formInputsValidator == null)
                            {
                                formInputsValidator = new FormInputsValidator();
                            }
                            formInputsValidator.isError = true;
                            formInputsValidator.ErrorMessage += "DOB has an error.";
                            formInputsValidator.isDOBOK = false;
                            formInputsValidator.DOBExplanation = FormInputsValidator.ErrorDOBExplanation;

                        }

                        if (dob == DateTime.MaxValue)
                        {
                            if (formInputsValidator == null)
                            {
                                formInputsValidator = new FormInputsValidator();
                            }
                            formInputsValidator.isError = true;
                            formInputsValidator.ErrorMessage += "DOB has an error.";
                            formInputsValidator.isDOBOK = false;
                            formInputsValidator.DOBExplanation = FormInputsValidator.ErrorDOBExplanation;
                        }

                    }
                    else
                    {
                        if (formInputsValidator == null)
                        {
                            formInputsValidator = new FormInputsValidator();
                        }
                        formInputsValidator.isError = true;
                        formInputsValidator.ErrorMessage += "DOB has an error.";
                        formInputsValidator.isDOBOK = false;
                        formInputsValidator.DOBExplanation = FormInputsValidator.ErrorDOBExplanation;
                    }
                }
                else
                {
                    if (formInputsValidator == null)
                    {
                        formInputsValidator = new FormInputsValidator();
                    }
                    formInputsValidator.isError = true;
                    formInputsValidator.ErrorMessage += "DOB has an error (it's empty).";
                    formInputsValidator.isDOBOK = false;
                    formInputsValidator.DOBExplanation = FormInputsValidator.ErrorDOBExplanation;
                }

                if (string.IsNullOrEmpty(formInputs.Gender) == false)
                {
                    if (Int32.TryParse(formInputs.Gender, out gender) == true)
                    {
                        switch (gender)
                        {
                            case 0:
                                // do nothing gendor = 0 = male;
                                break;
                            case 1:
                                // do nothing gendor = 1 = female;
                                break;
                            default:
                                if (formInputsValidator == null)
                                {
                                    formInputsValidator = new FormInputsValidator();
                                }
                                formInputsValidator.isError = true;
                                formInputsValidator.ErrorMessage += "Gender has an error.";
                                formInputsValidator.isGenderOK = false;
                                formInputsValidator.GenderExplanation = FormInputsValidator.ErrorGenderExplanation;

                                break;
                        }
                    }
                    else
                    {
                        if (formInputsValidator == null)
                        {
                            formInputsValidator = new FormInputsValidator();
                        }
                        formInputsValidator.isError = true;
                        formInputsValidator.ErrorMessage += "Gender has an error.";
                        formInputsValidator.isGenderOK = false;
                        formInputsValidator.GenderExplanation = FormInputsValidator.ErrorGenderExplanation;
                    }
                }
                else
                {
                    if (formInputsValidator == null)
                    {
                        formInputsValidator = new FormInputsValidator();
                    }
                    formInputsValidator.isError = true;
                    formInputsValidator.ErrorMessage += "Gender has an error.";
                    formInputsValidator.isGenderOK = false;
                    formInputsValidator.GenderExplanation = FormInputsValidator.ErrorGenderExplanation;
                }



                if (Int32.TryParse(formInputs.Age, out age) == true)
                {
                    if (age < 0)
                    {
                        if (formInputsValidator == null)
                        {
                            formInputsValidator = new FormInputsValidator();
                        }
                        formInputsValidator.isError = true;
                        formInputsValidator.ErrorMessage += "Age has an error.";
                        formInputsValidator.isAgeOK = false;
                        formInputsValidator.AgeExplanation = FormInputsValidator.ErrorAgeExplanation;
                    }


                    if (age == 0)
                    {
                        if (formInputsValidator == null)
                        {
                            formInputsValidator = new FormInputsValidator();
                        }
                        formInputsValidator.isError = true;
                        formInputsValidator.ErrorMessage += "Age has an error (cannot be 0).";
                        formInputsValidator.isAgeOK = false;
                        formInputsValidator.AgeExplanation = FormInputsValidator.ErrorAgeExplanation;
                    }

                }
                else
                {
                    if (formInputsValidator == null)
                    {
                        formInputsValidator = new FormInputsValidator();
                    }
                    formInputsValidator.isError = true;
                    formInputsValidator.ErrorMessage += "Age has an error.";
                    formInputsValidator.isAgeOK = false;
                    formInputsValidator.AgeExplanation = FormInputsValidator.ErrorAgeExplanation;
                }
            }
            else
            {

                formInputsValidator = new FormInputsValidator();
                formInputsValidator.isError = true;
                formInputsValidator.ErrorMessage += "FormInputs is null.";
                formInputsValidator.isNameOK = false;
                formInputsValidator.NameExplanation = FormInputsValidator.ErrorNameExplanation;
                formInputsValidator.isDOBOK = false;
                formInputsValidator.DOBExplanation = FormInputsValidator.ErrorDOBExplanation;
                formInputsValidator.isGenderOK = false;
                formInputsValidator.GenderExplanation = FormInputsValidator.ErrorGenderExplanation;
                formInputsValidator.isAgeOK = false;
                formInputsValidator.AgeExplanation = FormInputsValidator.ErrorAgeExplanation;
            }

            

            return formInputsValidator;
        }
    }
}
