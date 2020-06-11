using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalEFC.Models;
using PersonalEFC.ServiceRepository;

namespace PersonalEFC.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly IStudent _student;
        public HomeController(IStudent stud)
        {
            _student = stud;
        }
        public IActionResult List()
        {
            return View(_student.Students);
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                _student.AddStudent(student);
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View();
            }
        }

        public IActionResult index()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
