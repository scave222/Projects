using GlobalIT_FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalIT_FormValidation.ServiceRepository
{
   public interface IForm
    {
        IEnumerable<Form> Forms { get; }
        public void AddForm(Form form );
    }
}
