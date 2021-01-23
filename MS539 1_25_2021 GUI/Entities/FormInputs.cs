using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_1_25_2021_GUI.Entities
{

    public enum GenderEnum
    {
        Male=0,
        Female = 1
    }

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
            this.DOB = DateTime.MinValue;
            this.Gender = GenderEnum.Male;
            this.Age = 0;
        }

        public string Name { set; get; }
        public DateTime DOB { set; get; }
        public GenderEnum Gender { set; get; }
        public Int32 Age { set; get; }
    }
}
