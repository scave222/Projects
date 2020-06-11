using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewPractice.Models;

namespace ViewPractice.Controllers
{
    
    public class StudentDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

        public ViewResult Details()
        {
            //String string Data
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //storing Student Data
            ViewData["Student"] = student;
            ViewBag.Stud = student;
            return View();
        }
    }

}
