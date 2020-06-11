using GlobalIT_FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalIT_FormValidation.ServiceRepository
{
    public class FormDataRepository : IForm
    {
        private readonly List<Form> FormList = new List<Form>();
        public IEnumerable<Form> Forms
        {
            get
            {
                return FormList;
            }
        }

        public void AddForm(Form form)
        {
            this.FormList.Add(form);
        }
    }
}
