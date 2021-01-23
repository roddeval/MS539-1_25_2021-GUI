using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_1_25_2021_GUI.Entities
{

    public class FormInputs
    {

        public FormInputs()
        {
            Initialize();
        }

        public FormInputs(FormInputs formInputs)
        {
            Initialize();
            Copy(formInputs);
        }

        public void Copy(FormInputs formInputs)
        {
            if (formInputs != null)
            {
                this.Name = formInputs.Name;
                this.DOB = formInputs.DOB;
                this.Gender = formInputs.Gender;
                this.Age = formInputs.Age;
            }
        }

        public void Initialize()
        {
            this.Name = string.Empty;
            this.DOB = string.Empty;
            this.Gender = string.Empty;
            this.Age = string.Empty;
        }

        public string Name { set; get; }
        public string DOB { set; get; }
        public string Gender { set; get; }
        public string Age { set; get; }
    }
}
