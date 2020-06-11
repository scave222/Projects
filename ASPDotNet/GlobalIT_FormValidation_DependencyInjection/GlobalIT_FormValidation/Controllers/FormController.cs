using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalIT_FormValidation.Models;
using GlobalIT_FormValidation.ServiceRepository;

namespace GlobalIT_FormValidation.Controllers
{
    public class FormController : Controller
    {
        public readonly IForm _form;
        public FormController(IForm frm)
        {
            _form = frm;
        }

        public IActionResult List()
        {
            return View(_form.Forms);
        }
        [HttpGet]
        public IActionResult Fill_Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Fill_Form(Form form)
        {
            if(ModelState.IsValid)
            {
                _form.AddForm(form);
                return View("Thank",form);
            }
            else
            {
                return View();
            }
            
        }
    }
}